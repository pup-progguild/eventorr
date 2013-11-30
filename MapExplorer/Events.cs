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
        public List<EventDetails> events { get; set; }
        public int success { get; set; }
    }

    public class EventDetails
    {
        public string eventid { get; set; }
        public string eventname { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string imageloc { get; set; }
        public string eventdate { get; set; }
    }
}
