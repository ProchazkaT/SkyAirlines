using GMap.NET;
using GMap.NET.MapProviders;
using SkyAirlines.Classes;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SkyAirlines
{
    public partial class ManagePilot : UserControl
    {
        private GetPilotSQLData pilotSQLData = new GetPilotSQLData();
        private SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
        private Licences licences = new Licences();
        private GetAirlineData airlineSQLData = new GetAirlineData();

        private string username = "";
        private int pilotSalary = 0;
        private int airlineSalary = 0;

        public ManagePilot(string Username)
        {
            InitializeComponent();

            username = Username;

            InitializeMap();

            sqlBuilder.DataSource = @"SkyAirlines.mssql.somee.com";
            sqlBuilder.InitialCatalog = "SkyAirlines";
            sqlBuilder.UserID = "TooM_SQLLogin_1";
            sqlBuilder.Password = "li21a3sl6v";
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

        private void ManagePilot_Load(object sender, EventArgs e)
        {
            lblAverageLandings.Text = pilotSQLData.GetPilotAverageLandingRate(username).ToString();
            lblFlights.Text = pilotSQLData.GetPilotFlights(username).ToString();
            lblRating.Text = pilotSQLData.GetPilotRating(username).ToString();
            pbPicture.Image = pilotSQLData.GetPilotPicture(username);
            lblUsername.Text = username;
            pilotSalary = (int)(double.Parse(pilotSQLData.GetPilotSalary(username)) * 100);
            nudPilotSalary.Value = pilotSalary;
            airlineSalary = 100 - pilotSalary;
            lblAirlineSalary.Text = "- " + airlineSalary + "% to airline.";
            cbAirplaneLicences.DataSource = licences.GetPilotLicencesAsList(username);
        }

        private void nudPilotSalary_ValueChanged(object sender, EventArgs e)
        {
            double newPilotSalary = (double)nudPilotSalary.Value / 100;
            double newAirlineSalary = 1 - newPilotSalary;
            lblAirlineSalary.Text = "- " + (newAirlineSalary * 100) + "% to airline.";
        }

        private void btnChangeSalary_Click(object sender, EventArgs e)
        {
            double newPilotSalary = (double)nudPilotSalary.Value / 100;
            double newAirlineSalary = 1 - newPilotSalary;

            using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "UPDATE Pilot SET Salary = @salary WHERE Username = @username";
                    cmd.Parameters.AddWithValue("@salary", newPilotSalary.ToString());
                    cmd.Parameters.AddWithValue("@username", lblUsername.Text);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "UPDATE Airline SET AirlineSalary = @airlineSalary WHERE ID = @id";
                    cmd.Parameters.AddWithValue("@airlineSalary", newAirlineSalary.ToString());
                    cmd.Parameters.AddWithValue("@id", GlobalData.airlineID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("You have successfully changed the salary.", "Notification:");

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while changing the salary. \n" + ex.ToString(), "Error:");
                }
            }
        }

        private void btnGiveBonus_Click(object sender, EventArgs e)
        {
            int moneyForPilot = pilotSQLData.GetPilotMoney(username) + int.Parse(tbBonus.Texts);
            int moneyMinusForAirline = int.Parse(airlineSQLData.GetAirlineMoney()) - int.Parse(tbBonus.Texts);

            if (int.Parse(airlineSQLData.GetAirlineMoney()) >= int.Parse(tbBonus.Texts))
            {
                if (tbBonus.Texts != "0")
                {

                    using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
                    {
                        try
                        {
                            connection.Open();

                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = connection;

                            cmd.CommandText = "UPDATE Pilot SET Money = @money WHERE Username = @username";
                            cmd.Parameters.AddWithValue("@money", moneyForPilot.ToString());
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.ExecuteNonQuery();

                            cmd.CommandText = "UPDATE Airline SET AirlineMoney = @airlineMoney WHERE ID = @id";
                            cmd.Parameters.AddWithValue("@airlineMoney", moneyMinusForAirline);
                            cmd.Parameters.AddWithValue("@id", GlobalData.airlineID);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("You have successfully given the bonus.", "Notification:");

                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while giving the salary.", "Error:");
                        }
                    }
                }
                else
                    MessageBox.Show("You cannot enter 0, enter a higher amount.", "Notification:");
            }
            else
            {
                MessageBox.Show("The airline doesn't have enough money to give the bonus.", "Notification:");
            }
        }
    }
}
