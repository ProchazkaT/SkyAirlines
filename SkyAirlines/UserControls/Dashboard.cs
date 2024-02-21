using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using SkyAirlines.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SkyAirlines
{
    public partial class Dashboard : UserControl
    {
        private ConnectionToSQL connectionToSQL;
        private GetPilotSQLData pilotSQLData = new GetPilotSQLData();
        private GetAirlineData airlineData = new GetAirlineData();
        private GMapOverlay markersOverlay = new GMapOverlay("MarkersOverlay");

        public Dashboard()
        {
            InitializeComponent();

            connectionToSQL = new ConnectionToSQL();

            lblFlights.Text = pilotSQLData.GetPilotFlights(GlobalData.Username).ToString();
            lblRating.Text = (int.Parse(pilotSQLData.GetPilotRating(GlobalData.Username).ToString()) / pilotSQLData.GetPilotFlights(GlobalData.Username)).ToString();
            lblLandingRate.Text = (pilotSQLData.GetPilotAverageLandingRate(GlobalData.Username) / pilotSQLData.GetPilotFlights(GlobalData.Username)).ToString() + " FPM";
            progressBar.Value = pilotSQLData.GetPilotXP(GlobalData.Username);
            lblXP.Text = "XP " + pilotSQLData.GetPilotXP(GlobalData.Username).ToString() + " / 1000";

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

            gMapControl.Overlays.Add(markersOverlay);
            Controls.Add(gMapControl);
            SetDestinationsMarkers();
        }

        public void SetDestinationsMarkers()
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
        }

        private List<Tuple<double, double, string>> GetDatabaseData()
        {
            string destinationsString = pilotSQLData.GetPilotDestinations(GlobalData.Username);
            string[] destinations = destinationsString.Split(',');
            string[] parameterNames = destinations.Select((_, index) => $"@dest_{index}").ToArray();

            var destinationsTuple = new List<Tuple<double, double, string>>();

            using (SqlConnection connection = connectionToSQL.CreateConnection())
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
                catch (Exception)
                {
                    connection.Close();
                }
            }
            return destinationsTuple;
        }
    }
}
