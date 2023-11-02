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
        SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();

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
                    using (SHA256 hashovac = SHA256.Create())
                    {
                        byte[] vypocitano = hashovac.ComputeHash(Encoding.UTF8.GetBytes(password + "TajnyOsolenyPridavek"));
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
