using SkyAirlines.Forms;
using System;
using System.Data.SqlClient;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SkyAirlines.Classes
{
    internal class Register
    {
        private SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();

        public Register()
        {
            sqlBuilder.DataSource = @"SkyAirlines.mssql.somee.com";
            sqlBuilder.InitialCatalog = "SkyAirlines";
            sqlBuilder.UserID = "TooM_SQLLogin_1";
            sqlBuilder.Password = "li21a3sl6v";
        }

        public void RegisterPilot(string username, string password, string email)
        {
            using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();

                    WebClient webClient = new WebClient();
                    byte[] imageData = webClient.DownloadData("https://img.tpx.cz/uploads/User%20Male1.png");

                    string controlUsername = "SELECT COUNT(*) FROM Pilot WHERE Username = @username";
                    SqlCommand controlUsernameCMD = new SqlCommand(controlUsername, connection);
                    controlUsernameCMD.Parameters.AddWithValue("@username", username);
                    int existUsername = (int)controlUsernameCMD.ExecuteScalar();

                    if (existUsername == 0)
                    {
                        if (IsValidEmail(email))
                        {
                            string controlEmail = "SELECT COUNT(*) FROM Pilot WHERE Email = @email";
                            SqlCommand controlCMD = new SqlCommand(controlEmail, connection);
                            controlCMD.Parameters.AddWithValue("@email", email);
                            int existEmail = (int)controlCMD.ExecuteScalar();

                            if (existEmail == 0)
                            {
                                SqlCommand cmd = new SqlCommand();
                                cmd.Connection = connection;

                                string cmdString = "INSERT INTO Pilot(Username, Password, Email, Money, Picture, XP, Flights, FLightHours, AverageLandingRate) VALUES (@username, @password, @email, @money, @picture, @xp, @flights, @flighthours, @averagelandingrate)";

                                string result = "";
                                using (SHA256 hashovac = SHA256.Create())
                                {
                                    byte[] vypocitano = hashovac.ComputeHash(Encoding.UTF8.GetBytes(password + "TajnyOsolenyPridavek"));
                                    result = BitConverter.ToString(vypocitano);
                                    result = result.Replace("-", "").ToLower();
                                }

                                cmd.Parameters.AddWithValue("@username", username);
                                cmd.Parameters.AddWithValue("@password", result);
                                cmd.Parameters.AddWithValue("@email", email);
                                cmd.Parameters.AddWithValue("@money", 5000);
                                cmd.Parameters.AddWithValue("@picture", imageData);
                                cmd.Parameters.AddWithValue("@xp", 0);
                                cmd.Parameters.AddWithValue("@flights", 0);
                                cmd.Parameters.AddWithValue("@flighthours", 0);
                                cmd.Parameters.AddWithValue("@averagelandingrate", 0);
                                cmd.CommandText = cmdString;
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Successfully registered!", "Information:");
                                LogInForm form = new LogInForm();
                                form.Show();
                                connection.Close();
                            }
                            else
                            {
                                MessageBox.Show("Email is already registered!", "Error:");
                                RegisterForm form = new RegisterForm();
                                form.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid email format!", "Error:");
                            RegisterForm form = new RegisterForm();
                            form.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username is already taken!", "Error:");
                        RegisterForm form = new RegisterForm();
                        form.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred during registration.\n" + ex.ToString(), "Error:");
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return Regex.IsMatch(email, pattern);
        }
    }
}