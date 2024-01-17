using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using SkyAirlines.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SkyAirlines
{
    public partial class AirlineBoss : UserControl
    {
        private SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
        private GetAirlineData getAirlineData = new GetAirlineData();
        private Licences licences = new Licences();

        private GMapOverlay markersOverlay;
        private CustomMarker clickedMarker;
        private string markerDescription = "";

        private Panel panel;
        private string name;
        private string role;

        public AirlineBoss(Panel panel)
        {
            InitializeComponent();

            this.panel = panel;

            sqlBuilder.DataSource = @"SkyAirlines.mssql.somee.com";
            sqlBuilder.InitialCatalog = "SkyAirlines";
            sqlBuilder.UserID = "TooM_SQLLogin_1";
            sqlBuilder.Password = "li21a3sl6v";

            lblAirlineName.Text = getAirlineData.GetAirlineName();
            lblMembers.Text = getAirlineData.GetAirlineMembers().ToString() + " / 20";
            lblMoney.Text = getAirlineData.GetAirlineMoney() + " $";
            lblFleet.Text = getAirlineData.GetAirlineFleet();
            lblHeadquarter.Text = getAirlineData.GetAirlineHeadquarter();

            cbFleet.DataSource = GetCommonLicencesWithPilot();
            cbFleet.DropDownStyle = ComboBoxStyle.DropDownList;
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
            gMapControl.Position = new PointLatLng(50.14, 14.26);

            Controls.Add(gMapControl);

            SetAirportsMarkers();
            gMapControl.OnMarkerClick += new MarkerClick(gMapControl_OnMarkerClick);
        }

        private void AirlineBoss_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT Username, Boss FROM Pilot WHERE Airline = @Airline";
                    cmd.Parameters.AddWithValue("@Airline", GlobalData.airlineID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string name = reader["Username"].ToString().Trim();
                        string role = reader["Boss"].ToString().Trim();
                        string id = GlobalData.airlineID;

                        if (role == id)
                        {
                            MemberRow memberRow = new MemberRow(name, "CEO");
                            FlowRow.Controls.Add(memberRow);
                        }
                        else
                        {
                            MemberRow memberRow = new MemberRow(name, "Pilot");
                            FlowRow.Controls.Add(memberRow);
                        }
                    }
                    reader.Close();

                }
                catch
                {

                }
                connection.Close();
            }
        }

        private void btnKick_Click(object sender, EventArgs e)
        {
            if (tbManageUsername.Texts != "")
            {
                if (tbManageUsername.Texts != GlobalData.Username)
                {
                    using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
                    {
                        try
                        {
                            connection.Open();

                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = connection;

                            cmd.CommandText = "UPDATE Pilot SET Airline=NULL, Departure=NULL, Arrival=NULL, AirplaneForFlight=NULL  WHERE Username=@username AND Airline=@airline";
                            cmd.Parameters.AddWithValue("@username", tbManageUsername.Texts);
                            cmd.Parameters.AddWithValue("@airline", GlobalData.airlineID);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("You fired the pilot - " + tbManageUsername.Texts, "Notification:");
                        }
                        catch
                        {
                            MessageBox.Show("You must enter an exact username.", "Notification:");
                        }
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("You cannot enter your username.", "Notification:");
                }
            }
            else
            {
                MessageBox.Show("You must enter an exact username.", "Notification:");
            }
        }

        private void btnGenerateFlight_Click(object sender, EventArgs e)
        {
            if (lblDestination.Text != "")
            {
                using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
                {
                    try
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;

                        cmd.CommandText = "UPDATE Pilot SET Arrival = @arrival, AirplaneForFlight=@airplaneForFlight WHERE Username = @username";
                        cmd.Parameters.AddWithValue("@arrival", lblDestination.Text);
                        cmd.Parameters.AddWithValue("@airplaneForFlight", cbFleet.Text);
                        cmd.Parameters.AddWithValue("@username", GlobalData.Username);
                        cmd.ExecuteNonQuery();

                        GlobalData.Arrival = lblDestination.Text;
                        GlobalData.AirplaneForFlight = cbFleet.Text;

                        MessageBox.Show("You successfully generate your flight and now you can go to 'Flight' and start your flight!", "Notification:");
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            else
            {
                MessageBox.Show("You have to choose destination!", "Notification:");
            }
        }

        private void btnCopyFlight_Click(object sender, EventArgs e)
        {
            string departure = "";
            string arrival = "";
            string airplaneForFlight = "";

            if (tbFlightUsername.Texts != "")
            {
                using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
                {
                    try
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;

                        cmd.CommandText = "SELECT Departure, Arrival, AirplaneForFlight FROM Pilot WHERE Airline = @Airline AND Username=@username";
                        cmd.Parameters.AddWithValue("@Airline", GlobalData.airlineID);
                        cmd.Parameters.AddWithValue("@username", tbFlightUsername.Texts);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            departure = reader["Departure"].ToString().Trim();
                            arrival = reader["Arrival"].ToString().Trim();
                            airplaneForFlight = reader["AirplaneForFlight"].ToString().Trim();
                        }
                        reader.Close();
                        connection.Close();
                    }
                    catch
                    {
                        connection.Close();
                        MessageBox.Show("SDA");
                    }
                }

                if (arrival != "")
                {
                    using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
                    {
                        try
                        {
                            connection.Open();

                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = connection;

                            cmd.CommandText = "UPDATE Pilot SET Departure = @departure, Arrival = @arrival, AirplaneForFlight=@airplaneForFlight WHERE Username = @username";
                            cmd.Parameters.AddWithValue("@departure", departure);
                            cmd.Parameters.AddWithValue("@arrival", arrival);
                            cmd.Parameters.AddWithValue("@airplaneForFlight", airplaneForFlight);
                            cmd.Parameters.AddWithValue("@username", GlobalData.Username);
                            cmd.ExecuteNonQuery();

                            GlobalData.Arrival = arrival;
                            GlobalData.Departure = departure;
                            GlobalData.AirplaneForFlight = airplaneForFlight;

                            MessageBox.Show("You successfully copy flight from friend and now you can go to 'Flight' and start your flight!", "Notification:");
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
                else
                    MessageBox.Show("The pilot has not generated flight!", "Notification:");
            }
            else
            {
                MessageBox.Show("You have to write pilot username to copy his flight!", "Notification:");
            }
        }

        public List<string> GetCommonLicencesWithPilot()
        {
            string fleetString = getAirlineData.GetAirlineFleet();
            List<string> fleet = new List<string>();

            List<string> pilotLicences = licences.GetPilotLicencesAsList();

            if (!string.IsNullOrEmpty(fleetString))
            {
                string[] fleetArray = fleetString.Split(',');

                foreach (string licence in fleetArray)
                {
                    fleet.Add(licence.Trim());
                }
            }

            List<string> commonLicences = fleet.Intersect(pilotLicences).ToList();

            return commonLicences;
        }

        public void SetAirportsMarkers()
        {
            markersOverlay = new GMapOverlay("AirportMarkers");
            gMapControl.Overlays.Add(markersOverlay);

            SetDepartureMarker();
            List<Tuple<double, double, string>> dataFromDatabase = GetDatabaseData();
            foreach (var data in dataFromDatabase)
            {
                double latitude = data.Item1;
                double longitude = data.Item2;
                string description = data.Item3;

                CustomMarker marker = new CustomMarker(new PointLatLng(latitude, longitude), Properties.Resources.AirportMarker, description);
                markersOverlay.Markers.Add(marker);
            }
        }

        public void SetDepartureMarker()
        {
            string departure = GlobalData.Departure;

            if (!string.IsNullOrEmpty(departure))
            {
                using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
                {
                    try
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;

                        cmd.CommandText = "SELECT icao, name, lat, lon FROM Airports WHERE icao=@icao";
                        cmd.Parameters.AddWithValue("@icao", departure);

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string description = reader["icao"].ToString().Trim() + " - " + reader["name"].ToString().Trim();

                            double latitude;
                            double longitude;

                            if (double.TryParse(reader["lat"].ToString().Trim().Replace(',', '.'), out latitude) &&
                                double.TryParse(reader["lon"].ToString().Trim().Replace(',', '.'), out longitude))
                            {
                                CustomMarker marker = new CustomMarker(new PointLatLng(latitude, longitude), Properties.Resources.HomeMarker, description);
                                markersOverlay.Markers.Add(marker);
                            }
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while retrieving airport information.\n" + ex.ToString(), "Error:");
                        connection.Close();
                    }
                    connection.Close();
                }
            }
        }


        private List<Tuple<double, double, string>> GetDatabaseData()
        {
            string destinationsString = getAirlineData.GetAirlineDestinations();
            string[] destinations = destinationsString.Split(',');
            string[] parameterNames = destinations.Select((_, index) => $"@dest_{index}").ToArray();

            var destinationsTuple = new List<Tuple<double, double, string>>();

            using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = $"SELECT icao, name, lat, lon FROM Airports WHERE icao IN ({string.Join(",", parameterNames)})";
                    for (int i = 0; i < destinations.Length; i++)
                    {
                        cmd.Parameters.AddWithValue($"@dest_{i}", destinations[i].Trim());
                    }

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string description = reader["icao"].ToString().Trim() + " - " + reader["name"].ToString().Trim();

                        double latitude;
                        double longitude;

                        if (double.TryParse(reader["lat"].ToString().Trim().Replace(',', '.'), out latitude) &&
                            double.TryParse(reader["lon"].ToString().Trim().Replace(',', '.'), out longitude))
                        {
                            Tuple<double, double, string> dataTuple = Tuple.Create(latitude, longitude, description);
                            destinationsTuple.Add(dataTuple);
                        }
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception chyba)
                {
                    MessageBox.Show(chyba.ToString(), "Error:");
                    connection.Close();
                }
            }
            return destinationsTuple;
        }

        private void gMapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            CustomMarker clickedMarker = item as CustomMarker;
            if (clickedMarker != null)
            {
                markerDescription = clickedMarker.ToolTipText;
                string[] descriptionParts = markerDescription.Split('-');

                if (descriptionParts[0].Trim() != lblHeadquarter.Text)
                {
                    lblDestination.Text = descriptionParts[0].Trim();
                }
                else
                {
                    MessageBox.Show("You cannot generate flight to your departure!", "Notification:");
                }
            }
        }
    }
}
