using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Drawing;

public class CustomMarker : GMapMarker
{
    private Bitmap airportBitmap;
    private string tooltipText;
    public float Bearing { get; set; }

    public CustomMarker(PointLatLng pos, Bitmap image, string tooltip) : base(pos)
    {
        airportBitmap = new Bitmap(image);
        Size = new Size(airportBitmap.Width, airportBitmap.Height);
        Offset = new Point(-Size.Width / 2, -Size.Height / 2);
        tooltipText = tooltip;
        ToolTipText = tooltipText;
    }
}
