using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SkyAirlines
{
    public partial class AirlinePilot : UserControl
    {
        private SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
        private GetAirlineData getAirlineData = new GetAirlineData();
        private Panel panel;
        private string name;
        private string role;

        public AirlinePilot(Panel panel)
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

        private void AirlinePilot_Load(object sender, EventArgs e)
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
    }
}
