using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using project2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace project2.Controllers
{
    public class HomeController : Controller
    {

        private AppointmentContext AppointmentContext { get; set; }

        public HomeController(AppointmentContext someName)
        {
            //Configures connection to database
            AppointmentContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult AddAppointment(int id)
        {

            //var time = AppointmentContext.Time.SingleOrDefault(x => x.TimeId == id);
            ViewBag.Time = AppointmentContext.Time.Single(x => x.TimeId == id).AppointmentTime;
            ViewBag.ID = AppointmentContext.Time.Single(x => x.TimeId == id).TimeId;

            return View();
        }

        [HttpPost]
        public IActionResult AddAppointment(Appointment app, int timeID)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var time = AppointmentContext.Time.Single(x => x.TimeId == timeID);

            time.taken = true;

            AppointmentContext.Update(time);
            AppointmentContext.Add(app);
            AppointmentContext.SaveChanges();
            return View("Confirmation", app);

        }

        [HttpGet]
        public IActionResult SignUp()
        {
            var times = AppointmentContext.Time.ToList();

            return View(times);
        }
        public IActionResult ViewAppointments()
        {
            var appointment = AppointmentContext.Appointments
                .OrderBy(x => x.TimeId)
                .Include(x => x.Time)
                .ToList();

            return View(appointment);
        }


      
    }
}
