using GMap.NET.MapProviders;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace SkyAirlines
{
    public partial class ManageAirline : UserControl
    {
        private GetAirlineData airlineData = new GetAirlineData();
        private List<string> equipmentList = new List<string> { "Economy", "Premium Economy", "Business" };

        public ManageAirline()
        {
            InitializeComponent();

            lblAirlineName.Text = airlineData.GetAirlineName();
            lblHeadquater.Text = airlineData.GetAirlineHeadquarter();
            lblMembers.Text = airlineData.GetAirlineMembers().ToString() + " / 20";
            lblMoney.Text = airlineData.GetAirlineMoney() + "$";
            cbFleet.DataSource = airlineData.GetAirlineFleetAsList();
            cbEquipment.DataSource = equipmentList;
            cbEquipment.SelectedIndex = int.Parse(airlineData.GetAirlineEquipment());
            pbPicture.Image = airlineData.GetAirlineLogo();
            SetPercentageForEquipment();
            InitializeMap();
        }

        private void InitializeMap()
        {
            gMapControl.MapProvider = GMapProviders.GoogleMap;
            gMapControl.ShowCenter = false;
            gMapControl.MinZoom = 0;
            gMapControl.MaxZoom = 24;
            gMapControl.Zoom = 4;
            gMapControl.CanDragMap = true;
            gMapControl.Position = new PointLatLng(50.14, 14.26);

            Controls.Add(gMapControl);
        }

        private void SetPercentageForEquipment()
        {
            if (cbEquipment.SelectedIndex == 0)
            {
                lblPercentageEquipment.Text = "+2.5%";
            }
            else if (cbEquipment.SelectedIndex == 1)
            {
                lblPercentageEquipment.Text = "+5.0%";
            }
            else if (cbEquipment.SelectedIndex == 2)
            {
                lblPercentageEquipment.Text = "+7.5%";
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

        private void cbEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetPercentageForEquipment();
        }
    }
}
