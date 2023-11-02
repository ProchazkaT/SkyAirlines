using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SkyAirlines.Classes
{
    internal class GetPilotSQLData
    {
        SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();

        public GetPilotSQLData()
        {
            sqlBuilder.DataSource = @"SkyAirlines.mssql.somee.com";
            sqlBuilder.InitialCatalog = "SkyAirlines";
            sqlBuilder.UserID = "TooM_SQLLogin_1";
            sqlBuilder.Password = "li21a3sl6v";
        }

        public int GetPilotMoney()
        {
            int money = 0;

            using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT Money FROM Pilot WHERE Username = @username";
                    cmd.Parameters.AddWithValue("@username", GlobalData.Username);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        money = int.Parse(reader["Money"].ToString().Trim());
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
            return money;
        }

        public int GetPilotXP()
        {
            int xp = 0;

            using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT XP FROM Pilot WHERE Username = @username";
                    cmd.Parameters.AddWithValue("@username", GlobalData.Username);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        xp = int.Parse(reader["XP"].ToString().Trim());
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
            return xp;
        }

        public int GetPilotFlights()
        {
            int flights = 0;

            using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT Flights FROM Pilot WHERE Username = @username";
                    cmd.Parameters.AddWithValue("@username", GlobalData.Username);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        flights = int.Parse(reader["Flights"].ToString().Trim());
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
            return flights;
        }

        public int GetPilotFlightHours()
        {
            int hours = 0;

            using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT FlightHours FROM Pilot WHERE Username = @username";
                    cmd.Parameters.AddWithValue("@username", GlobalData.Username);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        hours = int.Parse(reader["FlightHours"].ToString().Trim());
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
            return hours;
        }

        public int GetPilotAverageLandingRate()
        {
            int avgLandingRate = 0;

            using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT AverageLandingRate FROM Pilot WHERE Username = @username";
                    cmd.Parameters.AddWithValue("@username", GlobalData.Username);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        avgLandingRate = int.Parse(reader["AverageLandingRate"].ToString().Trim());
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
            return avgLandingRate;
        }

        public Image GetPilotPicture()
        {
            Image img = null;

            using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("SELECT Picture FROM Pilot WHERE Username = @username", connection);
                    cmd.Parameters.AddWithValue("@username", GlobalData.Username);

                    byte[] imageData = (byte[])cmd.ExecuteScalar();

                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        img = Image.FromStream(ms);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving the image.\n" + ex.ToString(), "Error:");
                }
                connection.Close();
            }
            return img;
        }
    }
}
