using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SkyAirlines
{
    public partial class CreateOwnAirline : UserControl
    {
        private SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
        private GMapOverlay markersOverlay;

        public CreateOwnAirline()
        {
            sqlBuilder.DataSource = @"SkyAirlines.mssql.somee.com";
            sqlBuilder.InitialCatalog = "SkyAirlines";
            sqlBuilder.UserID = "TooM_SQLLogin_1";
            sqlBuilder.Password = "li21a3sl6v";

            InitializeComponent();
            InitializeMap();
        }

        private void InitializeMap()
        {
            gMapControl.MapProvider = GMapProviders.GoogleMap;
            gMapControl.ShowCenter = false;
            gMapControl.MinZoom = 0;
            gMapControl.MaxZoom = 24;
            gMapControl.Zoom = 4;
            gMapControl.Position = new PointLatLng(50.14, 14.26);

            Controls.Add(gMapControl);

            SetAirportsMarkers();
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

        public void SetAirportsMarkers()
        {
            markersOverlay = new GMapOverlay("AirportMarkers");
            gMapControl.Overlays.Add(markersOverlay);

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
            var airportData = new List<Tuple<double, double, string>>();

            using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT icao, name, lat, lon FROM Airports WHERE icao IN ('LATI', 'UDYZ', 'LOWW', 'UBBB', 'UMMS', 'EBBR', 'LQSA', 'LBSF', 'LDZA', 'LCLK', 'LKPR', 'EKCH', 'EETN', 'EFHK', 'LFPG', 'UGTB', 'EDDB', 'LGAV', 'LHBP', 'BIKF', 'EIDW', 'LIRF', 'UACC', 'BKPR', 'EVRA', 'EYVI', 'ELLX', 'LWSK', 'LMML', 'LUKK', 'LFTW', 'LYPG', 'EHAM', 'ENGM', 'EPWA', 'LPPT', 'LROP', 'UUEE', 'LZIB', 'LJLJ', 'LEMD', 'ESSA', 'LSZB', 'LTAC', 'UKBB', 'EGLL', 'LYPG', 'EGPH')";

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string description = reader["icao"].ToString().Trim() + " - " + reader["name"].ToString().Trim();
                        double latitude = double.Parse(reader["lat"].ToString().Trim());
                        double longitude = double.Parse(reader["lon"].ToString().Trim());


                        Tuple<double, double, string> dataTuple = Tuple.Create(latitude, longitude, description);
                        airportData.Add(dataTuple);
                    }
                    reader.Close();

                    connection.Close();
                }
                catch (Exception chyba)
                {
                    System.Windows.Forms.MessageBox.Show(chyba.ToString(), "Error:");
                    connection.Close();
                }
            }
            return airportData;
        }
    }
}
