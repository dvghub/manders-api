using manders_api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace manders_api.Services {
    public class ScheduleService {
        private readonly DbService db = new DbService();

        public List<Slot> GetForDate(DateTime date) {
            var schedules = db.Schedules.Where(s => s.Start.CompareTo(date) <= 0 && s.End.CompareTo(date) >= 0);

            Debug.WriteLine(date.DayOfWeek);

            Schedule schedule;
            if (schedules.Count() == 0) schedule = CreateSchedule(date);
            else schedule = schedules.Include(date.DayOfWeek.ToString()).FirstOrDefault();

            switch(date.DayOfWeek) {
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
                default:
                    return null;
            }
        }

        private Schedule CreateSchedule(DateTime date) {
            Schedule schedule = new Schedule();

            DateTime monday = date.AddDays(-(int)date.DayOfWeek);

            schedule.Start = monday;
            schedule.End = monday.AddDays(6);

            int year;
            int month;
            int day;

            for (int i = 0; i < 6; i++) {
                monday = monday.AddDays(1);
                year = monday.Year;
                month = monday.Month;
                day = monday.Day;

                List<Slot> slots = new List<Slot> {
                        new Slot(new DateTime(year, month, day).AddHours(8).AddMinutes(30), new DateTime(year, month, day).AddHours(9).AddMinutes(15), true),
                        new Slot(new DateTime(year, month, day).AddHours(9).AddMinutes(30), new DateTime(year, month, day).AddHours(10).AddMinutes(15), false),
                        new Slot(new DateTime(year, month, day).AddHours(10).AddMinutes(45), new DateTime(year, month, day).AddHours(11).AddMinutes(30), true),
                        new Slot(new DateTime(year, month, day).AddHours(11).AddMinutes(45), new DateTime(year, month, day).AddHours(12).AddMinutes(30), false),
                        new Slot(new DateTime(year, month, day).AddHours(13).AddMinutes(30), new DateTime(year, month, day).AddHours(14).AddMinutes(15), true),
                        new Slot(new DateTime(year, month, day).AddHours(14).AddMinutes(30), new DateTime(year, month, day).AddHours(15).AddMinutes(15), true),
                        new Slot(new DateTime(year, month, day).AddHours(15).AddMinutes(30), new DateTime(year, month, day).AddHours(16).AddMinutes(15), true),
                        new Slot(new DateTime(year, month, day).AddHours(16).AddMinutes(30), new DateTime(year, month, day).AddHours(17).AddMinutes(15), false),
                        new Slot(new DateTime(year, month, day).AddHours(19), new DateTime(year, month, day).AddHours(19).AddMinutes(45), false)
                    };

                slots.ForEach(s => {
                    db.Slots.Add(s);
                });

                db.SaveChanges();

                switch (i) {
                    case 0:
                        schedule.Monday = slots;
                        break;
                    case 1:
                        schedule.Tuesday = slots;
                        break;
                    case 2:
                        schedule.Wednesday = slots;
                        break;
                    case 3:
                        schedule.Thursday = slots;
                        break;
                    case 4:
                        schedule.Friday = slots;
                        break;
                    case 5:
                        schedule.Saturday = slots;
                        break;
                }
            }

            db.Schedules.Add(schedule);
            db.SaveChanges();

            return schedule;
        }
    }
}
