using manders_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace manders_api.Services {
    public class SlotService {
        private readonly DbService db = new DbService();

        public List<Slot> GetForDate(DateTime date) {
            return db.Slots.Where(s => 
            s.Start.Year == date.Year &&
            s.Start.Month == date.Month &&
            s.Start.Day == date.Day).ToList();
        }
    }
}