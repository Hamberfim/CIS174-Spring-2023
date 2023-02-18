using Microsoft.AspNetCore.Mvc;
using routes.Models;
using System.Diagnostics;

namespace routes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Home Controller, Index Action");
        }

        // Decorating the about method using a route attribute - shortens the url from localhost:7257/Home/About to localhost:7257/About
        [Route("About")]
        public IActionResult About()
        {
            return Content("Home Controller, About Action");
        }

    }
}