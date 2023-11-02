using SkyAirlines.Classes;
using SkyAirlines.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SkyAirlines
{
    public partial class Main : Form
    {
        private GetPilotSQLData sqlData = new GetPilotSQLData();

        public Main()
        {
            InitializeComponent();

            GlobalData.lblMoney = lblMoney;

            lblUsername.Text = GlobalData.Username;
            lblMoney.Text = sqlData.GetPilotMoney() + "$";
            pbPicture.Image = sqlData.GetPilotPicture();

            SetActiveButton(btnDashboard);
            ChangeMainPanel(new Dashboard());
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
            SetActiveButton((Button)sender);
            ChangeMainPanel(new Dashboard());
        }

        private void btnLicences_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            ChangeMainPanel(new AircraftLicences(panel));
        }
        private void btnAirline_Click(object sender, EventArgs e)
        {

        }

        private void btnFlight_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            ChangeMainPanel(new FlightTracking(panel));
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

        private void SetActiveButton(Button btn)
        {
            foreach (Control control in panelMenu.Controls)
            {
                if (control is Button button)
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
    }
}
