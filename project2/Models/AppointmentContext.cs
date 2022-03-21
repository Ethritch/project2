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
            mb.Entity<Appointment>().HasData(
                new Appointment { AppointmentID = -1, Time = new DateTime(2022, 03, 30, 1, 14, 50), GroupName = "Tester", GroupSize = 3, Email = "Test@test.net", Phone = "517-879-6543" }
                );
        }
    }
}
