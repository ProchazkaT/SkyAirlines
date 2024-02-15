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
    public partial class AircraftShowroom : UserControl
    {
        private Licences licences = new Licences();

        private string username = GlobalData.Username;

        private int imgMax = 0;
        private int imgCounter = 0;
        private string aircraftShort = "";
        private string aircraft = "";

        public AircraftShowroom(string aircraft)
        {
            InitializeComponent();
            this.aircraft = aircraft;
        }

        private void AircraftShowroom_Load(object sender, EventArgs e)
        {
            if (aircraft == "Boeing")
            {
                dataGridView.Rows.Add(7);
                imgMax = 7;

                // Images of planes
                dataGridView.Rows[0].Cells[0].Value = (Image)Properties.Resources.B717;
                dataGridView.Rows[1].Cells[0].Value = (Image)Properties.Resources.B737;
                dataGridView.Rows[2].Cells[0].Value = (Image)Properties.Resources.B747;
                dataGridView.Rows[3].Cells[0].Value = (Image)Properties.Resources.B757;
                dataGridView.Rows[4].Cells[0].Value = (Image)Properties.Resources.B767;
                dataGridView.Rows[5].Cells[0].Value = (Image)Properties.Resources.B777;
                dataGridView.Rows[6].Cells[0].Value = (Image)Properties.Resources.B787;

                // Names
                dataGridView.Rows[0].Cells[1].Value = "Boeing 717";
                dataGridView.Rows[1].Cells[1].Value = "Boeing 737";
                dataGridView.Rows[2].Cells[1].Value = "Boeing 747";
                dataGridView.Rows[3].Cells[1].Value = "Boeing 757";
                dataGridView.Rows[4].Cells[1].Value = "Boeing 767";
                dataGridView.Rows[5].Cells[1].Value = "Boeing 777";
                dataGridView.Rows[6].Cells[1].Value = "Boeing 787";

                // Speeds
                dataGridView.Rows[0].Cells[2].Value = "956 km/h";
                dataGridView.Rows[1].Cells[2].Value = "945 km/h";
                dataGridView.Rows[2].Cells[2].Value = "988 km/h";
                dataGridView.Rows[3].Cells[2].Value = "956 km/h";
                dataGridView.Rows[4].Cells[2].Value = "907 km/h";
                dataGridView.Rows[5].Cells[2].Value = "1020 km/h";
                dataGridView.Rows[6].Cells[2].Value = "954 km/h";

                // Altitudes
                dataGridView.Rows[0].Cells[3].Value = "37 000 ft";
                dataGridView.Rows[1].Cells[3].Value = "41 000 ft";
                dataGridView.Rows[2].Cells[3].Value = "45 000 ft";
                dataGridView.Rows[3].Cells[3].Value = "42 000 ft";
                dataGridView.Rows[4].Cells[3].Value = "43 000 ft";
                dataGridView.Rows[5].Cells[3].Value = "43 000 ft";
                dataGridView.Rows[6].Cells[3].Value = "43 000 ft";

                // Passengers
                dataGridView.Rows[0].Cells[4].Value = "106";
                dataGridView.Rows[1].Cells[4].Value = "230";
                dataGridView.Rows[2].Cells[4].Value = "524";
                dataGridView.Rows[3].Cells[4].Value = "295";
                dataGridView.Rows[4].Cells[4].Value = "375";
                dataGridView.Rows[5].Cells[4].Value = "550";
                dataGridView.Rows[6].Cells[4].Value = "330";

                // Price
                dataGridView.Rows[0].Cells[5].Value = "1500";
                dataGridView.Rows[1].Cells[5].Value = "2500";
                dataGridView.Rows[2].Cells[5].Value = "5000";
                dataGridView.Rows[3].Cells[5].Value = "3000";
                dataGridView.Rows[4].Cells[5].Value = "3000";
                dataGridView.Rows[5].Cells[5].Value = "4000";
                dataGridView.Rows[6].Cells[5].Value = "4000";

                // Aircraft short
                dataGridView.Rows[0].Cells[6].Value = "B717";
                dataGridView.Rows[1].Cells[6].Value = "B737";
                dataGridView.Rows[2].Cells[6].Value = "B747";
                dataGridView.Rows[3].Cells[6].Value = "B757";
                dataGridView.Rows[4].Cells[6].Value = "B767";
                dataGridView.Rows[5].Cells[6].Value = "B777";
                dataGridView.Rows[6].Cells[6].Value = "B787";

                // Set first
                pbAircraftImage.Image = (Image)dataGridView.Rows[0].Cells[0].Value;
                lblName.Text = dataGridView.Rows[0].Cells[1].Value.ToString();
                lblSpeed.Text = dataGridView.Rows[0].Cells[2].Value.ToString();
                lblAltitude.Text = dataGridView.Rows[0].Cells[3].Value.ToString();
                lblPassengers.Text = dataGridView.Rows[0].Cells[4].Value.ToString();
                lblPrice.Text = dataGridView.Rows[0].Cells[5].Value.ToString();
                aircraftShort = dataGridView.Rows[0].Cells[6].Value.ToString();
                btnBack.Hide();
                btnBack.Enabled = false;
            }

            if (aircraft == "Airbus")
            {
                dataGridView.Rows.Add(7);
                imgMax = 7;

                // Images of planes
                dataGridView.Rows[0].Cells[0].Value = (Image)Properties.Resources.A220;
                dataGridView.Rows[1].Cells[0].Value = (Image)Properties.Resources.A310;
                dataGridView.Rows[2].Cells[0].Value = (Image)Properties.Resources.A320;
                dataGridView.Rows[3].Cells[0].Value = (Image)Properties.Resources.A330;
                dataGridView.Rows[4].Cells[0].Value = (Image)Properties.Resources.A340;
                dataGridView.Rows[5].Cells[0].Value = (Image)Properties.Resources.A350;
                dataGridView.Rows[6].Cells[0].Value = (Image)Properties.Resources.A380;

                // Names
                dataGridView.Rows[0].Cells[1].Value = "Airbus A220";
                dataGridView.Rows[1].Cells[1].Value = "Airbus A310";
                dataGridView.Rows[2].Cells[1].Value = "Airbus A320";
                dataGridView.Rows[3].Cells[1].Value = "Airbus A330";
                dataGridView.Rows[4].Cells[1].Value = "Airbus A340";
                dataGridView.Rows[5].Cells[1].Value = "Airbus A350";
                dataGridView.Rows[6].Cells[1].Value = "Airbus A380";

                // Speeds
                dataGridView.Rows[0].Cells[2].Value = "870 km/h";
                dataGridView.Rows[1].Cells[2].Value = "950 km/h";
                dataGridView.Rows[2].Cells[2].Value = "890 km/h";
                dataGridView.Rows[3].Cells[2].Value = "913 km/h";
                dataGridView.Rows[4].Cells[2].Value = "913 km/h";
                dataGridView.Rows[5].Cells[2].Value = "945 km/h";
                dataGridView.Rows[6].Cells[2].Value = "945 km/h";

                // Altitudes
                dataGridView.Rows[0].Cells[3].Value = "41 000 ft";
                dataGridView.Rows[1].Cells[3].Value = "41 000 ft";
                dataGridView.Rows[2].Cells[3].Value = "39 000 ft";
                dataGridView.Rows[3].Cells[3].Value = "41 100 ft";
                dataGridView.Rows[4].Cells[3].Value = "41 450 ft";
                dataGridView.Rows[5].Cells[3].Value = "43 100 ft";
                dataGridView.Rows[6].Cells[3].Value = "43 000 ft";

                // Passengers
                dataGridView.Rows[0].Cells[4].Value = "160";
                dataGridView.Rows[1].Cells[4].Value = "240";
                dataGridView.Rows[2].Cells[4].Value = "240";
                dataGridView.Rows[3].Cells[4].Value = "406";
                dataGridView.Rows[4].Cells[4].Value = "475";
                dataGridView.Rows[5].Cells[4].Value = "440";
                dataGridView.Rows[6].Cells[4].Value = "853";

                // Price
                dataGridView.Rows[0].Cells[5].Value = "1500";
                dataGridView.Rows[1].Cells[5].Value = "1500";
                dataGridView.Rows[2].Cells[5].Value = "2500";
                dataGridView.Rows[3].Cells[5].Value = "3000";
                dataGridView.Rows[4].Cells[5].Value = "3000";
                dataGridView.Rows[5].Cells[5].Value = "4000";
                dataGridView.Rows[6].Cells[5].Value = "5000";

                // Aircraft short
                dataGridView.Rows[0].Cells[6].Value = "A220";
                dataGridView.Rows[1].Cells[6].Value = "A310";
                dataGridView.Rows[2].Cells[6].Value = "A320";
                dataGridView.Rows[3].Cells[6].Value = "A330";
                dataGridView.Rows[4].Cells[6].Value = "A340";
                dataGridView.Rows[5].Cells[6].Value = "A350";
                dataGridView.Rows[6].Cells[6].Value = "A380";

                // Set first
                pbAircraftImage.Image = (Image)dataGridView.Rows[0].Cells[0].Value;
                lblName.Text = dataGridView.Rows[0].Cells[1].Value.ToString();
                lblSpeed.Text = dataGridView.Rows[0].Cells[2].Value.ToString();
                lblAltitude.Text = dataGridView.Rows[0].Cells[3].Value.ToString();
                lblPassengers.Text = dataGridView.Rows[0].Cells[4].Value.ToString();
                lblPrice.Text = dataGridView.Rows[0].Cells[5].Value.ToString();
                aircraftShort = dataGridView.Rows[0].Cells[6].Value.ToString();
                btnBack.Hide();
                btnBack.Enabled = false;
            }

            if (aircraft == "ATR")
            {
                dataGridView.Rows.Add(1);

                // Images of planes
                dataGridView.Rows[0].Cells[0].Value = (Image)Properties.Resources.ATR;

                //Name
                dataGridView.Rows[0].Cells[1].Value = "ATR Family";

                //Speed
                dataGridView.Rows[0].Cells[2].Value = "518 km/h";

                // Altitude
                dataGridView.Rows[0].Cells[3].Value = "25 000 ft";

                // Passengers
                dataGridView.Rows[0].Cells[4].Value = "78";

                // Price
                dataGridView.Rows[0].Cells[5].Value = "1500";

                // Aircraft short
                dataGridView.Rows[0].Cells[6].Value = "ATR";

                // Set first
                pbAircraftImage.Image = (Image)dataGridView.Rows[0].Cells[0].Value;
                lblName.Text = dataGridView.Rows[0].Cells[1].Value.ToString();
                lblSpeed.Text = dataGridView.Rows[0].Cells[2].Value.ToString();
                lblAltitude.Text = dataGridView.Rows[0].Cells[3].Value.ToString();
                lblPassengers.Text = dataGridView.Rows[0].Cells[4].Value.ToString();
                lblPrice.Text = dataGridView.Rows[0].Cells[5].Value.ToString();
                aircraftShort = dataGridView.Rows[0].Cells[6].Value.ToString();
                btnBack.Hide();
                btnNext.Hide();
            }

            if (aircraft == "CRJ")
            {
                dataGridView.Rows.Add(1);

                // Images of planes
                dataGridView.Rows[0].Cells[0].Value = (Image)Properties.Resources.CRJ;

                //Name
                dataGridView.Rows[0].Cells[1].Value = "CRJ Family";

                //Speed
                dataGridView.Rows[0].Cells[2].Value = "903 km/h";

                // Altitude
                dataGridView.Rows[0].Cells[3].Value = "41 000 ft";

                // Passengers
                dataGridView.Rows[0].Cells[4].Value = "104";

                // Price
                dataGridView.Rows[0].Cells[5].Value = "2000";

                // Aircraft short
                dataGridView.Rows[0].Cells[6].Value = "CRJ";

                // Set first
                pbAircraftImage.Image = (Image)dataGridView.Rows[0].Cells[0].Value;
                lblName.Text = dataGridView.Rows[0].Cells[1].Value.ToString();
                lblSpeed.Text = dataGridView.Rows[0].Cells[2].Value.ToString();
                lblAltitude.Text = dataGridView.Rows[0].Cells[3].Value.ToString();
                lblPassengers.Text = dataGridView.Rows[0].Cells[4].Value.ToString();
                lblPrice.Text = dataGridView.Rows[0].Cells[5].Value.ToString();
                aircraftShort = dataGridView.Rows[0].Cells[6].Value.ToString();
                btnBack.Hide();
                btnNext.Hide();
            }

            if (aircraft == "Embraer")
            {
                dataGridView.Rows.Add(1);

                // Images of planes
                dataGridView.Rows[0].Cells[0].Value = (Image)Properties.Resources.Embraer;

                //Name
                dataGridView.Rows[0].Cells[1].Value = "Embraer Family";

                //Speed
                dataGridView.Rows[0].Cells[2].Value = "995 km/h";

                // Altitude
                dataGridView.Rows[0].Cells[3].Value = "41 000 ft";

                // Passengers
                dataGridView.Rows[0].Cells[4].Value = "98";

                // Price
                dataGridView.Rows[0].Cells[5].Value = "2000";

                // Aircraft short
                dataGridView.Rows[0].Cells[6].Value = "Embraer";

                // Set first
                pbAircraftImage.Image = (Image)dataGridView.Rows[0].Cells[0].Value;
                lblName.Text = dataGridView.Rows[0].Cells[1].Value.ToString();
                lblSpeed.Text = dataGridView.Rows[0].Cells[2].Value.ToString();
                lblAltitude.Text = dataGridView.Rows[0].Cells[3].Value.ToString();
                lblPassengers.Text = dataGridView.Rows[0].Cells[4].Value.ToString();
                lblPrice.Text = dataGridView.Rows[0].Cells[5].Value.ToString();
                aircraftShort = dataGridView.Rows[0].Cells[6].Value.ToString();
                btnBack.Hide();
                btnNext.Hide();
            }

            if (aircraft == "Cessna")
            {
                dataGridView.Rows.Add(1);

                // Images of planes
                dataGridView.Rows[0].Cells[0].Value = (Image)Properties.Resources.CessnaCitationJet;

                //Name
                dataGridView.Rows[0].Cells[1].Value = "Cessna Citation Jet";

                //Speed
                dataGridView.Rows[0].Cells[2].Value = "835 km/h";

                // Altitude
                dataGridView.Rows[0].Cells[3].Value = "45 000 ft";

                // Passengers
                dataGridView.Rows[0].Cells[4].Value = "10";

                // Price
                dataGridView.Rows[0].Cells[5].Value = "2000";

                // Aircraft short
                dataGridView.Rows[0].Cells[6].Value = "Cessna";

                // Set first
                pbAircraftImage.Image = (Image)dataGridView.Rows[0].Cells[0].Value;
                lblName.Text = dataGridView.Rows[0].Cells[1].Value.ToString();
                lblSpeed.Text = dataGridView.Rows[0].Cells[2].Value.ToString();
                lblAltitude.Text = dataGridView.Rows[0].Cells[3].Value.ToString();
                lblPassengers.Text = dataGridView.Rows[0].Cells[4].Value.ToString();
                lblPrice.Text = dataGridView.Rows[0].Cells[5].Value.ToString();
                aircraftShort = dataGridView.Rows[0].Cells[6].Value.ToString();
                btnBack.Hide();
                btnNext.Hide();
            }

            if (aircraft == "Beechcraft")
            {
                dataGridView.Rows.Add(1);

                // Images of planes
                dataGridView.Rows[0].Cells[0].Value = (Image)Properties.Resources.BeechcraftKingAir;

                //Name
                dataGridView.Rows[0].Cells[1].Value = "Beechcraft King Air 350i";

                //Speed
                dataGridView.Rows[0].Cells[2].Value = "575 km/h";

                // Altitude
                dataGridView.Rows[0].Cells[3].Value = "35 000 ft";

                // Passengers
                dataGridView.Rows[0].Cells[4].Value = "8";

                // Price
                dataGridView.Rows[0].Cells[5].Value = "2000";

                // Aircraft short
                dataGridView.Rows[0].Cells[6].Value = "Beechcraft";

                // Set first
                pbAircraftImage.Image = (Image)dataGridView.Rows[0].Cells[0].Value;
                lblName.Text = dataGridView.Rows[0].Cells[1].Value.ToString();
                lblSpeed.Text = dataGridView.Rows[0].Cells[2].Value.ToString();
                lblAltitude.Text = dataGridView.Rows[0].Cells[3].Value.ToString();
                lblPassengers.Text = dataGridView.Rows[0].Cells[4].Value.ToString();
                lblPrice.Text = dataGridView.Rows[0].Cells[5].Value.ToString();
                aircraftShort = dataGridView.Rows[0].Cells[6].Value.ToString();
                btnBack.Hide();
                btnNext.Hide();
            }

            if (aircraft == "MD")
            {
                dataGridView.Rows.Add(1);

                // Images of planes
                dataGridView.Rows[0].Cells[0].Value = (Image)Properties.Resources.MD11;

                //Name
                dataGridView.Rows[0].Cells[1].Value = "McDonnell Douglas Family";

                //Speed
                dataGridView.Rows[0].Cells[2].Value = "945 km/h";

                // Altitude
                dataGridView.Rows[0].Cells[3].Value = "43 000 ft";

                // Passengers
                dataGridView.Rows[0].Cells[4].Value = "410";

                // Price
                dataGridView.Rows[0].Cells[5].Value = "1500";

                // Aircraft short
                dataGridView.Rows[0].Cells[6].Value = "MD";

                // Set first
                pbAircraftImage.Image = (Image)dataGridView.Rows[0].Cells[0].Value;
                lblName.Text = dataGridView.Rows[0].Cells[1].Value.ToString();
                lblSpeed.Text = dataGridView.Rows[0].Cells[2].Value.ToString();
                lblAltitude.Text = dataGridView.Rows[0].Cells[3].Value.ToString();
                lblPassengers.Text = dataGridView.Rows[0].Cells[4].Value.ToString();
                lblPrice.Text = dataGridView.Rows[0].Cells[5].Value.ToString();
                aircraftShort = dataGridView.Rows[0].Cells[6].Value.ToString();
                btnBack.Hide();
                btnNext.Hide();
            }

            if (aircraft == "Antonov")
            {
                dataGridView.Rows.Add(1);

                // Images of planes
                dataGridView.Rows[0].Cells[0].Value = (Image)Properties.Resources.AN225;

                //Name
                dataGridView.Rows[0].Cells[1].Value = "Antonov Mrija 225";

                //Speed
                dataGridView.Rows[0].Cells[2].Value = "850 km/h";

                // Altitude
                dataGridView.Rows[0].Cells[3].Value = "36 000 ft";

                // Passengers
                dataGridView.Rows[0].Cells[4].Value = "70";

                // Price
                dataGridView.Rows[0].Cells[5].Value = "5000";

                // Aircraft short
                dataGridView.Rows[0].Cells[6].Value = "Antonov";

                // Set first
                pbAircraftImage.Image = (Image)dataGridView.Rows[0].Cells[0].Value;
                lblName.Text = dataGridView.Rows[0].Cells[1].Value.ToString();
                lblSpeed.Text = dataGridView.Rows[0].Cells[2].Value.ToString();
                lblAltitude.Text = dataGridView.Rows[0].Cells[3].Value.ToString();
                lblPassengers.Text = dataGridView.Rows[0].Cells[4].Value.ToString();
                lblPrice.Text = dataGridView.Rows[0].Cells[5].Value.ToString();
                aircraftShort = dataGridView.Rows[0].Cells[6].Value.ToString();
                btnBack.Hide();
                btnNext.Hide();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (imgCounter < imgMax - 1)
            {
                imgCounter++;
                UpdateImageAndLabels();
            }

            if (imgCounter == imgMax - 1)
            {
                btnNext.Enabled = false;
                btnNext.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (imgCounter > 0)
            {
                imgCounter--;
                UpdateImageAndLabels();
            }

            if (imgCounter == 0)
            {
                btnBack.Hide();
                btnBack.Enabled = false;
            }
        }

        private void UpdateImageAndLabels()
        {
            pbAircraftImage.Image = (Image)dataGridView.Rows[imgCounter].Cells[0].Value;
            lblName.Text = dataGridView.Rows[imgCounter].Cells[1].Value.ToString();
            lblSpeed.Text = dataGridView.Rows[imgCounter].Cells[2].Value.ToString();
            lblAltitude.Text = dataGridView.Rows[imgCounter].Cells[3].Value.ToString();
            lblPassengers.Text = dataGridView.Rows[imgCounter].Cells[4].Value.ToString();
            lblPrice.Text = dataGridView.Rows[imgCounter].Cells[5].Value.ToString();
            aircraftShort = dataGridView.Rows[imgCounter].Cells[6].Value.ToString();

            if (imgCounter < imgMax - 1)
            {
                btnNext.Enabled = true;
                btnNext.Show();
            }


            if (imgCounter > 0)
            {
                btnBack.Enabled = true;
                btnBack.Show();
            }
        }

        private void btnBuyLicence_Click(object sender, EventArgs e)
        {
            licences.BuyLicence(aircraftShort, username, int.Parse(lblPrice.Text));
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
    }
}
