using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkyAirlines.Classes
{
    internal class Licences
    {
        SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
        GetPilotSQLData pilotSQLData = new GetPilotSQLData();
        private Label lblMoney = GlobalData.lblMoney;

        public Licences()
        {
            sqlBuilder.DataSource = @"SkyAirlines.mssql.somee.com";
            sqlBuilder.InitialCatalog = "SkyAirlines";
            sqlBuilder.UserID = "TooM_SQLLogin_1";
            sqlBuilder.Password = "li21a3sl6v";
        }

        public void BuyLicence(string aircraftShort, string usernameOfPilot, int priceOfAircraftLicence)
        {
            string licences = GetPilotLicence();
            int money = pilotSQLData.GetPilotMoney();

            using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    if (!IsLicenceAlreadyOwned(aircraftShort))
                    {
                        if (money >= priceOfAircraftLicence)
                        {
                            money -= priceOfAircraftLicence;
                            licences += aircraftShort + ",";

                            UpdatePilotLicencesAndMoney(cmd, licences, money, usernameOfPilot);

                            lblMoney.Text = pilotSQLData.GetPilotMoney().ToString() + "$";
                        }
                        else
                            MessageBox.Show("You do not have enough money to buy a license.", "Notification:");
                    }
                    else
                        MessageBox.Show("You have already purchased this license", "Notification:");
                }
                catch (Exception ex)
                {
                    HandleError("An error occurred while purchasing the license.", ex);
                }
            }
        }

        private void UpdatePilotLicencesAndMoney(SqlCommand cmd, string licences, int money, string usernameOfPilot)
        {
            cmd.CommandText = "UPDATE Pilot SET Licences = @licences, Money = @money WHERE Username = @username";
            cmd.Parameters.AddWithValue("@licences", licences);
            cmd.Parameters.AddWithValue("@money", money);
            cmd.Parameters.AddWithValue("@username", usernameOfPilot);
            cmd.ExecuteNonQuery();
        }

        public List<string> GetPilotLicencesAsList()
        {
            string licenceString = GetPilotLicence();
            List<string> licences = new List<string>();

            if (!string.IsNullOrEmpty(licenceString))
            {
                string[] licenceArray = licenceString.Split(',');

                foreach (string licence in licenceArray)
                {
                    licences.Add(licence.Trim());
                }
            }

            return licences;
        }

        public bool IsLicenceAlreadyOwned(string licenceToCheck)
        {
            string licences = "";

            using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT Licences FROM Pilot WHERE Username = @username";
                    cmd.Parameters.AddWithValue("@username", GlobalData.Username);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        licences = reader["Licences"].ToString();
                    }

                    List<string> currentLicenceList = licences.Split(',').ToList();

                    if (currentLicenceList.Contains(licenceToCheck))
                    {
                        reader.Close();
                        connection.Close();
                        return true;
                    }

                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while checking for licence ownership.\n" + ex.ToString(), "Error:");
                }
            }
            return false;
        }

        public string GetPilotLicence()
        {
            string licences = null;

            using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT Licences FROM Pilot WHERE Username = @username";
                    cmd.Parameters.AddWithValue("@username", GlobalData.Username);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        licences = reader["Licences"].ToString().Trim();
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
            return licences;
        }

        private void HandleError(string message, Exception ex)
        {
            MessageBox.Show(message + "\n" + ex.ToString(), "Error:");
        }
    }
}
