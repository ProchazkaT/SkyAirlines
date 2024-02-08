using SkyAirlines.Classes;
using SkyAirlines.Forms;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WiLBiT;

namespace SkyAirlines
{
    public partial class Settings : UserControl
    {
        private ConnectionToSQL connectionToSQL;
        private GetPilotSQLData pilotSQLData = new GetPilotSQLData();

        private WiLBiTRoundedPictureBox pictureBox = new WiLBiTRoundedPictureBox();
        private Label lblUsername = new Label();
        private Form formMain = new Form();

        public Settings(WiLBiTRoundedPictureBox pictureBox, Label UsernameLabel, Form FormMain)
        {
            InitializeComponent();

            connectionToSQL = new ConnectionToSQL();

            this.pictureBox = pictureBox;
            lblUsername = UsernameLabel;
            formMain = FormMain;
            InitializeCurrentInformation();
        }

        public void InitializeCurrentInformation()
        {
            tbCurrentEmail.Texts = pilotSQLData.GetPilotEmail(GlobalData.Username);
            pbPicture.Image = pilotSQLData.GetPilotPicture(GlobalData.Username);
        }

        public void ChangePicture()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg; *.png; *.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;

                FileInfo fileInfo = new FileInfo(selectedImagePath);
                long fileSizeInBytes = fileInfo.Length;

                long fileSizeInKB = fileSizeInBytes / 1024;

                if (fileSizeInKB > 2048)
                {
                    MessageBox.Show("Please select an image file with a size smaller than 2 MB.", "Notification:");
                }
                else
                {
                    pbPicture.Image = Image.FromFile(selectedImagePath);
                }

