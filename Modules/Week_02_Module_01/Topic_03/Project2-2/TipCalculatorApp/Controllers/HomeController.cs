using Microsoft.AspNetCore.Mvc;

using TipCalculatorApp.Models;

namespace TipCalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            ViewBag.Tip15 = 0;
            ViewBag.Tip20 = 0;
            ViewBag.Tip25 = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(TipCalculatorModel model)
        {
            if (ModelState.IsValid)
            {

                ViewBag.Tip15 = model.CaclulateTip().tip15;
                ViewBag.Tip20 = model.CaclulateTip().tip20;
                ViewBag.Tip25 = model.CaclulateTip().tip25;
            }
            else
            {
                ViewBag.Tip15 = 0;
                ViewBag.Tip20 = 0;
                ViewBag.Tip25 = 0;
            }

            return View(model);
        }

    }
}
