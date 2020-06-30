using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace manders_api.Models {
    public class Appointment {
        public int Id { get; set; }
        public Slot Slot { get; set; }
        public bool Double { get; set; }
        public User User { get; set; }
        public bool Confirmed { get; set; }
        public bool Reminded { get; set; }
        public bool Cancelled { get; set; }
        public bool Handled { get; set; }
    }
}