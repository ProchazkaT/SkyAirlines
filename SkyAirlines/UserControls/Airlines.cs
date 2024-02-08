using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SkyAirlines
{
    public partial class Airlines : UserControl
    {
        private Panel panel;
        private ConnectionToSQL connectionToSQL;

        public Airlines(Panel panel)
        {
            InitializeComponent();

            this.panel = panel;

            connectionToSQL = new ConnectionToSQL();
        }

        private void btnCreateOwnAirline_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn;
            btn = (System.Windows.Forms.Button)sender;
            btn.FlatAppearance.BorderSize = 3;
            btn.FlatAppearance.BorderColor = Color.RoyalBlue;
        }

        private void btnCreateOwnAirline_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn;
            btn = (System.Windows.Forms.Button)sender;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.BorderColor = Color.FromArgb(16, 47, 82);
        }

        private void btnCreateOwnAirline_Click(object sender, EventArgs e)
        {
            ChangeMainPanel(new CreateOwnAirline(panel));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    if (!string.IsNullOrEmpty(tbSearch.Texts))
                    {
                        cmd.CommandText = "SELECT ID, Logo, Name, Headquarter FROM Airline WHERE Name COLLATE Latin1_General_CS_AS LIKE @AirlineName COLLATE Latin1_General_CS_AS";
                        cmd.Parameters.AddWithValue("@AirlineName", tbSearch.Texts.Trim());
                    }
                    else
                    {
                        cmd.CommandText = "SELECT TOP 7 ID, Logo, Name, Headquarter FROM Airline ORDER BY NEWID()";
                    }

                    SqlDataReader reader = cmd.ExecuteReader();

                    FlowRow.Controls.Clear();

                    while (reader.Read())
                    {
                        string airlineID = reader["ID"].ToString();
                        byte[] logoBytes = (byte[])reader["Logo"];
                        Bitmap logo = ConvertBytesToBitmap(logoBytes);
                        string name = reader["Name"].ToString();
                        string headquarter = reader["Headquarter"].ToString();

                        int airline = Convert.ToInt32(airlineID);

                        int membersCount = GetAirlineMembersCount(airline);

                        double members = membersCount;
                        string resultMembers = $"{membersCount} / 20";

                        AirlineRow airlineRow = new AirlineRow(logo, name, headquarter, resultMembers, airlineID, panel);
                        FlowRow.Controls.Add(airlineRow);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving airline data.\n" + ex.ToString(), "Error:");
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        private void Airlines_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT TOP 7 ID, Logo, Name, Headquarter FROM Airline ORDER BY NEWID()";

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string airlineID = reader["ID"].ToString();
                        byte[] logoBytes = (byte[])reader["Logo"];
                        Bitmap logo = ConvertBytesToBitmap(logoBytes);
                        string name = reader["Name"].ToString();
                        string headquarter = reader["Headquarter"].ToString();

                        int airline = Convert.ToInt32(airlineID);

                        int membersCount = GetAirlineMembersCount(airline);

                        double members = membersCount;
                        string resultMembers = $"{membersCount} / 20";

                        AirlineRow airlineRow = new AirlineRow(logo, name, headquarter, resultMembers, airlineID, panel);
                        FlowRow.Controls.Add(airlineRow);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving airline data.\n" + ex.ToString(), "Error:");
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        public void ChangeMainPanel(UserControl userControl)
        {
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Anchor = AnchorStyles.None;
        }

        private int GetAirlineMembersCount(int airline)
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
                    cmd.Parameters.AddWithValue("@Airline", airline);

                    count = (int)cmd.ExecuteScalar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving airline members count.\n" + ex.ToString(), "Error:");
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }

            return count;
        }


        private Bitmap ConvertBytesToBitmap(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return new Bitmap(ms);
            }
        }
    }
}
