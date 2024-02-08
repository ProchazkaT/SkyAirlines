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
        private ConnectionToSQL connectionToSQL;

        public Register()
        {
            connectionToSQL = new ConnectionToSQL();
        }

        public void RegisterPilot(string username, string password, string email)
        {
            using (SqlConnection connection = connectionToSQL.CreateConnection())
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

                                string cmdString = "INSERT INTO Pilot(Username, Password, Email, Money, Picture, XP, Flights, Rating, AverageLandingRate) VALUES (@username, @password, @email, @money, @picture, @xp, @flights, @rating, @averagelandingrate)";

                                string result = "";
                                using (SHA512 hashovac = SHA512.Create())
                                {
                                    byte[] vypocitano = hashovac.ComputeHash(Encoding.UTF8.GetBytes(password + "a7c3b1d5e6f7g8h9i0j1k2l3m4n5o6p7q8r9s0t1u2v3w4x5y6z7a8b9c0d1e2f3g4h5i6j7k8l9m0n1o2p3q4r5s6t7u8v9w0x1y2z3a4b5c6d7e8f9g0h1i2j3k4l5m6n7o8p9q0r1s2t3u4v5w6x7y8z9a"));
                                    result = BitConverter.ToString(vypocitano);
                                    result = result.Replace("-", "").ToLower();
                                }

                                cmd.Parameters.AddWithValue("@username", username);
                                cmd.Parameters.AddWithValue("@password", result);
                                cmd.Parameters.AddWithValue("@email", email);
                                cmd.Parameters.AddWithValue("@money", 8000);
                                cmd.Parameters.AddWithValue("@picture", imageData);
                                cmd.Parameters.AddWithValue("@xp", 0);
                                cmd.Parameters.AddWithValue("@flights", 0);
                                cmd.Parameters.AddWithValue("@rating", 100);
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