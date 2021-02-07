using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld/")] // DRY version for methods
    public class HelloController : Controller // Extends Controller
    {
        // GET: /<controller>/
        // Add an HTTP verb attribute - that specifies the request type,
        // we want a GET: request. Tell the index you only want to respond
        // to the GET: request
        [HttpGet]
        // [Route("/helloworld/")] // Gives the path information
        public IActionResult Index() // First method
        {
            // Want it to return a form
            string html = "<form method='post' action='/helloworld/'>" +
                "<input type='text' name='name' />" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";

            // This is an IActionResult return that allows us to return
            // html, .json, etc.
            // Need to specify variable it is returning as well as its type
            return Content(html, "text/html");
        }

        // Add arguments to the action method
        // GET: /hello/welcome
        // [HttpGet]
        // [Route("/helloworld/welcome/{name?}")] // This says where we want to go
        // The ? designates the name as optional
        // helloworld/welcome/Bryan

        [HttpGet("/welcome/{name?}")] // Short version of above for DRY
        [HttpPost]
        // [Route("/helloworld/")]
        public IActionResult Welcome(string name = "World") // Default value is World
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>",
                "text/html");
        }
    }
}
