using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapExplorer
{
    class Events
    {

        public class Rootobject
        {
            public Event[] events { get; set; }
        }

        public class Event
        {
            public Summary summary { get; set; }
            public Event1 _event { get; set; }
        }

        public class Summary
        {
            public int total_items { get; set; }
            public long first_event { get; set; }
            public long last_event { get; set; }
            public Filters filters { get; set; }
            public int num_showing { get; set; }
        }

        public class Filters
        {
            public string country { get; set; }
            public string region { get; set; }
        }

        public class Event1
        {
            public string box_header_text_color { get; set; }
            public string locale { get; set; }
            public string link_color { get; set; }
            public string box_background_color { get; set; }
            public string timezone { get; set; }
            public string box_border_color { get; set; }
            public string logo { get; set; }
            public Organizer organizer { get; set; }
            public string background_color { get; set; }
            public long id { get; set; }
            public string category { get; set; }
            public string box_header_background_color { get; set; }
            public int capacity { get; set; }
            public float? num_attendee_rows { get; set; }
            public string title { get; set; }
            public string start_date { get; set; }
            public string status { get; set; }
            public string description { get; set; }
            public string end_date { get; set; }
            public string tags { get; set; }
            public string timezone_offset { get; set; }
            public string text_color { get; set; }
            public string title_text_color { get; set; }
            public Ticket[] tickets { get; set; }
            public string distance { get; set; }
            public string created { get; set; }
            public string url { get; set; }
            public string box_text_color { get; set; }
            public string privacy { get; set; }
            public Venue venue { get; set; }
            public string modified { get; set; }
            public string logo_ssl { get; set; }
            public string repeats { get; set; }
        }

        public class Organizer
        {
            public string url { get; set; }
            public string description { get; set; }
            public string long_description { get; set; }
            public long id { get; set; }
            public string name { get; set; }
        }

        public class Venue
        {
            public string city { get; set; }
            public string name { get; set; }
            public string country { get; set; }
            public string region { get; set; }
            public float longitude { get; set; }
            public string postal_code { get; set; }
            public string address_2 { get; set; }
            public string address { get; set; }
            public float latitude { get; set; }
            public string country_code { get; set; }
            public int id { get; set; }
            public string LatLong { get; set; }
        }

        public class Ticket
        {
            public Ticket1 ticket { get; set; }
        }

        public class Ticket1
        {
            public string description { get; set; }
            public string end_date { get; set; }
            public int min { get; set; }
            public int? max { get; set; }
            public string price { get; set; }
            public string visible { get; set; }
            public string currency { get; set; }
            public string display_price { get; set; }
            public int type { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public string start_date { get; set; }
        }

    }
}
