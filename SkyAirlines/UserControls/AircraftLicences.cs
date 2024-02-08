using SkyAirlines.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WiLBiT;

namespace SkyAirlines.UserControls
{
    public partial class AircraftLicences : UserControl
    {
        private Panel panel = new Panel();
        private Licences licences = new Licences();

        private string username = GlobalData.Username;

        public AircraftLicences(Panel panelMain)
        {
            InitializeComponent();
            panel = panelMain;
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
            panel.Controls.Add(new AircraftShowroom("Boeing"));
        }

        private void btnAirbus_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new AircraftShowroom("Airbus"));
        }

        private void btnATR_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new AircraftShowroom("ATR"));
        }

        private void btnCRJ_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new AircraftShowroom("CRJ"));
        }

        private void btnEmbraer_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new AircraftShowroom("Embraer"));
        }

        private void btnCessna_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new AircraftShowroom("Cessna"));
        }

        private void btnBeechcraft_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new AircraftShowroom("Beechcraft"));
        }

        private void btnMD_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new AircraftShowroom("MD"));
        }

        private void btnAntonov_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new AircraftShowroom("Antonov"));
        }
    }
}
