﻿using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using SkyAirlines.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SkyAirlines
{
    public partial class CreateOwnAirline : UserControl
    {
        private SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
        private GMapOverlay markersOverlay;
        private CustomMarker clickedMarker;

        private Panel panel;

        private string markerDescription = "";

        private GetPilotSQLData pilot = new GetPilotSQLData();
        private Licences licences = new Licences();

        public CreateOwnAirline(Panel panel)
        {
            sqlBuilder.DataSource = @"SkyAirlines.mssql.somee.com";
            sqlBuilder.InitialCatalog = "SkyAirlines";
            sqlBuilder.UserID = "TooM_SQLLogin_1";
            sqlBuilder.Password = "li21a3sl6v";

            InitializeComponent();
            InitializeMap();

            this.panel = panel;
            cbFleet.DataSource = licences.GetPilotLicencesAsList();
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
            gMapControl.OnMarkerClick += new MarkerClick(gMapControl_OnMarkerClick);
        }

        private void btnCreateOwnAirline_Click(object sender, EventArgs e)
        {
            if (AllFieldsSelected())
            {
                string airlineName = tbName.Texts;

                if (!IsAirlineNameUnique(airlineName))
                {
                    MessageBox.Show("This airline name already exists. Please choose a different name.", "Notification:");
                    return;
                }

                CreateAirline();
            }
            else
            {
                MessageBox.Show("Please fill in all the required information.", "Notification:");
            }
        }

        private bool AllFieldsSelected()
        {
            if (!string.IsNullOrWhiteSpace(tbName.Texts) &&
                cbFleet.SelectedItem != null &&
                !string.IsNullOrWhiteSpace(lblHeadquater.Text))
            {
                return true;
            }

            return false;
        }

        public bool IsAirlineNameUnique(string airlineName)
        {
            bool isUnique = true;

            try
            {
                using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT COUNT(*) FROM Airline WHERE Name LIKE @name";
                    cmd.Parameters.AddWithValue("@name", airlineName);

                    int existingRecords = (int)cmd.ExecuteScalar();

                    if (existingRecords > 0)
                    {
                        isUnique = false;
                    }

                    connection.Close();
                }
            }
            catch (Exception)
            {
                isUnique = false;
            }

            return isUnique;
        }


        public void CreateAirline()
        {
            int money = pilot.GetPilotMoney();
            string airlineName = tbName.Texts;

            if (AllFieldsSelected())
            {
                using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
                {
                    try
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;

                        if (money >= 5000)
                        {
                            money -= 5000;

                            cmd.CommandText = "UPDATE Pilot SET Money = @money WHERE Username = @username";
                            cmd.Parameters.AddWithValue("@money", money);
                            cmd.Parameters.AddWithValue("@username", GlobalData.Username);
                            cmd.ExecuteNonQuery();

                            GlobalData.lblMoney.Text = pilot.GetPilotMoney().ToString() + "$";

                            cmd.CommandText = "INSERT INTO Airline(Logo, Name, Boss, AirlineMoney, AirlineAirplanes, Headquarter) OUTPUT INSERTED.ID VALUES (@logo, @name, @boss, @airlineMoney, @airlineAirplanes, @headquater)";
                            cmd.Parameters.AddWithValue("@logo", LogoToByteArray(pbLogo));
                            cmd.Parameters.AddWithValue("@name", tbName.Texts);
                            cmd.Parameters.AddWithValue("@boss", pilot.GetPilotID());
                            cmd.Parameters.AddWithValue("@airlineMoney", 5000);
                            cmd.Parameters.AddWithValue("@airlineAirplanes", cbFleet.Text);
                            cmd.Parameters.AddWithValue("@headquater", lblHeadquater.Text);

                            // Získání nového ID letecké společnosti
                            int airlineID = (int)cmd.ExecuteScalar();

                            MessageBox.Show("You have successfully created your own airline.", "Notification:");

                            // Aktualizace tabulky Pilot s novým ID letecké společnosti
                            cmd.CommandText = "UPDATE Pilot SET Airline = @airline WHERE Username = @username";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@airline", airlineID);
                            cmd.Parameters.AddWithValue("@username", GlobalData.Username);
                            cmd.ExecuteNonQuery();

                            ChangeMainPanel(new Airline(panel)); //--- Tu to změnit na ten UserControl
                        }
                        else
                            MessageBox.Show("You do not have enough money to create an airline.", "Notification:");

                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while creating the airline.\n" + ex.ToString(), "Error:");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the required information.", "Notification:");
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

        private void gMapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            CustomMarker clickedMarker = item as CustomMarker;
            if (clickedMarker != null)
            {
                markerDescription = clickedMarker.ToolTipText;
                string[] descriptionParts = markerDescription.Split('-');
                lblHeadquater.Text = descriptionParts[0].Trim();
            }
        }

        private void btnOpenLogoImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg; *.png; *.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;

                FileInfo fileInfo = new FileInfo(selectedImagePath);
                long fileSizeInBytes = fileInfo.Length;

                long fileSizeInKB = fileSizeInBytes / 1024;

                if (fileSizeInKB > 2048)
                {
                    MessageBox.Show("Please select an image file with a size smaller than 2 MB.", "Notification:");
                }
                else
                {
                    pbLogo.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private byte[] LogoToByteArray(PictureBox pictureBox)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public void ChangeMainPanel(UserControl userControl)
        {
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Anchor = AnchorStyles.None;
        }
    }
}
