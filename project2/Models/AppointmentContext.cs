using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project2.Models
{
    public class AppointmentContext : DbContext
    {
        public AppointmentContext (DbContextOptions<AppointmentContext> options) : base (options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Time> Times { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Time>().HasData(
             new Time { TimeId = 1, dateTime = new DateTime(2022, 04, 01, 08, 00, 00) },
             new Time { TimeId = 2, dateTime = new DateTime(2022, 04, 01, 08, 00, 00) },
             new Time { TimeId = 3, dateTime = new DateTime(2022, 04, 01, 08, 00, 00) },
             new Time { TimeId = 4, dateTime = new DateTime(2022, 04, 01, 08, 00, 00) },
             new Time { TimeId = 5, dateTime = new DateTime(2022, 04, 01, 08, 00, 00) },
             new Time { TimeId = 6, dateTime = new DateTime(2022, 04, 01, 08, 00, 00) },
             new Time { TimeId = 7, dateTime = new DateTime(2022, 04, 01, 08, 00, 00) }

             );

            mb.Entity<Appointment>().HasData(
                new Appointment {
                    AppointmentID = -1,
                    TimeId = -1,
                    GroupName = "Tester",
                    GroupSize = 3,
                    Email = "Test@test.net",
                    Phone = "517-879-6543" }
                );
        }
    }
}
