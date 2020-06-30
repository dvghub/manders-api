using manders_api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace manders_api.Services {
    public class DbService : DbContext {
        public DbSet<User> Users { get; set; }
        public DbSet<PageContent> Contents { get; set; }
        public DbSet<PageImage> Images { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
              => options.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=manders-db;Integrated Security = True");
    }
}
