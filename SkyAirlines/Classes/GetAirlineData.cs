using System.Data;
using System;
using System.Data.SqlClient;
using SkyAirlines.Classes;
using System.Collections.Generic;
using System.Linq;

namespace SkyAirlines
{
    internal class GetAirlineData
    {
        private ConnectionToSQL connectionToSQL;

        public GetAirlineData()
        {
            connectionToSQL = new ConnectionToSQL();
        }

        public string GetAirlineID(string username)
        {
            string airlineID = "";
            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT Airline FROM Pilot WHERE Username=@username";
                    cmd.Parameters.AddWithValue("@username", GlobalData.Username);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        airlineID = reader["Airline"].ToString();
                    }
                    reader.Close();
                    connection.Close();
                }
                catch { }
            }
            return airlineID;
        }

        public string GetAirlineName()
        {
            string name = "";

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT Name FROM Airline WHERE ID=@id";
                    cmd.Parameters.AddWithValue("@id", GlobalData.airlineID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        name = reader["Name"].ToString();
                    }
                    reader.Close();
                    connection.Close();
                }
                catch { }
                connection.Close();
            }
            return name;
        }

        public int GetAirlineMembers()
        {
            int count = 0;

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT COUNT(*) FROM Pilot WHERE Airline = @Airline";
                    cmd.Parameters.AddWithValue("@Airline", GlobalData.airlineID);

                    count = (int)cmd.ExecuteScalar();
                    connection.Close();
                }
                catch
                {
                   
                    connection.Close();
                }
            }

            return count;
        }

        public string GetAirlineMoney()
        {
            string money = "";

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT AirlineMoney FROM Airline WHERE ID=@id";
                    cmd.Parameters.AddWithValue("@id", GlobalData.airlineID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        money = reader["AirlineMoney"].ToString();
                    }
                    reader.Close();
                    connection.Close();
                }
                catch { }
                connection.Close();
            }
            return money;
        }

        public string GetAirlineFleet()
        {
            string fleet = "";

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT AirlineAirplanes FROM Airline WHERE ID=@id";
                    cmd.Parameters.AddWithValue("@id", GlobalData.airlineID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        fleet = reader["AirlineAirplanes"].ToString();
                    }
                    reader.Close();
                    connection.Close();
                }
                catch { }
                connection.Close();
            }
            return fleet;
        }

        public string GetAirlineHeadquarter()
        {
            string headquarter = "";

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT Headquarter FROM Airline WHERE ID=@id";
                    cmd.Parameters.AddWithValue("@id", GlobalData.airlineID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        headquarter = reader["Headquarter"].ToString();
                    }
                    reader.Close();
                    connection.Close();
                }
                catch { }
                connection.Close();
            }
            return headquarter;
        }

        public string GetAirlineDestinations()
        {
            string destinatios = "";

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT Destinations FROM Airline WHERE ID=@id";
                    cmd.Parameters.AddWithValue("@id", GlobalData.airlineID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        destinatios = reader["Destinations"].ToString();
                    }
                    reader.Close();
                    connection.Close();
                }
                catch { }
                connection.Close();
            }
            return destinatios;
        }

        public string GetAirlineSalary()
        {
            string salary = "";

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT AirlineSalary FROM Airline WHERE ID=@id";
                    cmd.Parameters.AddWithValue("@id", GlobalData.airlineID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        salary = reader["AirlineSalary"].ToString();
                    }
                    reader.Close();
                    connection.Close();
                }
                catch { }
                connection.Close();
            }
            return salary;
        }

        public string GetAirlineCostPerMile()
        {
            string costPerMile = "";

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT CostPerMile FROM Airline WHERE ID=@id";
                    cmd.Parameters.AddWithValue("@id", GlobalData.airlineID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        costPerMile = reader["CostPerMile"].ToString();
                    }
                    reader.Close();
                    connection.Close();
                }
                catch { }
                connection.Close();
            }
            return costPerMile;
        }
    }
}
