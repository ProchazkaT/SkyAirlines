using SkyAirlines.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;
using WiLBiT;

namespace SkyAirlines.UserControls
{
    public partial class AircraftLicences : UserControl
    {
        private Panel panel = new Panel();
        private Licences licences = new Licences();

        private string username = GlobalData.Username;
        private string whoIsBuying;

        public AircraftLicences(Panel panelMain, string whoIsBuying)
        {
            InitializeComponent();
            panel = panelMain;
            this.whoIsBuying = whoIsBuying;
            lblLicences.Text = licences.GetPilotLicence(GlobalData.Username);
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            WiLBiTButton btn;
            btn = (WiLBiTButton)sender;
            btn.BorderSize = 3;
            btn.BackColor = Color.FromArgb(16, 47, 82);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            WiLBiTButton btn;
            btn = (WiLBiTButton)sender;
            btn.BorderSize = 1;
            btn.BackColor = Color.FromArgb(16, 47, 82);
        }

        private void btnBoeing_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new AircraftShowroom("Boeing", whoIsBuying));
        }

        private void btnAirbus_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new AircraftShowroom("Airbus", whoIsBuying));
        }

        private void btnATR_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new AircraftShowroom("ATR", whoIsBuying));
        }

        private void btnCRJ_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new AircraftShowroom("CRJ", whoIsBuying));
        }

        private void btnEmbraer_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new AircraftShowroom("Embraer", whoIsBuying));
        }

        private void btnCessna_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new AircraftShowroom("Cessna", whoIsBuying));
        }

        private void btnBeechcraft_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new AircraftShowroom("Beechcraft", whoIsBuying));
        }

        private void btnMD_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new AircraftShowroom("MD", whoIsBuying));
        }

        private void btnAntonov_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new AircraftShowroom("Antonov", whoIsBuying));
        }
    }
}
