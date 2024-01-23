using SkyAirlines.Classes;
using SkyAirlines.UserControls;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Documents;
using System.Windows.Forms;

namespace SkyAirlines
{
    public partial class Main : Form
    {
        private GetPilotSQLData sqlData = new GetPilotSQLData();
        private SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
        private GetAirlineData getAirlineData = new GetAirlineData();
        private GetPilotSQLData getPilotData = new GetPilotSQLData();

        public Main()
        {
            InitializeComponent();

            sqlBuilder.DataSource = @"SkyAirlines.mssql.somee.com";
            sqlBuilder.InitialCatalog = "SkyAirlines";
            sqlBuilder.UserID = "TooM_SQLLogin_1";
            sqlBuilder.Password = "li21a3sl6v";

            GlobalData.lblMoney = lblMoney;
            GlobalData.airlineID = getAirlineData.GetAirlineID(lblUsername.Text);
            GlobalData.Departure = getPilotData.GetPilotDeparture();
            GlobalData.Arrival = getPilotData.GetPilotArrival();
            GlobalData.AirplaneForFlight = getPilotData.GetPilotAirplaneForFlight();
            GlobalData.isFlown = false;

            lblUsername.Text = GlobalData.Username;
            lblMoney.Text = sqlData.GetPilotMoney() + "$";
            pbPicture.Image = sqlData.GetPilotPicture();

            SetActiveButton(btnDashboard);
            ChangeMainPanel(new Dashboard());

            if (!IsAirlineNull())
            {
                btnChat.Enabled = true;
                btnChat.Visible = true;

                btnLeaveAirline.Enabled = true;
                btnLeaveAirline.Visible = true;
            }

            GlobalData.btnChat = btnChat;
            GlobalData.btnLeaveAirline = btnLeaveAirline;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SetActiveButton((System.Windows.Forms.Button)sender);
            ChangeMainPanel(new Dashboard());
        }

        private void btnLicences_Click(object sender, EventArgs e)
        {
            SetActiveButton((System.Windows.Forms.Button)sender);
            ChangeMainPanel(new AircraftLicences(panelMain));
        }
        private void btnAirline_Click(object sender, EventArgs e)
        {
            SetActiveButton((System.Windows.Forms.Button)sender);
            if (IsAirlineNull())
            {
                ChangeMainPanel(new Airlines(panelMain));
            }
            else
            {
                if (sqlData.IsPilotAirlineBoss())
                    ChangeMainPanel(new AirlineBoss(panelMain));
                else
                    ChangeMainPanel(new AirlinePilot(panelMain));
            }
        }

        private void btnFlight_Click(object sender, EventArgs e)
        {
            SetActiveButton((System.Windows.Forms.Button)sender);
            ChangeMainPanel(new FlightTracking(panelMain));
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("INOP", "Notification:");
        }

        private void btnLeaveAirline_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT Boss FROM Pilot WHERE Username=@usernameBoss";
                    cmd.Parameters.AddWithValue("@usernameBoss", GlobalData.Username);
                    object isBoss = cmd.ExecuteScalar();

                    cmd.CommandText = "SELECT COUNT(*) FROM Pilot WHERE Airline = @Airline";
                    cmd.Parameters.AddWithValue("@Airline", GlobalData.airlineID);
                    int memberCount = (int)cmd.ExecuteScalar();

                    if (isBoss != null && isBoss != DBNull.Value)
                    {
                        if (memberCount == 1)
                        {
                            cmd.CommandText = "UPDATE Pilot SET Boss=NULL, Airline=NULL WHERE Username=@username1";
                            cmd.Parameters.AddWithValue("@username1", GlobalData.Username);
                            cmd.ExecuteNonQuery();

                            cmd.CommandText = "DELETE FROM Airline WHERE ID=@airlineValueDelete1";
                            cmd.Parameters.AddWithValue("@airlineValueDelete1", GlobalData.airlineID);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            cmd.CommandText = "UPDATE Pilot SET Boss=NULL, Airline=NULL WHERE Username=@username2";
                            cmd.Parameters.AddWithValue("@username2", GlobalData.Username);
                            cmd.ExecuteNonQuery();

                            cmd.CommandText = "SELECT TOP 1 ID FROM Pilot WHERE Airline=@airlineValue AND Username != @username3 ORDER BY NEWID()";
                            cmd.Parameters.AddWithValue("@airlineValue", GlobalData.airlineID);
                            cmd.Parameters.AddWithValue("@username3", GlobalData.Username);
                            int newBossID = (int)cmd.ExecuteScalar();

                            cmd.CommandText = "UPDATE Pilot SET Boss=@bossValue WHERE ID=@newBossID";
                            cmd.Parameters.AddWithValue("@bossValue", GlobalData.airlineID);
                            cmd.Parameters.AddWithValue("@newBossID", newBossID);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        cmd.CommandText = "UPDATE Pilot SET Airline=NULL WHERE Username = @usernameDelete";
                        cmd.Parameters.AddWithValue("@usernameDelete", GlobalData.Username);
                        cmd.ExecuteNonQuery();
                    }

                    cmd.CommandText = "SELECT COUNT(*) FROM Pilot WHERE Airline = @Airline2";
                    cmd.Parameters.AddWithValue("@Airline2", GlobalData.airlineID);
                    int memberCountAfter = (int)cmd.ExecuteScalar();

                    if (memberCountAfter == 0)
                    {
                        cmd.CommandText = "DELETE FROM Airline WHERE ID=@airlineValueDelete";
                        cmd.Parameters.AddWithValue("@airlineValueDelete", GlobalData.airlineID);
                        cmd.ExecuteNonQuery();
                    }

                    cmd.CommandText = "UPDATE Pilot SET Departure=NULL, Arrival=NULL, AirplaneForFlight=NULL WHERE Username=@usernameDepArr";
                    cmd.Parameters.AddWithValue("@usernameDepArr", GlobalData.Username);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "UPDATE Pilot SET Salary=NULL WHERE Username=@usernameSalary";
                    cmd.Parameters.AddWithValue("@usernameSalary", GlobalData.Username);
                    cmd.ExecuteNonQuery();

                    GlobalData.airlineID = DBNull.Value.ToString();
                    MessageBox.Show("You have successfully left the airline.", "Notification:");

                    btnChat.Enabled = false;
                    btnChat.Visible = false;
                    btnLeaveAirline.Enabled = false;
                    btnLeaveAirline.Visible = false;
                    ChangeMainPanel(new Airlines(panelMain));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Forms.LogInForm logInForm = new Forms.LogInForm();
            logInForm.Show();
            this.Hide();
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

        private void SetActiveButton(System.Windows.Forms.Button btn)
        {
            foreach (Control control in panelMenu.Controls)
            {
                if (control is System.Windows.Forms.Button button)
                {
                    button.BackColor = Color.FromArgb(16, 47, 82);
                }
            }

            btn.BackColor = Color.RoyalBlue;
        }

        public void ChangeMainPanel(UserControl userControl)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Anchor = AnchorStyles.None;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private bool IsAirlineNull()
        {
            bool isNull = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlBuilder.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Airline FROM Pilot WHERE Username = @username", connection);
                    cmd.Parameters.AddWithValue("@username", GlobalData.Username);

                    object result = cmd.ExecuteScalar();
                    if (result == null || result == DBNull.Value)
                    {
                        isNull = true;
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while checking the Airline status.\n" + ex.ToString(), "Error:");
            }
            return isNull;
        }
    }
}
