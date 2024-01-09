﻿using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SkyAirlines
{
    public partial class AirlineBoss : UserControl
    {
        private SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
        private GetAirlineData getAirlineData = new GetAirlineData();
        private Panel panel;
        private string name;
        private string role;

        public AirlineBoss(Panel panel)
        {
            InitializeComponent();
            InitializeMap();

            this.panel = panel;

            sqlBuilder.DataSource = @"SkyAirlines.mssql.somee.com";
            sqlBuilder.InitialCatalog = "SkyAirlines";
            sqlBuilder.UserID = "TooM_SQLLogin_1";
            sqlBuilder.Password = "li21a3sl6v";

            lblAirlineName.Text = getAirlineData.GetAirlineName();
            lblMembers.Text = getAirlineData.GetAirlineMembers().ToString() + " / 20";
            lblMoney.Text = getAirlineData.GetAirlineMoney() + " $";
            lblFleet.Text = getAirlineData.GetAirlineFleet();
            lblHeadquarter.Text = getAirlineData.GetAirlineHeadquarter();
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

        private void AirlineBoss_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT Username, Boss FROM Pilot WHERE Airline = @Airline";
                    cmd.Parameters.AddWithValue("@Airline", GlobalData.airlineID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string name = reader["Username"].ToString().Trim();
                        string role = reader["Boss"].ToString().Trim();
                        string id = GlobalData.airlineID;

                        if (role == id)
                        {
                            MemberRow memberRow = new MemberRow(name, "CEO");
                            FlowRow.Controls.Add(memberRow);
                        }
                        else
                        {
                            MemberRow memberRow = new MemberRow(name, "Pilot");
                            FlowRow.Controls.Add(memberRow);
                        }
                    }
                    reader.Close();

                }
                catch
                {

                }
                connection.Close();
            }
        }

        private void btnKick_Click(object sender, EventArgs e)
        {
            if(tbManageUsername.Texts != "")
            {
                if(tbManageUsername.Texts != GlobalData.Username)
                {
                    using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
                    {
                        try
                        {
                            connection.Open();

                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = connection;

                            cmd.CommandText = "UPDATE Pilot SET Airline=NULL WHERE Username=@username AND Airline=@airline";
                            cmd.Parameters.AddWithValue("@username", tbManageUsername.Texts);
                            cmd.Parameters.AddWithValue("@airline", GlobalData.airlineID);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("You fired the pilot - " + tbManageUsername.Texts, "Notification:");
                        }
                        catch
                        {
                            MessageBox.Show("You must enter an exact username.", "Notification:");
                        }
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("You cannot enter your username.", "Notification:");
                }
            }
            else
            {
                MessageBox.Show("You must enter an exact username.", "Notification:");
            }
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn;
            btn = (System.Windows.Forms.Button)sender;
            btn.FlatAppearance.BorderSize = 3;
            btn.FlatAppearance.BorderColor = Color.RoyalBlue;  
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn;
            btn = (System.Windows.Forms.Button)sender;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.BorderColor = Color.FromArgb(16, 47, 82);
        }
    }
}
