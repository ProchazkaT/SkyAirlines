using SkyAirlines.Classes;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SkyAirlines
{
    public partial class AirlineRow : UserControl
    {
        private SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
        private GetPilotSQLData sqlData = new GetPilotSQLData();

        private Panel panel;
        private Bitmap logo;
        private string name = "";
        private string headquarter = "";
        private string members = "";
        private string airlineID = "";

        public AirlineRow(Bitmap logo, string name, string headquarter, string members, string airlineID, Panel panel)
        {
            InitializeComponent();

            this.logo = logo;
            this.name = name;
            this.headquarter = headquarter;
            this.members = members;
            this.airlineID = airlineID;
            this.panel = panel;

            sqlBuilder.DataSource = @"SkyAirlines.mssql.somee.com";
            sqlBuilder.InitialCatalog = "SkyAirlines";
            sqlBuilder.UserID = "TooM_SQLLogin_1";
            sqlBuilder.Password = "li21a3sl6v";
        }

        private void AirlineRow_Load(object sender, EventArgs e)
        {
            pbLogo.Image = logo;
            lblName.Text = name;
            lblHeadquater.Text = headquarter;
            lblMembers.Text = members;
            btnJoin.Tag = airlineID;
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            JoinAirline();
        }

        private void JoinAirline()
        {
            if (lblMembers.Text != "20 / 20")
            {
                using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
                {
                    try
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;

                        cmd.CommandText = "UPDATE Pilot SET Airline = @airline, Departure = @departure, Salary = @salary WHERE Username = @username";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@airline", airlineID);
                        cmd.Parameters.AddWithValue("@departure", lblHeadquater.Text);
                        cmd.Parameters.AddWithValue("@salary", "0.8");
                        cmd.Parameters.AddWithValue("@username", GlobalData.Username);
                        cmd.ExecuteNonQuery();

                        GlobalData.airlineID = airlineID;
                        MessageBox.Show("You have successfully joined the airline.", "Notification:");

                        GlobalData.btnChat.Visible = true;
                        GlobalData.btnChat.Enabled = true;
                        GlobalData.btnLeaveAirline.Visible = true;
                        GlobalData.btnLeaveAirline.Enabled = true;
                        GlobalData.Departure = lblHeadquater.Text;

                        if (sqlData.IsPilotAirlineBoss(GlobalData.Username))
                            ChangeMainPanel(new AirlineBoss(panel));
                        else
                            ChangeMainPanel(new AirlinePilot(panel));

                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while creating the airline.", "Error:");
                    }
                }
            }
            else
                MessageBox.Show("The airline is full.", "Notification:");
        }

        public void ChangeMainPanel(UserControl userControl)
        {
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Anchor = AnchorStyles.None;
        }
    }
}
