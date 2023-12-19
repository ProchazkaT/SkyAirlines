using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Drawing;

public class CustomMarker : GMapMarker
{
    private Bitmap airportBitmap;
    private string tooltipText;
    public float Bearing { get; set; }

    public event EventHandler MarkerClicked;

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
        g.DrawImageUnscaled(airportBitmap, LocalPosition.X, LocalPosition.Y);
    }

    public void PerformClick()
    {
        OnMarkerClicked(EventArgs.Empty);
    }

    protected virtual void OnMarkerClicked(EventArgs e)
    {
        MarkerClicked?.Invoke(this, e);
    }
}
