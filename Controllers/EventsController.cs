using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNET.Controllers
{
    // When making a new controller, you must make new folder in the Views
    // folder to hold all the views we will need for the controller (in this
    // case Events). The new folder must be the same name as the controller's
    // name.
    public class EventsController : Controller
    {
        // A class-level List so other ActionMethods in this controller can
        // utilize it
        static private List<string> Events = new List<string>();

        // GET: /<controller>/
        [HttpGet] // Needed to make sure that Index() only responds to GET requests
        // at the route localhost:5000/events
        public IActionResult Index()
        {
            ViewBag.events = Events;

            return View();
        }

        // Add a new Action method to render a form to add new events
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        // Now we need to add an Action method to handle the form submission
        [HttpPost]
        [Route("/Events/Add")]
        public IActionResult NewEvent(string name)
        {
            // We want to take in an event and add it into the list
            Events.Add(name);
            // We don't have a view for this, but we want to redirect back
            // to the route where there is
            return Redirect("/Events");
        }
    }
}
