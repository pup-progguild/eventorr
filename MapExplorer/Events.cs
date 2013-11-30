using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MapExplorer
{
    public class EventList
    {
        public List<EventDetails> singleevents { get; set; }
    }

    public class EventDetails
    {
        public string singleeventid { get; set; }
        public string singleeventname { get; set; }
        public string lat { get; set; }
        public string longitude { get; set; }
        public string imageloc { get; set; }
        public string singleeventdate { get; set; }
    }
}
