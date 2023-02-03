using ContactManagerApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ContactManagerApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}