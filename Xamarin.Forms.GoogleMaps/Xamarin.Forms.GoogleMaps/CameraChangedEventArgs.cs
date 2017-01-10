using System;
namespace Xamarin.Forms.GoogleMaps
{
    public class CameraChangedEventArgs : EventArgs
    {
        public Position Point { get; }
        public double Zoom { get; }
        public CameraChangedEventArgs(Position pos, double zoom)
        {
            this.Point = pos;
            this.Zoom = zoom;
        }
    }
}
