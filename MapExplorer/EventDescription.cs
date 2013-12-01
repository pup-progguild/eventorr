using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace MapExplorer
{
    public class EventDescription
    {
        public GeoCoordinate geocoords { get; set; }
        public EventDetails eventDetails { get; set; }
    }

    public class PolygonDetails {
        public Polygon polygon { get; set; }
        public EventDescription eventDescription { get; set; }
    }
}
