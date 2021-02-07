using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNET.Controllers
{
    public class HelloController : Controller // Extends Controller
    {
        [HttpGet]
        public IActionResult Index() // First method
        {
            return View();
        }

        [HttpPost]
        [Route("/hello/")]
        public IActionResult Welcome(string name = "World") // Default value is World
        {
            ViewBag.person = name;
            return View();
        }
    }
}
