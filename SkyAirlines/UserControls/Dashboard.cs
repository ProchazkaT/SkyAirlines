using FSUIPC;
using GMap.NET;
using GMap.NET.MapProviders;
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

namespace SkyAirlines
{
    public partial class Dashboard : UserControl
    {
        GetPilotSQLData pilotSQLData = new GetPilotSQLData();

        public Dashboard()
        {
            InitializeComponent();

            lblFlights.Text = pilotSQLData.GetPilotFlights().ToString();
            lblFlightHours.Text = pilotSQLData.GetPilotFlightHours().ToString() + " hours";
            lblLandingRate.Text = pilotSQLData.GetPilotAverageLandingRate().ToString()  + " FPM";
            progressBar.Value = pilotSQLData.GetPilotXP();
            lblXP.Text = "XP" + pilotSQLData.GetPilotXP().ToString() + " / 1000";

            InitializeMap();
        }

        private void InitializeMap()
        {
            gMapControl.MapProvider = GMapProviders.GoogleMap;
            gMapControl.ShowCenter = false;
            gMapControl.MinZoom = 0;
            gMapControl.MaxZoom = 24;
            gMapControl.Zoom = 4;
            gMapControl.Position = new PointLatLng(50.14, 14.26);

            Controls.Add(gMapControl);
        }
    }
}
