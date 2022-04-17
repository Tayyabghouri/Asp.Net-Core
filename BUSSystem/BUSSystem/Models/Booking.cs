using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUSSystem.Models
{
    public class Booking
    {
        public int id { get; set; }
        public string Destination { get; set; }
        public string No_of_Passengers { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Bus_detail { get; set; }
        public string Avaialable_Seats { get; set; }
    }
}