                using (SqlConnection connection = connectionToSQL.CreateConnection())
                {
                    try
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;

                        cmd.CommandText = "UPDATE Pilot SET Picture = @picture WHERE Username = @username";
                        cmd.Parameters.AddWithValue("@picture", LogoToByteArray(pbPicture));
                        cmd.Parameters.AddWithValue("@username", GlobalData.Username);
                        cmd.ExecuteNonQuery();

                        connection.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An error occurred while changing image.", "Error:");
                    }
                }
            }

            pictureBox.Image = pbPicture.Image;
            MessageBox.Show("You successfully change the picture.", "Notification:");
        }

        public void ChangeEmail()
        {
            bool passwordIsRight = false;

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    string result = "";
                    using (SHA512 hashovac = SHA512.Create())
                    {
                        byte[] vypocitano = hashovac.ComputeHash(Encoding.UTF8.GetBytes(tbConfirmationPasswordEmail.Texts + "a7c3b1d5e6f7g8h9i0j1k2l3m4n5o6p7q8r9s0t1u2v3w4x5y6z7a8b9c0d1e2f3g4h5i6j7k8l9m0n1o2p3q4r5s6t7u8v9w0x1y2z3a4b5c6d7e8f9g0h1i2j3k4l5m6n7o8p9q0r1s2t3u4v5w6x7y8z9a"));
                        result = BitConverter.ToString(vypocitano);
                        result = result.Replace("-", "").ToLower();
                    }

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT * FROM Pilot WHERE Username = @username AND Password = @password";
                    cmd.Parameters.AddWithValue("@username", GlobalData.Username);
                    cmd.Parameters.AddWithValue("@password", result);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        passwordIsRight = true;
                    }
                    else
                    {
                        passwordIsRight = false;
                        MessageBox.Show("You type wrong password.", "Notification:");
                    }

                    reader.Close();
                    connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occurred. Try it again.", "Error:");
                }
            }

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                connection.Open();

                if (passwordIsRight)
                {
                    if (IsValidEmail(tbNewEmail.Texts))
                    {
                        string controlEmail = "SELECT COUNT(*) FROM Pilot WHERE Email = @email";
                        SqlCommand controlCMD = new SqlCommand(controlEmail, connection);
                        controlCMD.Parameters.AddWithValue("@email", tbNewEmail.Texts);
                        int existEmail = (int)controlCMD.ExecuteScalar();

                        if (existEmail == 0)
                        {
                            try
                            {

                                SqlCommand cmd = new SqlCommand();
                                cmd.Connection = connection;

                                cmd.CommandText = "UPDATE Pilot SET Email = @email WHERE Username = @username";
                                cmd.Parameters.AddWithValue("@email", tbNewEmail.Texts);
                                cmd.Parameters.AddWithValue("@username", GlobalData.Username);
                                cmd.ExecuteNonQuery();


                                tbCurrentEmail.Texts = tbNewEmail.Texts;
                                tbNewEmail.Texts = "";
                                MessageBox.Show("You successfully change the email.", "Notification:");
                                connection.Close();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("An error occurred while changing image.", "Error:");
                                connection.Close();
                            }
                        }
                        else
                            MessageBox.Show("Email is already registered!", "Error:");
                    }
                    else
                        MessageBox.Show("Invalid email format!", "Notification:");
                }
                else
                    MessageBox.Show("Password is not correct!", "Error:");

                tbNewEmail.Texts = "";
                tbConfirmationPasswordEmail.Texts = "";
            }
        }

        public void ChangePassword()
        {
            bool passwordIsRight = false;

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    string result = "";

                    using (SHA512 hashovac = SHA512.Create())
                    {
                        byte[] vypocitano = hashovac.ComputeHash(Encoding.UTF8.GetBytes(tbCurrentPassword.Texts + "a7c3b1d5e6f7g8h9i0j1k2l3m4n5o6p7q8r9s0t1u2v3w4x5y6z7a8b9c0d1e2f3g4h5i6j7k8l9m0n1o2p3q4r5s6t7u8v9w0x1y2z3a4b5c6d7e8f9g0h1i2j3k4l5m6n7o8p9q0r1s2t3u4v5w6x7y8z9a"));
                        result = BitConverter.ToString(vypocitano).Replace("-", "").ToLower();
                    }

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT * FROM Pilot WHERE Username = @username AND Password = @password";
                    cmd.Parameters.AddWithValue("@username", GlobalData.Username);
                    cmd.Parameters.AddWithValue("@password", result);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        passwordIsRight = true;
                    }
                    else
                    {
                        passwordIsRight = false;
                    }

                    reader.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occurred. Try again.", "Error");
                }
                finally
                {
                    connection.Close();
                }
            }

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                connection.Open();

                if (passwordIsRight)
                {
                    if (tbNewPassword.Texts == tbNewPasswordAgain.Texts && !string.IsNullOrEmpty(tbNewPasswordAgain.Texts) && !string.IsNullOrEmpty(tbNewPassword.Texts))
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = connection;

                            string result = "";

                            using (SHA512 hashovac = SHA512.Create())
                            {
                                byte[] vypocitano = hashovac.ComputeHash(Encoding.UTF8.GetBytes(tbNewPasswordAgain.Texts + "a7c3b1d5e6f7g8h9i0j1k2l3m4n5o6p7q8r9s0t1u2v3w4x5y6z7a8b9c0d1e2f3g4h5i6j7k8l9m0n1o2p3q4r5s6t7u8v9w0x1y2z3a4b5c6d7e8f9g0h1i2j3k4l5m6n7o8p9q0r1s2t3u4v5w6x7y8z9a"));
                                result = BitConverter.ToString(vypocitano).Replace("-", "").ToLower();
                            }

                            cmd.CommandText = "UPDATE Pilot SET Password = @password WHERE Username = @username";
                            cmd.Parameters.AddWithValue("@password", result);
                            cmd.Parameters.AddWithValue("@username", GlobalData.Username);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("You have successfully changed the password.", "Notification");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("An error occurred while changing the password.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The new passwords do not match or are empty.", "Notification");
                    }
                }
                else
                {
                    MessageBox.Show("The entered password is not correct.", "Notification");
                }

                tbCurrentPassword.Texts = "";
                tbNewPassword.Texts = "";
                tbNewPasswordAgain.Texts = "";
                connection.Close();
            }
        }

        public void ChangeUsername()
        {
            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                connection.Open();

                if (!string.IsNullOrEmpty(tbNewUsername.Texts))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;

                        cmd.CommandText = "UPDATE Pilot SET Username = @usernameNew WHERE Username = @username";
                        cmd.Parameters.AddWithValue("@usernameNew", tbNewUsername.Texts);
                        cmd.Parameters.AddWithValue("@username", GlobalData.Username);
                        cmd.ExecuteNonQuery();

                        GlobalData.Username = tbNewUsername.Texts;
                        MessageBox.Show("You have successfully changed the username.", "Notification");
                        connection.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An error occurred while changing the username.", "Error");
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("The new username is empty.", "Notification");
                    connection.Close();
                }
            }

            lblUsername.Text = tbNewUsername.Texts;
            tbNewUsername.Texts = "";
        }

        private void DeleteAccount()
        {
            bool passwordIsRight = false;

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                try
                {
                    connection.Open();

                    string result = "";

                    using (SHA512 hashovac = SHA512.Create())
                    {
                        byte[] vypocitano = hashovac.ComputeHash(Encoding.UTF8.GetBytes(tbDeleteAccPassword.Texts + "a7c3b1d5e6f7g8h9i0j1k2l3m4n5o6p7q8r9s0t1u2v3w4x5y6z7a8b9c0d1e2f3g4h5i6j7k8l9m0n1o2p3q4r5s6t7u8v9w0x1y2z3a4b5c6d7e8f9g0h1i2j3k4l5m6n7o8p9q0r1s2t3u4v5w6x7y8z9a"));
                        result = BitConverter.ToString(vypocitano).Replace("-", "").ToLower();
                    }

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT * FROM Pilot WHERE Username = @username AND Password = @password";
                    cmd.Parameters.AddWithValue("@username", GlobalData.Username);
                    cmd.Parameters.AddWithValue("@password", result);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        passwordIsRight = true;
                    }
                    else
                    {
                        passwordIsRight = false;
                    }

                    reader.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occurred. Try again.", "Error");
                }
                finally
                {
                    connection.Close();
                }
            }

            using (SqlConnection connection = connectionToSQL.CreateConnection())
            {
                connection.Open();

                if (passwordIsRight)
                {
                    if (!string.IsNullOrEmpty(tbDeleteAccPassword.Texts))
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand();
                           
                            connection.Open();
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

                            cmd.CommandText = "UPDATE Pilot SET Departure=NULL, Arrival=NULL, AirplaneForFlight=NULL, Salary=NULL WHERE Username=@usernameDepArr";
                            cmd.Parameters.AddWithValue("@usernameDepArr", GlobalData.Username);
                            cmd.ExecuteNonQuery();

                            GlobalData.airlineID = DBNull.Value.ToString();

                            cmd.Connection = connection;

                            cmd.CommandText = "DELETE FROM Pilot WHERE Username=@username";
                            cmd.Parameters.AddWithValue("@username", GlobalData.Username);
                            cmd.ExecuteNonQuery();

                            LogInForm form = new LogInForm();
                            form.Show();
                            formMain.Hide();
                            connection.Close();

                            MessageBox.Show("You have successfully deleted the account.", "Notification");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("An error occurred while deleting the account.", "Error");
                            connection.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("The password textbox is empty.", "Notification");
                        connection.Close();
                    }
                }
                else
                    MessageBox.Show("The entered password is not correct.", "Notification");
            }
            tbDeleteAccPassword.Texts = "";
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,10}$";
            return Regex.IsMatch(email, pattern);
        }

        private byte[] LogoToByteArray(PictureBox pictureBox)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn;
            btn = (Button)sender;
            btn.FlatAppearance.BorderSize = 3;
            btn.FlatAppearance.BorderColor = Color.RoyalBlue;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn;
            btn = (Button)sender;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.BorderColor = Color.FromArgb(16, 47, 82);
        }

        private void btnBrowseNewImage_Click(object sender, EventArgs e)
        {
            ChangePicture();
        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            ChangeEmail();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }
        private void btnChangeUsername_Click(object sender, EventArgs e)
        {
            ChangeUsername();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DeleteAccount();
        }
    }
}
