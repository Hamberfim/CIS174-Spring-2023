using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MyWebSite.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var contacts = new Dictionary<string, string> {
                { "Phone", "555-555-1001" },
                { "Email", "someone@fake.com" },
                { "SMS/TXT", "555-555-1002" },
                { "Facebook", "facebook.com/someone"}
            };
            return View(contacts);
        }
    }
}