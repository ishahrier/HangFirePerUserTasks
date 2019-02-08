using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestWebClientServer.Models;

namespace TestWebClientServer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hellow");
        }
    }
}
