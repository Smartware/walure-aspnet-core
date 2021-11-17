using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class ArithmeticController : Controller
    {
        public string Multiply()
        {
            int result = 8 * 7;
            return $"8 X 7 = {result}";
        }
    }
}
