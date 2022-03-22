using Microsoft.AspNetCore.Mvc;
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

        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult AddAppointment(DateTime)
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAppointment(Appointment app)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            AppointmentContext.Add(app);
            AppointmentContext.SaveChanges();
            return View("Index");

        }


        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult ViewAppointments()
        {
            return View();
        }


      
    }
}
