using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace manders_api.Models {
    public class Appointment {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
    }
}