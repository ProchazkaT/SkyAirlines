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
        private ConnectionToSQL connectionToSQL;
        private GetPilotSQLData pilotSQLData = new GetPilotSQLData();
        private Label lblMoney = GlobalData.lblMoney;
        private GetAirlineData airlineData = new GetAirlineData();

        public Licences()
        {
            connectionToSQL = new ConnectionToSQL();
        }

        public void BuyLicence(string aircraftShort, string usernameOfPilot, int priceOfAircraftLicence)
        {
            string licences = GetPilotLicence(GlobalData.Username);
            int money = pilotSQLData.GetPilotMoney(GlobalData.Username);

            using (SqlConnection connection = connectionToSQL.CreateConnection())
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

                            lblMoney.Text = pilotSQLData.GetPilotMoney(GlobalData.Username).ToString() + "$";

                            MessageBox.Show("You have successfully bought a licence.", "Notification:");
                            connection.Close();
                        }
                        else
                        {
                            MessageBox.Show("You do not have enough money to buy a license.", "Notification:");
                            connection.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You have already purchased this license", "Notification:");
                        connection.Close();
                    }
                    
                }
                catch (Exception ex)
                {
                    HandleError("An error occurred while purchasing the license.", ex);
                    connection.Close();
                }
            }
        }

        public void BuyLicenceAirline(string aircraftShort, string airlineId, int priceOfAircraftLicence)
        {
            string licences = airlineData.GetAirlineFleet();
            int money = int.Parse(airlineData.GetAirlineMoney());

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    if (!IsLicenceAlreadyOwnedAirline(aircraftShort))
                    {
                        if (money >= priceOfAircraftLicence)
                        {
                            money -= priceOfAircraftLicence;
                            licences += "," + aircraftShort;

                            UpdateAirlineLicencesAndMoney(cmd, licences, money, GlobalData.airlineID);

                            MessageBox.Show("You have successfully bought a airplane.", "Notification:");
                            connection.Close();
                        }
                        else
                        {
                            MessageBox.Show("You do not have enough money to buy a airplane.", "Notification:");
                            connection.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You have already purchased this airplane", "Notification:");
                        connection.Close();
                    }

                }
                catch (Exception ex)
                {
                    HandleError("An error occurred while purchasing the airplane.", ex);
                    connection.Close();
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

        private void UpdateAirlineLicencesAndMoney(SqlCommand cmd, string licences, int money, string id)
        {
            cmd.CommandText = "UPDATE Airline SET AirlineAirplanes = @fleet, AirlineMoney = @airlineMoney WHERE ID = @ID";
            cmd.Parameters.AddWithValue("@fleet", licences);
            cmd.Parameters.AddWithValue("@airlineMoney", money);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public List<string> GetPilotLicencesAsList(string Username)
        {
            string licenceString = GetPilotLicence(Username);
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

            using (SqlConnection connection = connectionToSQL.CreateConnection())
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
                    connection.Close();
                }
            }
            return false;
        }

        public bool IsLicenceAlreadyOwnedAirline(string licenceToCheck)
        {
            string licences = "";

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT AirlineAirplanes FROM Airline WHERE ID = @id";
                    cmd.Parameters.AddWithValue("@id", GlobalData.airlineID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        licences = reader["AirlineAirplanes"].ToString();
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
                    connection.Close();
                }
            }
            return false;
        }

        public string GetPilotLicence(string Username)
        {
            string licences = null;

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT Licences FROM Pilot WHERE Username = @username";
                    cmd.Parameters.AddWithValue("@username", Username);

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
