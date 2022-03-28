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
        public IActionResult AddAppointment(Appointment app, int id)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Time = AppointmentContext.Time.Single(x => x.TimeId == id).AppointmentTime;
                ViewBag.ID = AppointmentContext.Time.Single(x => x.TimeId == id).TimeId;
                ViewBag.AllTime = AppointmentContext.Time.ToList();

                return View();
            }

            var time = AppointmentContext.Time.Single(x => x.TimeId == id);

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
        [HttpGet]
        public IActionResult Edit(int appointmentId, int timeId)
        {
            ViewBag.Time = AppointmentContext.Time.Single(x => x.TimeId == timeId).AppointmentTime;
            ViewBag.ID = AppointmentContext.Time.Single(x => x.TimeId == timeId).TimeId;
            ViewBag.AllTime = AppointmentContext.Time.ToList();

            var appointment = AppointmentContext.Appointments.Single(x => x.AppointmentID == appointmentId);

            return View("AddAppointment", appointment);
        }
        [HttpPost]
        public IActionResult Edit(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                AppointmentContext.Update(appointment);
                AppointmentContext.SaveChanges();

                return RedirectToAction("ViewAppointments");
            }
            else // if invalid
            {
                return View("AddAppointment");
            }
        }
        [HttpGet]
        public IActionResult Delete (int appointmentId, int timeId)
        {
            var appointment = AppointmentContext.Appointments.Single(x => x.AppointmentID == appointmentId);
            return View(appointment);
        }
        [HttpPost] 
        public IActionResult Delete (Appointment app, int timeId)
        {
            var time = AppointmentContext.Time.Single(x => x.TimeId == timeId);
            time.taken = false;

            AppointmentContext.Update(time);
            AppointmentContext.Appointments.Remove(app);
            AppointmentContext.SaveChanges();

            return RedirectToAction("ViewAppointments");
        }


    }
}
