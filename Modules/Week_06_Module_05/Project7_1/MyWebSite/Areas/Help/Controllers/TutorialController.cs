using Microsoft.AspNetCore.Mvc;

namespace MyWebSite.Areas.Help.Controllers
{
    [Area("Help")]
    public class TutorialController : Controller
    {
        public IActionResult Index(string id)
        {
            if (id == "Page1")
            {
                return View("Page1");
            }
            else if (id == "Page2")
            {
                return View("Page2");
            }
            else
            {
                return View("Page3");
            }
        }
    }
}
