using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            /* var date = DateTime.Now.ToString("dddd dd, MMMM (MM) yyyy hh:mm:ss");
             base.ViewBag.date = date;*/

            var people = new List<Person>();
            people.Add(new Person { LastName = "Prolifik", FirstName = "Lexzy", Age = 49 });
            people.Add(new Person { LastName = "Ben", FirstName = "Fejiro", Age = 42 });
            people.Add(new Person { LastName = "Dele", FirstName = "Adeyemi", Age = 59 });
            people.Add(new Person { LastName = "Bob", FirstName = "Tabor", Age = 19 });

            return View(people);
        }
    }
}
