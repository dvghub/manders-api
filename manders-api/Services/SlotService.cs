using manders_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace manders_api.Services {
    public class SlotService {
        private readonly DbService db = new DbService();

        public Slot Get(int id) {
            return db.Slots.Find(id);
        }
    }
}