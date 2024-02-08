using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SkyAirlines.Classes
{
    internal class GetPilotSQLData
    {
        private ConnectionToSQL connectionToSQL;
        private GetAirlineData getAirlineData = new GetAirlineData();

        public GetPilotSQLData()
        {
            connectionToSQL = new ConnectionToSQL();
        }

        public int GetPilotMoney(string Username)
        {
            int money = 0;

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT Money FROM Pilot WHERE Username = @username";
                    cmd.Parameters.AddWithValue("@username", Username);

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

        public string GetPilotEmail(string Username)
        {
            string email = "";

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT Email FROM Pilot WHERE Username = @username";
                    cmd.Parameters.AddWithValue("@username", Username);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        email = reader["Email"].ToString().Trim();
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
            return email;
        }

        public string GetPilotDeparture(string Username)
        {
            string departure = "";

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT Departure FROM Pilot WHERE Username = @username";
                    cmd.Parameters.AddWithValue("@username", Username);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        departure = reader["Departure"].ToString().Trim();
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
            return departure;
        }

        public string GetPilotArrival(string Username)
        {
            string arrival = "";

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT Arrival FROM Pilot WHERE Username = @username";
                    cmd.Parameters.AddWithValue("@username", Username);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        arrival = reader["Arrival"].ToString().Trim();
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
            return arrival;
        }

        public string GetPilotAirplaneForFlight(string Username)
        {
            string airplaneForFlight = "";

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT AirplaneForFlight FROM Pilot WHERE Username = @username";
                    cmd.Parameters.AddWithValue("@username", Username);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        airplaneForFlight = reader["AirplaneForFlight"].ToString().Trim();
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
            return airplaneForFlight;
        }

        public int GetPilotID(string Username)
        {
            int id = 0;

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT ID FROM Pilot WHERE Username = @username";
                    cmd.Parameters.AddWithValue("@username", Username);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        id = int.Parse(reader["ID"].ToString().Trim());
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
            return id;
        }

        public int GetPilotXP(string Username)
        {
            int xp = 0;

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT XP FROM Pilot WHERE Username = @username";
                    cmd.Parameters.AddWithValue("@username", Username);

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

        public int GetPilotFlights(string Username)
        {
            int flights = 0;

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT Flights FROM Pilot WHERE Username = @username";
                    cmd.Parameters.AddWithValue("@username", Username);

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

        public int GetPilotRating(string Username)
        {
            int rating = 0;

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT Rating FROM Pilot WHERE Username = @username";
                    cmd.Parameters.AddWithValue("@username", Username);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        rating = int.Parse(reader["Rating"].ToString().Trim());
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
            return rating;
        }

        public string GetPilotSalary(string Username)
        {
            string salary = "";

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT Salary FROM Pilot WHERE Username = @username";
                    cmd.Parameters.AddWithValue("@username", Username);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        salary = reader["Salary"].ToString().Trim();
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
            return salary;
        }

        public int GetPilotAverageLandingRate(string Username)
        {
            int avgLandingRate = 0;

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT AverageLandingRate FROM Pilot WHERE Username = @username";
                    cmd.Parameters.AddWithValue("@username", Username);

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

        public Image GetPilotPicture(string Username)
        {
            Image img = null;

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("SELECT Picture FROM Pilot WHERE Username = @username", connection);
                    cmd.Parameters.AddWithValue("@username", Username);

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

        public bool IsPilotAirlineBoss(string Username)
        {
            string id = "";
            bool isBoss = false;

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT Boss FROM Pilot WHERE Username = @username";
                    cmd.Parameters.AddWithValue("@username", Username);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader["Boss"].ToString().Trim();
                    }
                    reader.Close();

                    connection.Close();

                    if(id == getAirlineData.GetAirlineID(Username))
                    {
                        isBoss = true;
                    }
                    else
                        isBoss = false;
                }
                catch (Exception chyba)
                {
                    MessageBox.Show(chyba.ToString(), "Error:");
                    connection.Close();
                }
            }
            return isBoss;
        }
    }
}
