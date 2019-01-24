using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstMVC.Controllers;
using MyFirstMVC.Models;

namespace MyFirstMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int startYear, int endYear)
        {
            //return View();
            return RedirectToAction("Result", new {startYear, endYear});
        }
        
        public IActionResult Result(int startYear, int endYear)
        {
            //Went over with Amanda
            return View(TimePerson.GetPersons(startYear, endYear));
            //List<TimePerson> people = TimePerson.GetPersons(startYear, endYear);
            //return View();
        }
        
    }
}
