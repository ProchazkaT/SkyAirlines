using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SkyAirlines
{
    public partial class ChangeAirlineName : Form
    {
        private ConnectionToSQL connectionToSQL;
        private GetAirlineData airlineData = new GetAirlineData();
        private Label label = new Label();
        private Label labelMoney = new Label();

        private string airlineName;

        public ChangeAirlineName(Label AirlineNameLabel, string AirlineName, Label Money)
        {
            InitializeComponent();

            label = AirlineNameLabel;
            airlineName = AirlineName;
            labelMoney = Money;

            connectionToSQL = new ConnectionToSQL();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnChangeAirlineName_Click(object sender, EventArgs e)
        {
            int money = int.Parse(airlineData.GetAirlineMoney());
            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    if (tbAirlineName.Text != "")
                    {
                        if (tbAirlineName.Text != airlineName)
                        {
                            if (money >= 5000)
                            {
                                connection.Open();

                                SqlCommand cmd = new SqlCommand();
                                cmd.Connection = connection;

                                money -= 5000;

                                cmd.CommandText = "UPDATE Airline SET Name = @name, AirlineMoney = @airlineMoney WHERE ID = @id";
                                cmd.Parameters.AddWithValue("@name", tbAirlineName.Text);
                                cmd.Parameters.AddWithValue("@airlineMoney", money);
                                cmd.Parameters.AddWithValue("@id", GlobalData.airlineID);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("You have successfully changed the username to '" + tbAirlineName.Text + "'.", "Notification:");

                                label.Text = tbAirlineName.Text;
                                labelMoney.Text = airlineData.GetAirlineMoney() + "$";
                                this.Hide();
                                connection.Close();
                            }
                            else
                            {
                                MessageBox.Show("The airline does not have enough money to change airline name.", "Notification:");
                                this.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("You cannot enter the same airline name!", "Notification:");
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You must enter the necessary information!", "Notification");
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while changing the airline name. \n" + ex.ToString(), "Error:");
                }
            }
        }
    }
}
