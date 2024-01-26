using SkyAirlines;
using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SkyAirlines.Classes
{
    internal class Login
    {
        private SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();

        public Login()
        {
            sqlBuilder.DataSource = @"SkyAirlines.mssql.somee.com";
            sqlBuilder.InitialCatalog = "SkyAirlines";
            sqlBuilder.UserID = "TooM_SQLLogin_1";
            sqlBuilder.Password = "li21a3sl6v";
        }

        public void LogInPilot(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string result = "";
                    using (SHA512 hashovac = SHA512.Create())
                    {
                        byte[] vypocitano = hashovac.ComputeHash(Encoding.UTF8.GetBytes(password + "a7c3b1d5e6f7g8h9i0j1k2l3m4n5o6p7q8r9s0t1u2v3w4x5y6z7a8b9c0d1e2f3g4h5i6j7k8l9m0n1o2p3q4r5s6t7u8v9w0x1y2z3a4b5c6d7e8f9g0h1i2j3k4l5m6n7o8p9q0r1s2t3u4v5w6x7y8z9a"));
                        result = BitConverter.ToString(vypocitano);
                        result = result.Replace("-", "").ToLower();
                    }

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT * FROM Pilot WHERE Username = @username AND Password = @password";
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", result);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        GlobalData.Username = username;
                        Main form = new Main();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("An error occurred during login.","Error:");
                        Forms.LogInForm form = new Forms.LogInForm();
                        form.Show();
                    }

                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred during login.\n" + ex.ToString(), "Error:");
                }
            }
        }
    }
}
