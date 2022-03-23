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

        protected override void OnModelCreating(ModelBuilder mb)
        {
<<<<<<< Updated upstream
            mb.Entity<Appointment>().HasData(
                new Appointment { AppointmentID = -1, Time = new DateTime(2022, 03, 30, 1, 14, 50), GroupName = "Tester", GroupSize = 3, Email = "Test@test.net", Phone = "517-879-6543" }
                );
=======
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
             new Time { TimeId = 13, AppointmentTime = new DateTime(2022, 04, 01, 20, 00, 00), taken = false },

             //Times for day 2
             new Time { TimeId = 14, AppointmentTime = new DateTime(2022, 04, 02, 08, 00, 00), taken = false },
             new Time { TimeId = 15, AppointmentTime = new DateTime(2022, 04, 02, 09, 00, 00), taken = false },
             new Time { TimeId = 16, AppointmentTime = new DateTime(2022, 04, 02, 10, 00, 00), taken = false },
             new Time { TimeId = 17, AppointmentTime = new DateTime(2022, 04, 02, 11, 00, 00), taken = false },
             new Time { TimeId = 18, AppointmentTime = new DateTime(2022, 04, 02, 12, 00, 00), taken = false },
             new Time { TimeId = 19, AppointmentTime = new DateTime(2022, 04, 02, 13, 00, 00), taken = false },
             new Time { TimeId = 20, AppointmentTime = new DateTime(2022, 04, 02, 14, 00, 00), taken = false },
             new Time { TimeId = 21, AppointmentTime = new DateTime(2022, 04, 02, 15, 00, 00), taken = false },
             new Time { TimeId = 22, AppointmentTime = new DateTime(2022, 04, 02, 16, 00, 00), taken = false },
             new Time { TimeId = 23, AppointmentTime = new DateTime(2022, 04, 02, 17, 00, 00), taken = false },
             new Time { TimeId = 24, AppointmentTime = new DateTime(2022, 04, 02, 18, 00, 00), taken = false },
             new Time { TimeId = 25, AppointmentTime = new DateTime(2022, 04, 02, 19, 00, 00), taken = false },
             new Time { TimeId = 26, AppointmentTime = new DateTime(2022, 04, 02, 20, 00, 00), taken = false },

             //Times for day 3
             new Time { TimeId = 27, AppointmentTime = new DateTime(2022, 04, 03, 08, 00, 00), taken = false },
             new Time { TimeId = 28, AppointmentTime = new DateTime(2022, 04, 03, 09, 00, 00), taken = false },
             new Time { TimeId = 29, AppointmentTime = new DateTime(2022, 04, 03, 10, 00, 00), taken = false },
             new Time { TimeId = 30, AppointmentTime = new DateTime(2022, 04, 03, 11, 00, 00), taken = false },
             new Time { TimeId = 31, AppointmentTime = new DateTime(2022, 04, 03, 12, 00, 00), taken = false },
             new Time { TimeId = 32, AppointmentTime = new DateTime(2022, 04, 03, 13, 00, 00), taken = false },
             new Time { TimeId = 33, AppointmentTime = new DateTime(2022, 04, 03, 14, 00, 00), taken = false },
             new Time { TimeId = 34, AppointmentTime = new DateTime(2022, 04, 03, 15, 00, 00), taken = false },
             new Time { TimeId = 35, AppointmentTime = new DateTime(2022, 04, 03, 16, 00, 00), taken = false },
             new Time { TimeId = 36, AppointmentTime = new DateTime(2022, 04, 03, 17, 00, 00), taken = false },
             new Time { TimeId = 37, AppointmentTime = new DateTime(2022, 04, 03, 18, 00, 00), taken = false },
             new Time { TimeId = 38, AppointmentTime = new DateTime(2022, 04, 03, 19, 00, 00), taken = false },
             new Time { TimeId = 39, AppointmentTime = new DateTime(2022, 04, 03, 20, 00, 00), taken = false },

             //Times for day 4
             new Time { TimeId = 40, AppointmentTime = new DateTime(2022, 04, 04, 08, 00, 00), taken = false },
             new Time { TimeId = 41, AppointmentTime = new DateTime(2022, 04, 04, 09, 00, 00), taken = false },
             new Time { TimeId = 42, AppointmentTime = new DateTime(2022, 04, 04, 10, 00, 00), taken = false },
             new Time { TimeId = 43, AppointmentTime = new DateTime(2022, 04, 04, 11, 00, 00), taken = false },
             new Time { TimeId = 44, AppointmentTime = new DateTime(2022, 04, 04, 12, 00, 00), taken = false },
             new Time { TimeId = 45, AppointmentTime = new DateTime(2022, 04, 04, 13, 00, 00), taken = false },
             new Time { TimeId = 46, AppointmentTime = new DateTime(2022, 04, 04, 14, 00, 00), taken = false },
             new Time { TimeId = 47, AppointmentTime = new DateTime(2022, 04, 04, 15, 00, 00), taken = false },
             new Time { TimeId = 48, AppointmentTime = new DateTime(2022, 04, 04, 16, 00, 00), taken = false },
             new Time { TimeId = 49, AppointmentTime = new DateTime(2022, 04, 04, 17, 00, 00), taken = false },
             new Time { TimeId = 50, AppointmentTime = new DateTime(2022, 04, 04, 18, 00, 00), taken = false },
             new Time { TimeId = 51, AppointmentTime = new DateTime(2022, 04, 04, 19, 00, 00), taken = false },
             new Time { TimeId = 52, AppointmentTime = new DateTime(2022, 04, 04, 20, 00, 00), taken = false },

             //Times for day 5
             new Time { TimeId = 53, AppointmentTime = new DateTime(2022, 04, 05, 08, 00, 00), taken = false },
             new Time { TimeId = 54, AppointmentTime = new DateTime(2022, 04, 05, 09, 00, 00), taken = false },
             new Time { TimeId = 55, AppointmentTime = new DateTime(2022, 04, 05, 10, 00, 00), taken = false },
             new Time { TimeId = 56, AppointmentTime = new DateTime(2022, 04, 05, 11, 00, 00), taken = false },
             new Time { TimeId = 57, AppointmentTime = new DateTime(2022, 04, 05, 12, 00, 00), taken = false },
             new Time { TimeId = 58, AppointmentTime = new DateTime(2022, 04, 05, 13, 00, 00), taken = false },
             new Time { TimeId = 59, AppointmentTime = new DateTime(2022, 04, 05, 14, 00, 00), taken = false },
             new Time { TimeId = 60, AppointmentTime = new DateTime(2022, 04, 05, 15, 00, 00), taken = false },
             new Time { TimeId = 61, AppointmentTime = new DateTime(2022, 04, 05, 16, 00, 00), taken = false },
             new Time { TimeId = 62, AppointmentTime = new DateTime(2022, 04, 05, 17, 00, 00), taken = false },
             new Time { TimeId = 63, AppointmentTime = new DateTime(2022, 04, 05, 18, 00, 00), taken = false },
             new Time { TimeId = 64, AppointmentTime = new DateTime(2022, 04, 05, 19, 00, 00), taken = false },
             new Time { TimeId = 65, AppointmentTime = new DateTime(2022, 04, 05, 20, 00, 00), taken = false },

             //Times for day 6
             new Time { TimeId = 66, AppointmentTime = new DateTime(2022, 04, 06, 08, 00, 00), taken = false },
             new Time { TimeId = 67, AppointmentTime = new DateTime(2022, 04, 06, 09, 00, 00), taken = false },
             new Time { TimeId = 68, AppointmentTime = new DateTime(2022, 04, 06, 10, 00, 00), taken = false },
             new Time { TimeId = 69, AppointmentTime = new DateTime(2022, 04, 06, 11, 00, 00), taken = false },
             new Time { TimeId = 70, AppointmentTime = new DateTime(2022, 04, 06, 12, 00, 00), taken = false },
             new Time { TimeId = 71, AppointmentTime = new DateTime(2022, 04, 06, 13, 00, 00), taken = false },
             new Time { TimeId = 72, AppointmentTime = new DateTime(2022, 04, 06, 14, 00, 00), taken = false },
             new Time { TimeId = 73, AppointmentTime = new DateTime(2022, 04, 06, 15, 00, 00), taken = false },
             new Time { TimeId = 74, AppointmentTime = new DateTime(2022, 04, 06, 16, 00, 00), taken = false },
             new Time { TimeId = 75, AppointmentTime = new DateTime(2022, 04, 06, 17, 00, 00), taken = false },
             new Time { TimeId = 76, AppointmentTime = new DateTime(2022, 04, 06, 18, 00, 00), taken = false },
             new Time { TimeId = 77, AppointmentTime = new DateTime(2022, 04, 06, 19, 00, 00), taken = false },
             new Time { TimeId = 78, AppointmentTime = new DateTime(2022, 04, 06, 20, 00, 00), taken = false },
             
             //Times for day 7
             new Time { TimeId = 79, AppointmentTime = new DateTime(2022, 04, 07, 08, 00, 00), taken = false },
             new Time { TimeId = 80, AppointmentTime = new DateTime(2022, 04, 07, 09, 00, 00), taken = false },
             new Time { TimeId = 81, AppointmentTime = new DateTime(2022, 04, 07, 10, 00, 00), taken = false },
             new Time { TimeId = 82, AppointmentTime = new DateTime(2022, 04, 07, 11, 00, 00), taken = false },
             new Time { TimeId = 83, AppointmentTime = new DateTime(2022, 04, 07, 12, 00, 00), taken = false },
             new Time { TimeId = 84, AppointmentTime = new DateTime(2022, 04, 07, 13, 00, 00), taken = false },
             new Time { TimeId = 85, AppointmentTime = new DateTime(2022, 04, 07, 14, 00, 00), taken = false },
             new Time { TimeId = 86, AppointmentTime = new DateTime(2022, 04, 07, 15, 00, 00), taken = false },
             new Time { TimeId = 87, AppointmentTime = new DateTime(2022, 04, 07, 16, 00, 00), taken = false },
             new Time { TimeId = 88, AppointmentTime = new DateTime(2022, 04, 07, 17, 00, 00), taken = false },
             new Time { TimeId = 89, AppointmentTime = new DateTime(2022, 04, 07, 18, 00, 00), taken = false },
             new Time { TimeId = 90, AppointmentTime = new DateTime(2022, 04, 07, 19, 00, 00), taken = false },
             new Time { TimeId = 91, AppointmentTime = new DateTime(2022, 04, 07, 20, 00, 00), taken = false }
            
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
>>>>>>> Stashed changes
        }
    }
}
