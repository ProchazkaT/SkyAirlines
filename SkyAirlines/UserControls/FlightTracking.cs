using FSUIPC;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using SkyAirlines.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SkyAirlines
{
    public partial class FlightTracking : UserControl
    {
        private ConnectionToSQL connectionToSQL;

        private GetPilotSQLData pilotSqlData = new GetPilotSQLData();
        private GetAirlineData AirlineSqlData = new GetAirlineData();

        private Panel panel = new Panel();

        /*
        Toto jsou offsety, které určují UIPC, co přesně chceš tahat za data z leteckého simulátoru.
        Co přesně za data taháš určuje kód, co je v kulatých závorkách př. (0x560)
        Offsety se udávají ve FSUnits, které se potom musí převádět na hodnotu, kterou potřebuješ.
        Např. Taháš rychlost ze simulátoru, FSUnits ti vytáhne hodnotu 24567, tak to potom musíš přepočítat, 
        aby ti to ukazovalo knoty.
        */
        private Offset<long> latitudeOffset = new Offset<long>(0x560);
        private Offset<long> longitudeOffset = new Offset<long>(0x568);
        private Offset<int> speedOffset = new Offset<int>(0x02B8);
        private Offset<int> groundSpeedOffset = new Offset<int>(0x02B4);
        private Offset<int> altitudeOffset = new Offset<int>(0x3324);
        private Offset<int> landingRateOffset = new Offset<int>(0x030C);

        private GMapOverlay markersOverlay = new GMapOverlay("AirportMarkers");
        private GMapOverlay routesOverlay = new GMapOverlay("routesOverlay");
        private GMapOverlay airplaneOverlay = new GMapOverlay("airplaneOverlay");
        private GMapOverlay routeOverlay = new GMapOverlay("RouteOverlay");
        private GMapRoute airplaneRoute;

        private long latitude = 0;
        private long longitude = 0;
        private double speedGS = 0;
        private int speedTAS = 0;
        private int altitudeFeet = 0;
        private int distanceNmFromAircraft = 0;
        private int distanceNM = 0;
        private int finalLandingRate = 0;

        public FlightTracking(Panel panelMain)
        {
            InitializeComponent();
            panel = panelMain;

            connectionToSQL = new ConnectionToSQL();
        }

        private void InitializeMap()
        {
            gMapControl.MapProvider = GMapProviders.GoogleMap;
            gMapControl.ShowCenter = false;
            gMapControl.MinZoom = 0;
            gMapControl.MaxZoom = 24;
            gMapControl.Zoom = 4;
            gMapControl.CanDragMap = true;
            Controls.Add(gMapControl);

            gMapControl.Overlays.Add(markersOverlay);
            gMapControl.Overlays.Add(routesOverlay);
            gMapControl.Overlays.Add(routeOverlay);

            SetDepartureAndArrivalMarkers();
        }

        public void SetDepartureAndArrivalMarkers()
        {
            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand departureCmd = new SqlCommand();
                    departureCmd.Connection = connection;
                    departureCmd.CommandText = "SELECT icao, name, lat, lon FROM Airports WHERE icao=@departureIcao";
                    departureCmd.Parameters.AddWithValue("@departureIcao", GlobalData.Departure);

                    SqlDataReader departureReader = departureCmd.ExecuteReader();
                    while (departureReader.Read())
                    {
                        string description = departureReader["icao"].ToString().Trim() + " - " + departureReader["name"].ToString().Trim();

                        double latitude;
                        double longitude;

                        if (double.TryParse(departureReader["lat"].ToString().Trim().Replace(',', '.'), out latitude) &&
                            double.TryParse(departureReader["lon"].ToString().Trim().Replace(',', '.'), out longitude))
                        {
                            CustomMarker marker = new CustomMarker(new PointLatLng(latitude, longitude), Properties.Resources.Departure, description);
                            markersOverlay.Markers.Add(marker);
                        }
                    }
                    departureReader.Close();

                    SqlCommand arrivalCmd = new SqlCommand();
                    arrivalCmd.Connection = connection;
                    arrivalCmd.CommandText = "SELECT icao, name, lat, lon FROM Airports WHERE icao=@arrivalIcao";
                    arrivalCmd.Parameters.AddWithValue("@arrivalIcao", GlobalData.Arrival);

                    SqlDataReader arrivalReader = arrivalCmd.ExecuteReader();
                    while (arrivalReader.Read())
                    {
                        string description = arrivalReader["icao"].ToString().Trim() + " - " + arrivalReader["name"].ToString().Trim();

                        double latitude;
                        double longitude;

                        if (double.TryParse(arrivalReader["lat"].ToString().Trim().Replace(',', '.'), out latitude) &&
                            double.TryParse(arrivalReader["lon"].ToString().Trim().Replace(',', '.'), out longitude))
                        {
                            CustomMarker marker = new CustomMarker(new PointLatLng(latitude, longitude), Properties.Resources.Arrival, description);
                            markersOverlay.Markers.Add(marker);
                        }
                    }
                    arrivalReader.Close();

                    if (markersOverlay.Markers.Count == 2)
                    {
                        List<PointLatLng> points = new List<PointLatLng>
                        {
                            markersOverlay.Markers[0].Position,
                            markersOverlay.Markers[1].Position
                        };

                        GMapRoute route = new GMapRoute(points, "Route");
                        route.Stroke = new Pen(Color.Purple)
                        {
                            DashStyle = DashStyle.Dash
                        };

                        routesOverlay.Routes.Add(route);
                    }

                    connection.Close();
                }
                catch (Exception)
                {
                    connection.Close();
                }
            }
        }

        public void ChangeMainPanel(UserControl userControl)
        {
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Anchor = AnchorStyles.None;
        }

        private double CalculateDistanceNM(PointLatLng point1, PointLatLng point2)
        {
            const double EarthRadiusNM = 3440.065;

            double lat1 = point1.Lat * Math.PI / 180.0;
            double lon1 = point1.Lng * Math.PI / 180.0;
            double lat2 = point2.Lat * Math.PI / 180.0;
            double lon2 = point2.Lng * Math.PI / 180.0;

            double dlat = lat2 - lat1;
            double dlon = lon2 - lon1;

            double a = Math.Sin(dlat / 2) * Math.Sin(dlat / 2) +
                       Math.Cos(lat1) * Math.Cos(lat2) *
                       Math.Sin(dlon / 2) * Math.Sin(dlon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return EarthRadiusNM * c;
        }

        private void UpdateAirplanePosition(double latitude, double longitude)
        {
            airplaneOverlay.Clear();

            CustomMarker marker = new CustomMarker(new PointLatLng(latitude, longitude), Properties.Resources.AirplaneMarker, "Your plane");
            airplaneOverlay.Markers.Add(marker);

            gMapControl.Overlays.Add(airplaneOverlay);

            gMapControl.Position = new PointLatLng(latitude, longitude);
        }

        public int CalculateFlightRating(int landingRate)
        {
            //Zde si nadefinujeme nejhorší akceptovatelné přistání
            int minLandingRate = -500;

            //Zde si nadefinujeme nejlepší přistání
            int maxLandingRate = 0;

            //Zde si nadefinujeme ohodnocení - nejmenší a největší ohodnocení
            int minRating = 0;
            int maxRating = 100;

            /*
            Zde je výpočet na rozsah, který je omezen mezi 'minLandingRate' a 'maxLandingRate' pomocí funkce 'Math.Min' a 'Math.Max'
            Když je 'landingRate' menší než 'minLandingRate', bude nastaveno na 'minLandingRate', 
            a pokud je větší než 'maxLandingRate', bude nastaveno na 'maxLandingRate'.
            */
            landingRate = Math.Max(minLandingRate, Math.Min(maxLandingRate, landingRate));

            /*
            Zde se vypočítá hodnota 'rating' pomocí lineární interpolace. 
            To znamená, že se 'landingRate' normalizuje do rozsahu 0 až 1 vzhledem k rozsahu mezi 'minLandingRate' a 'maxLandingRate'. 
            Pak se tato normalizovaná hodnota vynásobí rozdílem mezi 'maxRating' a 'minRating' a přičte se 'minRating', což umožňuje převést normalizovanou 
            hodnotu 'landingRate' na odpovídající hodnotu 'rating' v rozsahu mezi 'minRating' a 'maxRating'.
            */
            double rating = ((double)(landingRate - minLandingRate) / (maxLandingRate - minLandingRate)) * (maxRating - minRating) + minRating;

            //Vrátí hodnotu 'rating', kterou zaokrouhlí a převede na int
            return (int)Math.Round(rating);
        }

        public int CalculateXP(int landingRate)
        {
            //Zde si nadefinujeme nejhorší akceptovatelné přistání
            int minLandingRate = -500;

            //Zde si nadefinujeme nejlepší přistání
            int maxLandingRate = 0;

            //Zde si nadefinujeme udělování zkušeností - nejmenší a největší počet zkušeností
            int minXP = 0;
            int maxXP = 20;

            /*
            Zde je výpočet na rozsah, který je omezen mezi 'minLandingRate' a 'maxLandingRate' pomocí funkce 'Math.Min' a 'Math.Max'
            Když je 'landingRate' menší než 'minLandingRate', bude nastaveno na 'minLandingRate', 
            a pokud je větší než 'maxLandingRate', bude nastaveno na 'maxLandingRate'.
            */
            landingRate = Math.Max(minLandingRate, Math.Min(maxLandingRate, landingRate));

            /*
            Zde se vypočítá hodnota 'xp' pomocí lineární interpolace. 
            To znamená, že se 'landingRate' normalizuje do rozsahu 0 až 1 vzhledem k rozsahu mezi 'minLandingRate' a 'maxLandingRate'. 
            Pak se tato normalizovaná hodnota vynásobí rozdílem mezi 'maxXP' a 'minXP' a přičte se 'minXP', což umožňuje převést normalizovanou 
            hodnotu 'landingRate' na odpovídající hodnotu 'xp' v rozsahu mezi 'minXP' a 'maxXP'.
            */
            double xp = ((double)(landingRate - minLandingRate) / (maxLandingRate - minLandingRate)) * (maxXP - minXP) + minXP;

            //Vrátí hodnotu 'xp', kterou zaokrouhlí a převede na int
            return (int)Math.Round(xp);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FlightTrackingSystem();
        }

        private void FlightTrackingSystem()
        {
            try
            {
                //Zapne se komunikace mezi aplikací a leteckým simulátorem
                FSUIPCConnection.Process();

                //Zde se z FSUnits, které jsou získány pomocí offsetů, převádí na reálné čísla.
                latitude = latitudeOffset.Value;
                longitude = longitudeOffset.Value;
                speedGS = groundSpeedOffset.Value * 1.94384449 / 65536;
                speedTAS = speedOffset.Value / 128;
                altitudeFeet = altitudeOffset.Value;
                int altitudeMeters = (int)(altitudeFeet * 0.3048);

                double latitudeDeg = latitude * 90.0 / (10001750.0 * 65536.0 * 65536.0);
                double longitudeDeg = longitude * 360.0 / (65536.0 * 65536.0 * 65536.0 * 65536.0);
                double landingRate = (double)landingRateOffset.Value;

                //Zde se dosazují převedené hodnoty do labelů, které ukazují tyto údaje ve 'Flight'
                lblLatitude.Text = latitudeDeg.ToString() + "°";
                lblLongitude.Text = longitudeDeg.ToString() + "°";
                lblAltitude.Text = altitudeFeet.ToString() + " ft";
                lblAltitudeMetres.Text = altitudeMeters.ToString() + " m";
                lblSpeed.Text = ((int)speedGS).ToString() + " kts";
                lblIAS.Text = speedTAS.ToString() + " kts";

                /*
                Zde, když pilot přistane, tak to zaznamená přistání a ukáže, jak dobře přistál.
                Je to ošetřené, aby se to ukázalo pouze jednou a nespamovalo to uživatele.
                */
                if (landingRate < 0)
                {
                    //MessageBox.Show("Your landing rate: " + landingRate.ToString() + " FPM", "Landing rate:");
                    finalLandingRate = (int)landingRate;
                    btnSubmitFlight.Enabled = true;
                }

                //Toto je metoda aktualizující pozici letadla na mapě.
                UpdateAirplanePosition(latitudeDeg, longitudeDeg);

                //Nadefinové markery letišť, odkud kam pilot letí.
                CustomMarker arrivalMarker = (CustomMarker)markersOverlay.Markers[1];
                CustomMarker airplaneMarker = (CustomMarker)airplaneOverlay.Markers[0];

                //Výpočet na vzdálenost mezi letištěm a letadlem.
                distanceNmFromAircraft = (int)Math.Round(CalculateDistanceNM(airplaneMarker.Position, arrivalMarker.Position));
                lblDistance.Text = distanceNmFromAircraft.ToString() + " nm";

                /*
                 Pojistka, jestli hráč letí let, tak jak má.
                 Takovéto rychlosti většinou dosahuje při letu, takže když se spawne na přistání, 
                 při této rychlosti se nepřistává.
                */
                if (lblSpeed.Text == "350")
                {
                    GlobalData.isFlown = true;
                }

                //Zde se ukládájí body, které vykreslují trajektorii letu za letadlem.
                if (airplaneRoute == null)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(airplaneMarker.Position);
                    airplaneRoute = new GMapRoute(points, "AirplaneRoute");
                    routeOverlay.Routes.Add(airplaneRoute);
                }
                else
                {
                    airplaneRoute.Points.Add(airplaneMarker.Position);
                    gMapControl.Refresh();
                }
            }
            catch (Exception)
            {
                //Toto se vrátí, když letecký simulátor není připojený.
                lblStatus.Text = "Error reading data from FSUIPC.";

                gMapControl.Zoom = 4;
                gMapControl.Position = new PointLatLng(50.14, 14.26);
                //MessageBox.Show(ex.ToString());

                FSUIPCConnection.Close();
                timer1.Stop();
            }
        }

        private void btnSubmitFlight_Click(object sender, EventArgs e)
        {
            if (GlobalData.isFlown == true && distanceNmFromAircraft <= 1)
            {

                FSUIPCConnection.Close();
                timer1.Stop();
                GlobalData.isFlown = false;

                double salaryPilot = double.Parse(pilotSqlData.GetPilotSalary(GlobalData.Username));
                double salaryAirline = double.Parse(AirlineSqlData.GetAirlineSalary());
                double costPerMile = double.Parse(AirlineSqlData.GetAirlineCostPerMile());

                double moneyPilotDouble = distanceNM * costPerMile * salaryPilot + pilotSqlData.GetPilotMoney(GlobalData.Username);
                double moneyAirlineDouble = distanceNM * costPerMile * salaryAirline + int.Parse(AirlineSqlData.GetAirlineMoney());

                int moneyPilot = int.Parse(moneyPilotDouble.ToString());
                int moneyAirline = int.Parse(moneyAirlineDouble.ToString());

                int pilotFlights = pilotSqlData.GetPilotFlights(GlobalData.Username) + 1;
                int landingRate = pilotSqlData.GetPilotAverageLandingRate(GlobalData.Username) + (finalLandingRate);
                int pilotRating = pilotSqlData.GetPilotRating(GlobalData.Username) + CalculateFlightRating(finalLandingRate);
                int xp = pilotSqlData.GetPilotXP(GlobalData.Username) + CalculateXP(finalLandingRate);

                using (SqlConnection connection = connectionToSQL.CreateConnection())
                {
                    try
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;

                        string[] airport = lblArrival.Text.Split('-');

                        cmd.CommandText = "UPDATE Pilot SET Money = @money, Departure=@departure, Arrival=NULL, Destinations=@destinations, Flights=@flights, AverageLandingRate=@averageLandingRate, XP=@xp, Rating=@rating WHERE Username = @username";
                        cmd.Parameters.AddWithValue("@money", moneyPilot);
                        cmd.Parameters.AddWithValue("@departure", airport[0].Trim());
                        cmd.Parameters.AddWithValue("@destinations", airport[0].Trim() + ",");
                        cmd.Parameters.AddWithValue("@flights", pilotFlights);
                        cmd.Parameters.AddWithValue("@averageLandingRate", landingRate);
                        cmd.Parameters.AddWithValue("@xp", xp);
                        cmd.Parameters.AddWithValue("@rating", pilotRating);
                        cmd.Parameters.AddWithValue("@username", GlobalData.Username);
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "UPDATE Airline SET AirlineMoney = @moneyAirline WHERE ID = @id";
                        cmd.Parameters.AddWithValue("@moneyAirline", moneyAirline);
                        cmd.Parameters.AddWithValue("@id", GlobalData.airlineID);
                        cmd.ExecuteNonQuery();

                        connection.Close();

                        lblAirplane.Text = "";
                        lblAltitude.Text = "";
                        lblAltitudeMetres.Text = "";
                        lblArrival.Text = "";
                        lblDeparture.Text = "";
                        lblDistance.Text = "";
                        lblIAS.Text = "";
                        lblLatitude.Text = "";
                        lblLongitude.Text = "";
                        lblSpeed.Text = "";
                        lblStatus.Text = "";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An error occurred while submitting the flight.", "Error:");
                    }
                }

                MessageBox.Show("You have successfully flown your flight!\n\nYou earned: " + moneyPilot + "\nYou earned for the airline: " + moneyAirline, "Notification:");
            }
            else
            {
                MessageBox.Show("You did not fly the generated flight!", "Notification:");
            }
        }

        private void FlightTracking_Load(object sender, EventArgs e)
        {
            InitializeMap();

            if (markersOverlay.Markers.Count >= 2)
            {
                CustomMarker departureMarker = (CustomMarker)markersOverlay.Markers[0];
                CustomMarker arrivalMarker = (CustomMarker)markersOverlay.Markers[1];

                int FlightDistanceNM = (int)Math.Round(CalculateDistanceNM(departureMarker.Position, arrivalMarker.Position));
                distanceNM = FlightDistanceNM;
                lblDistance.Text = FlightDistanceNM.ToString() + " nm";
                lblDeparture.Text = departureMarker.ToolTipText;
                lblArrival.Text = arrivalMarker.ToolTipText;
                lblAirplane.Text = GlobalData.AirplaneForFlight;

                try
                {
                    FSUIPCConnection.Open();

                    if (FSUIPCConnection.IsOpen)
                    {
                        lblStatus.Text = "Successfully connected to the simulator.";
                    }
                    else
                    {
                        lblStatus.Text = "Not connected to FS.";

                        gMapControl.Zoom = 4;
                        gMapControl.Position = new PointLatLng(50.14, 14.26);

                        FSUIPCConnection.Close();
                        timer1.Stop();

                        if (markersOverlay.Markers.Count < 2)
                        {
                            markersOverlay.Clear();
                            MessageBox.Show("You have to generate flight in your Airline.", "Notification:");
                        }
                    }

                    timer1.Start();
                }
                catch (Exception)
                {
                    lblStatus.Text = "Not connected to FS.";

                    gMapControl.Zoom = 4;
                    gMapControl.Position = new PointLatLng(50.14, 14.26);

                    FSUIPCConnection.Close();
                    timer1.Stop();

                    if (markersOverlay.Markers.Count < 2)
                    {
                        markersOverlay.Clear();
                        MessageBox.Show("You have to generate flight in your Airline.", "Notification:");
                    }
                }
            }
            else
            {
                gMapControl.Zoom = 4;
                gMapControl.Position = new PointLatLng(50.14, 14.26);
            }
        }

        private void btnSimbriefDispatch_Click(object sender, EventArgs e)
        {
            if (lblArrival.Text != "" && lblDeparture.Text != "")
            {
                string[] departure = lblDeparture.Text.Split('-');
                string[] arrival = lblArrival.Text.Split('-');

                string origValue = departure[0].Trim();
                string destValue = arrival[0].Trim();

                string url = $"https://dispatch.simbrief.com/options/custom?orig={origValue}&dest={destValue}&pax=AUTO&cargo=AUTO&fl=AUTO";

                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    });
                }
                catch (Exception)
                {
                    Console.WriteLine("Error opening web page.", "Notification:");
                }
            }
        }

        private void btnSimbriefOFP_Click(object sender, EventArgs e)
        {
            if (lblArrival.Text != "" && lblDeparture.Text != "")
            {
                string url = "https://dispatch.simbrief.com/briefing/latest";

                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    });
                }
                catch (Exception)
                {
                    Console.WriteLine("Error opening web page.", "Notification:");
                }
            }
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn;
            btn = (Button)sender;
            btn.FlatAppearance.BorderSize = 3;
            btn.FlatAppearance.BorderColor = Color.RoyalBlue;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn;
            btn = (Button)sender;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.BorderColor = Color.FromArgb(16, 47, 82);
        }
    }
}