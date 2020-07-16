using manders_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace manders_api.Services {
    public class ScheduleService {
        private readonly DbService db = new DbService();

        public List<Slot> GetForDate(DateTime date) {
            Schedule schedule = db.Schedules.Where(s => s.Start.CompareTo(date) <= 0 && s.End.CompareTo(date) >= 0).FirstOrDefault();

            if (schedule != null) {
                switch (date.DayOfWeek) {
                    case DayOfWeek.Monday:
                        return schedule.Monday;
                    case DayOfWeek.Tuesday:
                        return schedule.Tuesday;
                    case DayOfWeek.Wednesday:
                        return schedule.Wednesday;
                    case DayOfWeek.Thursday:
                        return schedule.Thursday;
                    case DayOfWeek.Friday:
                        return schedule.Friday;
                    case DayOfWeek.Saturday:
                        return schedule.Saturday;
                    case DayOfWeek.Sunday:
                        return schedule.Sunday;
                    default:
                        break;
                }
            }

            List<Slot> basic = new List<Slot> {
                new Slot(new DateTime(1975, 1, 1).AddHours(8).AddMinutes(30), new DateTime(1975, 1, 1).AddHours(9).AddMinutes(15)),
                new Slot(new DateTime(1975, 1, 1).AddHours(9).AddMinutes(30), new DateTime(1975, 1, 1).AddHours(10).AddMinutes(15)),
                new Slot(new DateTime(1975, 1, 1).AddHours(10).AddMinutes(45), new DateTime(1975, 1, 1).AddHours(11).AddMinutes(30)),
                new Slot(new DateTime(1975, 1, 1).AddHours(11).AddMinutes(45), new DateTime(1975, 1, 1).AddHours(12).AddMinutes(30)),
                new Slot(new DateTime(1975, 1, 1).AddHours(13).AddMinutes(30), new DateTime(1975, 1, 1).AddHours(14).AddMinutes(15)),
                new Slot(new DateTime(1975, 1, 1).AddHours(14).AddMinutes(30), new DateTime(1975, 1, 1).AddHours(15).AddMinutes(15)),
                new Slot(new DateTime(1975, 1, 1).AddHours(15).AddMinutes(30), new DateTime(1975, 1, 1).AddHours(16).AddMinutes(15)),
                new Slot(new DateTime(1975, 1, 1).AddHours(16).AddMinutes(30), new DateTime(1975, 1, 1).AddHours(17).AddMinutes(15)),
                new Slot(new DateTime(1975, 1, 1).AddHours(19), new DateTime(1975, 1, 1).AddHours(19).AddMinutes(45))
            };

            return basic;
        }
    }
}