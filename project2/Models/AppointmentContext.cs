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
        public DbSet<Time> Time { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Time>().HasData(
            //Times for day 1
             new Time { TimeId = 1, AppointmentTime = new DateTime(2022, 04, 01, 08, 00, 00), taken = false },
             new Time { TimeId = 2, AppointmentTime = new DateTime(2022, 04, 01, 09, 00, 00), taken = false },
             new Time { TimeId = 3, AppointmentTime = new DateTime(2022, 04, 01, 10, 00, 00), taken = false },
             new Time { TimeId = 4, AppointmentTime = new DateTime(2022, 04, 01, 11, 00, 00), taken = false },
             new Time { TimeId = 5, AppointmentTime = new DateTime(2022, 04, 01, 12, 00, 00), taken = false },
             new Time { TimeId = 6, AppointmentTime = new DateTime(2022, 04, 01, 13, 00, 00), taken = false },
             new Time { TimeId = 7, AppointmentTime = new DateTime(2022, 04, 01, 14, 00, 00), taken = false },
             new Time { TimeId = 8, AppointmentTime = new DateTime(2022, 04, 01, 15, 00, 00), taken = false },
             new Time { TimeId = 9, AppointmentTime = new DateTime(2022, 04, 01, 16, 00, 00), taken = false },
             new Time { TimeId = 10, AppointmentTime = new DateTime(2022, 04, 01, 17, 00, 00), taken = false },
             new Time { TimeId = 11, AppointmentTime = new DateTime(2022, 04, 01, 18, 00, 00), taken = false },
             new Time { TimeId = 12, AppointmentTime = new DateTime(2022, 04, 01, 19, 00, 00), taken = false },
             new Time { TimeId = 13, AppointmentTime = new DateTime(2022, 04, 01, 20, 00, 00), taken = false }



             );

            //mb.Entity<Appointment>().HasData(
            //    new Appointment {
            //        AppointmentID = 1,
            //        TimeId = 1,
            //        GroupName = "Tester",
            //        GroupSize = 3,
            //        Email = "Test@test.net",
            //        Phone = "517-879-6543" }
            //    );
        }
    }
}
