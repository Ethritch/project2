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
       

        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult ViewAppointments()
        {
            return View();
        }

        public IActionResult AddAppointments()
        {
            return View();
        }


      
    }
}
