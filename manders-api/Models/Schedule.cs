using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace manders_api.Models {
    public class Schedule {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public List<Slot> Monday { get; set; }
        public List<Slot> Tuesday { get; set; }
        public List<Slot> Wednesday { get; set; }
        public List<Slot> Thursday { get; set; }
        public List<Slot> Friday { get; set; }
        public List<Slot> Saturday { get; set; }
        public List<Slot> Sunday { get; set; }
    }
}