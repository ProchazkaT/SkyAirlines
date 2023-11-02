using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Drawing;

public class AircraftMarker : GMapMarker
{
    private Bitmap airplaneBitmap;

    public AircraftMarker(PointLatLng pos, Bitmap image) : base(pos)
    {
        airplaneBitmap = new Bitmap(image);
        Size = new Size(airplaneBitmap.Width, airplaneBitmap.Height);
        Offset = new Point(-Size.Width / 2, -Size.Height / 2);
    }

    public override void OnRender(Graphics g)
    {
        g.DrawImageUnscaled(airplaneBitmap, LocalPosition.X, LocalPosition.Y);
    }
}
