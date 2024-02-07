﻿using FSUIPC;
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
        private SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();

        private GetPilotSQLData pilotSqlData = new GetPilotSQLData();
        private GetAirlineData AirlineSqlData = new GetAirlineData();

        private Panel panel = new Panel();

        private Offset<long> latitudeOffset = new Offset<long>(0x560);
        private Offset<long> longitudeOffset = new Offset<long>(0x568);
        private Offset<int> speedOffset = new Offset<int>(0x02B8);
        private Offset<int> altitudeOffset = new Offset<int>(0x3324);
        private Offset<int> landingRateOffset = new Offset<int>(0x030C);

        private GMapOverlay markersOverlay = new GMapOverlay("AirportMarkers");
        private GMapOverlay routesOverlay = new GMapOverlay("routesOverlay");
        private GMapOverlay airplaneOverlay = new GMapOverlay("airplaneOverlay");
        private GMapOverlay routeOverlay = new GMapOverlay("RouteOverlay");
        private GMapRoute airplaneRoute;

        private long latitude = 0;
        private long longitude = 0;
        private int speedGS = 0;
        private int speedTAS = 0;
        private int altitudeFeet = 0;
        private int ias = 0;
        private int distanceNmFromAircraft = 0;
        private int distanceNM = 0;
        private bool isLanded = false;

        public FlightTracking(Panel panelMain)
        {
            InitializeComponent();
            panel = panelMain;

            sqlBuilder.DataSource = @"SkyAirlines.mssql.somee.com";
            sqlBuilder.InitialCatalog = "SkyAirlines";
            sqlBuilder.UserID = "TooM_SQLLogin_1";
            sqlBuilder.Password = "li21a3sl6v";

            InitializeMap();
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
            using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                FSUIPCConnection.Process();

                latitude = latitudeOffset.Value;
                longitude = longitudeOffset.Value;
                speedGS = speedOffset.Value * 3600 / 65536 / 1852;
                speedTAS = speedOffset.Value / 128;
                altitudeFeet = altitudeOffset.Value;
                int altitudeMeters = (int)(altitudeFeet * 0.3048);

                double latitudeDeg = latitude * 90.0 / (10001750.0 * 65536.0 * 65536.0);
                double longitudeDeg = longitude * 360.0 / (65536.0 * 65536.0 * 65536.0 * 65536.0);
                double landingRate = (double)landingRateOffset.Value;

                lblLatitude.Text = latitudeDeg.ToString() + "°";
                lblLongitude.Text = longitudeDeg.ToString() + "°";
                lblAltitude.Text = altitudeFeet.ToString() + " ft";
                lblAltitudeMetres.Text = altitudeMeters.ToString() + " m";
                lblSpeed.Text = speedGS.ToString() + " kts";
                lblIAS.Text = speedTAS.ToString() + " kts";

                if (landingRate < 0 && isLanded == false)
                {
                    isLanded = true;
                    MessageBox.Show("Your landing rate: " + landingRate.ToString() + " FPM", "Landing rate:");
                }

                UpdateAirplanePosition(latitudeDeg, longitudeDeg);

                CustomMarker arrivalMarker = (CustomMarker)markersOverlay.Markers[1];
                CustomMarker airplaneMarker = (CustomMarker)airplaneOverlay.Markers[0];

                distanceNmFromAircraft = (int)Math.Round(CalculateDistanceNM(airplaneMarker.Position, arrivalMarker.Position));
                lblDistance.Text = distanceNmFromAircraft.ToString() + " nm";

                if (lblSpeed.Text == "350")
                {
                    GlobalData.isFlown = true;
                }

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
                lblStatus.Text = "Error reading data from FSUIPC.";

                gMapControl.Zoom = 4;
                gMapControl.Position = new PointLatLng(50.14, 14.26);

                FSUIPCConnection.Close();
                timer1.Stop();
            }
        }

        private void btnSubmitFlight_Click(object sender, EventArgs e)
        {
            if (GlobalData.isFlown == true && distanceNmFromAircraft <= 3)
            {

                FSUIPCConnection.Close();
                timer1.Stop();
                GlobalData.isFlown = false;

                double salaryPilot = double.Parse(pilotSqlData.GetPilotSalary());
                double salaryAirline = double.Parse(AirlineSqlData.GetAirlineSalary());
                double costPerMile = double.Parse(AirlineSqlData.GetAirlineCostPerMile());

                double moneyPilotDouble = distanceNM * costPerMile * salaryPilot + pilotSqlData.GetPilotMoney();
                double moneyAirlineDouble = distanceNM * costPerMile * salaryAirline + int.Parse(AirlineSqlData.GetAirlineMoney());

                int moneyPilot = int.Parse(moneyPilotDouble.ToString());
                int moneyAirline = int.Parse(moneyAirlineDouble.ToString());

                using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
                {
                    try
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;

                        string[] airport = lblArrival.Text.Split('-');

                        cmd.CommandText = "UPDATE Pilot SET Money = @money, Departure=@departure, Arrival=NULL WHERE Username = @username";
                        cmd.Parameters.AddWithValue("@money", moneyPilot);
                        cmd.Parameters.AddWithValue("@departure", airport[0].Trim());
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