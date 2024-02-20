using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SkyAirlines
{
    public partial class ChangeDiscordLink : Form
    {
        private ConnectionToSQL connectionToSQL;
        private GetAirlineData airlineData = new GetAirlineData();
        Label lblMoney;

        public ChangeDiscordLink(Label Money)
        {
            InitializeComponent();
            connectionToSQL = new ConnectionToSQL();
            lblMoney = Money;
        }

        private void btnChangeDiscordLink_Click(object sender, EventArgs e)
        {
            int money = int.Parse(airlineData.GetAirlineMoney());
            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    if (tbDiscordLink.Text != airlineData.GetAirlineDiscordLink())
                    {
                        if (money >= 5000)
                        {
                            connection.Open();

                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = connection;

                            money -= 5000;

                            cmd.CommandText = "UPDATE Airline SET DiscordLink = @discordLink, AirlineMoney = @airlineMoney WHERE ID = @id";
                            
                            if(tbDiscordLink.Text == "")
                                cmd.Parameters.AddWithValue("@discordLink", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@discordLink", tbDiscordLink.Text);

                            cmd.Parameters.AddWithValue("@airlineMoney", money);
                            cmd.Parameters.AddWithValue("@id", GlobalData.airlineID);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("You have successfully changed the discord link.", "Notification:");

                            lblMoney.Text = airlineData.GetAirlineMoney() + "$";
                            this.Hide();
                            connection.Close();
                        }
                        else
                        {
                            MessageBox.Show("The airline does not have enough money to change discord link.", "Notification:");
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You cannot enter the same discord link!", "Notification:");
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while changing the airline name. \n" + ex.ToString(), "Error:");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
