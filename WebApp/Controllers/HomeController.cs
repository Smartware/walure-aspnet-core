using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public int Add()
        {
            return (5 * 4);
        }

        public string Welcome()
        {
            return "Welcome Ejiro";
        }

        public string Index()
        {
            return "Welcome to asp.net core";
        }
    }
}
