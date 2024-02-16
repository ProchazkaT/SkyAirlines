using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SkyAirlines
{
    public partial class ManageAirline : UserControl
    {
        private ConnectionToSQL connectionToSQL;
        private GetAirlineData airlineData = new GetAirlineData();
        private List<string> equipmentList = new List<string> { "Economy", "Premium Economy", "Business", "First Class" };
        private GMapOverlay markersOverlay = new GMapOverlay("AirportMarkers");
        private CustomMarker clickedMarker;
        private GMapOverlay routesOverlay = new GMapOverlay("routesOverlay");

        private int equipmentCost = 0;
        private double equipmentPercentage = 0.0;
        private int cost = 0;
        private string icaoYouWouldBuy = "";

        public ManageAirline()
        {
            InitializeComponent();
            connectionToSQL = new ConnectionToSQL();

            lblAirlineName.Text = airlineData.GetAirlineName();
            lblHeadquater.Text = airlineData.GetAirlineHeadquarter();
            lblMembers.Text = airlineData.GetAirlineMembers().ToString() + " / 20";
            lblMoney.Text = airlineData.GetAirlineMoney() + "$";
            cbFleet.DataSource = airlineData.GetAirlineFleetAsList();
            cbEquipment.DataSource = equipmentList;
            cbEquipment.SelectedIndex = int.Parse(airlineData.GetAirlineEquipment());
            pbPicture.Image = airlineData.GetAirlineLogo();
            SetPercentageForEquipment();
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

            gMapControl.Overlays.Add(routesOverlay);
            gMapControl.Overlays.Add(markersOverlay);
            SetAirportsMarkers();
        }

        private void SetPercentageForEquipment()
        {
            if (cbEquipment.SelectedIndex == 0)
            {
                lblPercentageEquipment.Text = "0%";
            }
            else if (cbEquipment.SelectedIndex == 1)
            {
                lblPercentageEquipment.Text = "+5.0%";
            }
            else if (cbEquipment.SelectedIndex == 2)
            {
                lblPercentageEquipment.Text = "+7.5%";
            }
            else if (cbEquipment.SelectedIndex == 3)
            {
                lblPercentageEquipment.Text = "+10.0%";
            }
        }

        private void SetCostForEquipment()
        {
            if (cbEquipment.SelectedIndex == 1 && cbFleet.SelectedIndex == int.Parse(airlineData.GetAirlineEquipment()))
            {
                btnBuyEquipment.Text = "Buy Equipment\n50.000$";
                equipmentCost = 50000;
                equipmentPercentage = 5.0;
            }
            else if (cbEquipment.SelectedIndex == 2 && cbFleet.SelectedIndex == int.Parse(airlineData.GetAirlineEquipment()))
            {
                btnBuyEquipment.Text = "Buy Equipment\n100.000$";
                equipmentCost = 100000;
                equipmentPercentage = 7.5;
            }
            else if (cbEquipment.SelectedIndex == 3 && cbFleet.SelectedIndex == int.Parse(airlineData.GetAirlineEquipment()))
            {
                btnBuyEquipment.Text = "Buy Equipment\n150.000$";
                equipmentCost = 150000;
                equipmentPercentage = 10.0;
            }
            else
            {
                btnBuyEquipment.Text = "Buy Equipment";
                equipmentCost = 0;
                equipmentPercentage = 0.0;
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

        private void cbEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetPercentageForEquipment();
            SetCostForEquipment();
        }

        public void SetAirportsMarkers()
        {
            List<Tuple<double, double, string>> dataFromDatabase = GetDatabaseData();
            foreach (var data in dataFromDatabase)
            {
                double latitude = data.Item1;
                double longitude = data.Item2;
                string description = data.Item3;

                CustomMarker marker = new CustomMarker(new PointLatLng(latitude, longitude), Properties.Resources.AirportMarker, description);
                markersOverlay.Markers.Add(marker);
            }

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT icao, name, lat, lon FROM Airports WHERE icao=@icao";
                    cmd.Parameters.AddWithValue("@icao", airlineData.GetAirlineHeadquarter());

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string description = "Headquarter\n" + reader["icao"].ToString().Trim() + " - " + reader["name"].ToString().Trim();
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
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The specified ICAO does not exist!\n" + ex.ToString(), "Notification:");
                }
            }
        }

        private List<Tuple<double, double, string>> GetDatabaseData()
        {
            var airportData = new List<Tuple<double, double, string>>();

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT a.icao, a.name, a.lat, a.lon FROM Airports AS a JOIN Airline AS al ON al.Destinations LIKE '%' + a.icao + '%' WHERE al.ID=@id";
                    cmd.Parameters.AddWithValue("@id", GlobalData.airlineID);

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
                            airportData.Add(dataTuple);
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
            return airportData;
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

        private void btnBuyEquipment_Click(object sender, EventArgs e)
        {
            int money = int.Parse(airlineData.GetAirlineMoney());

            if (cbFleet.SelectedIndex < int.Parse(airlineData.GetAirlineEquipment()))
            {
                if (cbFleet.SelectedIndex == int.Parse(airlineData.GetAirlineEquipment()))
                {
                    if (money >= equipmentCost)
                    {
                        using (SqlConnection connection = connectionToSQL.CreateConnection())
                        {
                            try
                            {
                                connection.Open();

                                SqlCommand cmd = new SqlCommand();
                                cmd.Connection = connection;

                                money -= equipmentCost;
                                double costPerMile = double.Parse(airlineData.GetAirlineCostPerMile()) + (1 + equipmentPercentage / 100);

                                cmd.CommandText = "UPDATE Airline SET Equipment = @airlineSalary, AirlineMoney = @airlineMoney, CostPerMile=@costPerMile WHERE ID = @id";
                                cmd.Parameters.AddWithValue("@equipment", cbEquipment.SelectedIndex);
                                cmd.Parameters.AddWithValue("@airlineMoney", money);
                                cmd.Parameters.AddWithValue("@costPerMile", costPerMile);
                                cmd.Parameters.AddWithValue("@id", GlobalData.airlineID);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("You have successfully buy the " + cbFleet.SelectedItem + " equipment.", "Notification:");

                                connection.Close();

                                cbEquipment.DataSource = equipmentList;
                                cbEquipment.SelectedIndex = int.Parse(airlineData.GetAirlineEquipment());
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred while byuing the equipment. \n" + ex.ToString(), "Error:");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("You don't have enough money to buy this equipment.", "Notification:");
                    }
                }
                else
                {
                    MessageBox.Show("You have already purchased this equipment.", "Notification:");
                }
            }
            else
            {
                MessageBox.Show("You have already purchased better equipment.", "Notification:");
            }
        }

        private void btnBuyDestination_Click(object sender, EventArgs e)
        {
            if (tbICAO.Texts != "")
            {
                if (icaoYouWouldBuy == tbICAO.Texts)
                {
                    if (int.Parse(airlineData.GetAirlineMoney()) >= cost)
                    {
                        using (SqlConnection connection = connectionToSQL.CreateConnection())
                        {
                            try
                            {
                                connection.Open();

                                SqlCommand cmd = new SqlCommand();
                                cmd.Connection = connection;

                                string destinations = airlineData.GetAirlineDestinations() + "," + tbICAO.Texts.ToUpper();
                                int money = int.Parse(airlineData.GetAirlineMoney()) - cost;

                                cmd.CommandText = "UPDATE Airline SET Destinations = @destinations, AirlineMoney=@airlineMoney WHERE ID = @id";
                                cmd.Parameters.AddWithValue("@destinations", destinations);
                                cmd.Parameters.AddWithValue("@airlineMoney", money);
                                cmd.Parameters.AddWithValue("@id", GlobalData.airlineID);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("You have successfully bought the destination.", "Notification:");
                                SetAirportsMarkers();

                                connection.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred while changing the salary. \n" + ex.ToString(), "Error:");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("The airline does not have enough money to buy this destination.", "Notification:");
                    }
                }
                else
                {
                    MessageBox.Show("You have changed your ICAO destination! You have to click on select to calculate the price!", "Notification:");
                }
            }
            else
            {
                MessageBox.Show("You must enter ICAO destinations!", "Notification:");
            }
        }

        private void btnSelectDestination_Click(object sender, EventArgs e)
        {
            PointLatLng pointLatLngHeadquarter = new PointLatLng(0, 0);
            PointLatLng pointLatLngNewDestination = new PointLatLng(0, 0);
            routesOverlay.Clear();
            markersOverlay.Clear();
            SetAirportsMarkers();

            if (tbICAO.Texts.Length == 4)
            {
                icaoYouWouldBuy = tbICAO.Texts;

                using (SqlConnection connection = connectionToSQL.CreateConnection())
                {
                    try
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;

                        cmd.CommandText = "SELECT COUNT(*) FROM Airports WHERE icao=@icao";
                        cmd.Parameters.AddWithValue("@icao", icaoYouWouldBuy);

                        int airportCount = (int)cmd.ExecuteScalar();
                        if (airportCount == 0)
                        {
                            MessageBox.Show("The specified ICAO does not exist in the database!", "Notification:");
                            return;
                        }

                        cmd.CommandText = "SELECT Destinations FROM Airline";
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string destinations = reader["Destinations"].ToString();
                            if (destinations.Contains(icaoYouWouldBuy))
                            {
                                MessageBox.Show("You already purchased this destination!", "Notification:");
                                reader.Close();
                                return;
                            }
                        }
                        reader.Close();

                        cmd.CommandText = "SELECT icao, name, lat, lon FROM Airports WHERE icao=@icao1";
                        cmd.Parameters.AddWithValue("@icao1", tbICAO.Texts);

                        SqlDataReader reader1 = cmd.ExecuteReader();
                        while (reader1.Read())
                        {
                            double latitude;
                            double longitude;

                            if (double.TryParse(reader1["lat"].ToString().Trim().Replace(',', '.'), out latitude) &&
                                double.TryParse(reader1["lon"].ToString().Trim().Replace(',', '.'), out longitude))
                            {
                                string description = reader1["icao"].ToString().Trim() + " - " + reader1["name"].ToString().Trim();

                                pointLatLngNewDestination = new PointLatLng(latitude, longitude);

                                CustomMarker marker = new CustomMarker(new PointLatLng(latitude, longitude), Properties.Resources.AirportMarker, description);
                                markersOverlay.Markers.Add(marker);
                            }
                        }
                        reader1.Close();

                        cmd.CommandText = "SELECT lat, lon FROM Airports WHERE icao=@icao2";
                        cmd.Parameters.AddWithValue("@icao2", airlineData.GetAirlineHeadquarter());

                        SqlDataReader reader2 = cmd.ExecuteReader();
                        while (reader2.Read())
                        {
                            double latitude;
                            double longitude;

                            if (double.TryParse(reader2["lat"].ToString().Trim().Replace(',', '.'), out latitude) &&
                                double.TryParse(reader2["lon"].ToString().Trim().Replace(',', '.'), out longitude))
                            {
                                pointLatLngHeadquarter = new PointLatLng(latitude, longitude);
                            }
                        }
                        reader2.Close();

                        double costDouble = CalculateDistanceNM(pointLatLngHeadquarter, pointLatLngNewDestination) * 5;
                        cost = (int)costDouble;

                        List<PointLatLng> points = new List<PointLatLng>
                        {
                            pointLatLngHeadquarter,
                            pointLatLngNewDestination
                        };

                        GMapRoute route = new GMapRoute(points, "Route");
                        route.Stroke = new Pen(Color.Purple)
                        {
                            DashStyle = DashStyle.Dash
                        };

                        routesOverlay.Routes.Add(route);

                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The specified ICAO does not exist!\n" + ex.ToString(), "Notification:");
                    }
                }
                btnBuyDestination.Enabled = true;
                btnBuyDestination.Text = "Buy destination\n" + cost + "$";
            }
            else
            {
                MessageBox.Show("You must enter ICAO with 4 letters, e.g. LKPR.", "Notification:");
            }
        }
    }
}
