using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace manders_api.Models {
    public class Slot {
        public Slot() {}
        public Slot(DateTime start, DateTime end, bool doubleable) {
            Start = start;
            End = end;
            Doubleable = doubleable;
        }

        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool Doubleable { get; set; }
    }
}