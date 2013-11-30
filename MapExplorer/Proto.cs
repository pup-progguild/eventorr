using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapExplorer
{


    public class Rootobject
    {
        public Event[] events { get; set; }
    }

    public class Event
    {
        public string eventid { get; set; }
        public string eventname { get; set; }
        public string lat { get; set; }
        public string _long { get; set; }
        public object imageloc { get; set; }
        public string eventdate { get; set; }
    }


}
