using ContactManagerApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ContactManagerApp.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }
        public HomeController(ContactContext ctx) => context = ctx;
        public IActionResult Index()
        {
            var contacts = context.Contacts.Include(c => c.Category).OrderBy(c => c.LastName).ToList();
            return View(contacts);
        }
    }
}