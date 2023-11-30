using FSUIPC;
using GMap.NET.MapProviders;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Gmap.net.Overlays;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace SkyAirlines
{
    public partial class FlightTracking : UserControl
    {
        private Panel panel = new Panel();

        private Offset<long> latitudeOffset = new Offset<long>(0x560);
        private Offset<long> longitudeOffset = new Offset<long>(0x568);
        private Offset<int> speedOffset = new Offset<int>(0x02B8);
        private Offset<int> altitudeOffset = new Offset<int>(0x3324);
        private Offset<int> iasOffset = new Offset<int>(0x02BC);
        private Offset<uint> headingOffset = new Offset<uint>(0x580);

        long latitude = 0;
        long longitude = 0;
        int speed = 0;
        int altitudeFeet = 0;
        int ias = 0;
        int headingDeg = 0;

        public FlightTracking(Panel panelMain)
        {
            InitializeComponent();
            panel = panelMain;
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

            Controls.Add(gMapControl);
        }

        private void UpdateairplanePosition(double latitude, double longitude)
        {
            gMapControl.Overlays.Clear();
            GMapOverlay airplaneOverlay = new GMapOverlay("airplaneOverlay");

            Bitmap airplaneMarkerImage = (Bitmap)Properties.Resources.AirplaneMarker;
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(latitude, longitude), RotateImg(airplaneMarkerImage, headingDeg));
            
            /*CustomMarker airplaneMarker = new CustomMarker(new PointLatLng(latitude, longitude), Properties.Resources.AirplaneMarker, "Your airplane");
            airplaneMarker.Bearing = (int)heading;*/
            airplaneOverlay.Markers.Add(marker);

            gMapControl.Overlays.Add(airplaneOverlay);

            gMapControl.Position = new PointLatLng(latitude, longitude);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                FSUIPCConnection.Process();

                latitude = latitudeOffset.Value;
                longitude = longitudeOffset.Value;
                speed = speedOffset.Value / 128;
                altitudeFeet = altitudeOffset.Value;
                int altitudeMeters = (int)(altitudeFeet * 0.3048);
                ias = iasOffset.Value / 128;
                double heading = headingOffset.Value * 360.0 / (65536.0 * 65536.0);
                headingDeg = (int)heading;

                double latitudeDeg = latitude * 90.0 / (10001750.0 * 65536.0 * 65536.0);
                double longitudeDeg = longitude * 360.0 / (65536.0 * 65536.0 * 65536.0 * 65536.0);

                lblLatitude.Text = latitudeDeg.ToString() + "°";
                lblLongitude.Text = longitudeDeg.ToString() + "°";
                lblAltitude.Text = altitudeFeet.ToString() + " ft";
                lblAltitudeMetres.Text = altitudeMeters.ToString() + " m";
                lblSpeed.Text = speed.ToString() + " kts";
                lblIAS.Text = ias.ToString() + " kts";

                UpdateairplanePosition(latitudeDeg, longitudeDeg);
            }
            catch (Exception)
            {
                lblDeparture.Text = "";
                lblArrival.Text = "";
                lblDistance.Text = "";
                lblAirplane.Text = "";
                lblStatus.Text = "Error reading data from FSUIPC.";

                gMapControl.Zoom = 4;
                gMapControl.Position = new PointLatLng(50.14, 14.26);

                FSUIPCConnection.Close();
                timer1.Stop();
            }
        }

        private void btnSubmitFlight_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.Close();
            timer1.Stop();
        }

        private void FlightTracking_Load(object sender, EventArgs e)
        {
            try
            {
                FSUIPCConnection.Open();

                if (FSUIPCConnection.IsOpen)
                {
                    lblStatus.Text = "Successfully connected to the simulator.";
                }
                else
                {
                    lblDeparture.Text = "";
                    lblArrival.Text = "";
                    lblDistance.Text = "";
                    lblAirplane.Text = "";
                    lblStatus.Text = "Not connected to FS.";

                    gMapControl.Zoom = 4;
                    gMapControl.Position = new PointLatLng(50.14, 14.26);

                    FSUIPCConnection.Close();
                    timer1.Stop();
                }

                timer1.Start();
            }
            catch (Exception)
            {
                lblDeparture.Text = "";
                lblArrival.Text = "";
                lblDistance.Text = "";
                lblAirplane.Text = "";
                lblStatus.Text = "Not connected to FS.";

                gMapControl.Zoom = 4;
                gMapControl.Position = new PointLatLng(50.14, 14.26);

                FSUIPCConnection.Close();
                timer1.Stop();
            }
        }

        private void FlightTracking_Leave(object sender, EventArgs e)
        {
            FSUIPCConnection.Close();
            timer1.Stop();
        }

        public Bitmap RotateImg(Bitmap bmpimage, float angle)
        {
            int width = bmpimage.Width;
            int height = bmpimage.Height;

            double radians = angle * Math.PI / 180;
            double cos = Math.Abs(Math.Cos(radians));
            double sin = Math.Abs(Math.Sin(radians));
            int newWidth = (int)(width * cos + height * sin);
            int newHeight = (int)(width * sin + height * cos);

            Bitmap rotatedImage = new Bitmap(newWidth, newHeight);
            rotatedImage.SetResolution(bmpimage.HorizontalResolution, bmpimage.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(newWidth / 2, newHeight / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-width / 2, -height / 2);
                g.InterpolationMode = InterpolationMode.HighQualityBilinear;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.DrawImage(bmpimage, new Point(0, 0));
            }

            return rotatedImage;
        }
    }
}