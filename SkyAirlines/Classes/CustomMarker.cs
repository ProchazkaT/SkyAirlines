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

    public override void OnRender(Graphics g)
    {
        if (Bearing != 0)
        {
            g.TranslateTransform(LocalPosition.X, LocalPosition.Y);
            g.RotateTransform(Bearing);
            g.DrawImage(airportBitmap, new Rectangle(-Size.Width / 2, -Size.Height / 2, Size.Width, Size.Height));
            g.ResetTransform();
        }
        else
        {
            g.DrawImageUnscaled(airportBitmap, LocalPosition.X, LocalPosition.Y);
        }
    }
}
