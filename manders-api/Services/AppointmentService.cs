using manders_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace manders_api.Services {
    public class AppointmentService {
        private readonly DbService db = new DbService();

        public List<Appointment> Read(DateTime day) {
            return db.Appointments.Where(a => 
                    !a.Cancelled && 
                    a.Slot.Start.Date.CompareTo(day) == 0
                ).ToList();
        }
    }
}