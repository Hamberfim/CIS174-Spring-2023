using Microsoft.AspNetCore.Mvc;

namespace routes.Controllers
{
    // change routing on the entire controller INSTEAD OF each method in the controller
    // [Route("Retail/[controller]/[action]/{id?}")]  // results in a url of /retail/products/list or /retail/products/details
    public class ProductController : Controller
    {
        // uses default routing
        // uses default routing and decorating with a route attribute to shorten the url/segment requirement from /Product/List/All/ to /Product/All
        // [Route("Products/{id?}")]  // optional id
        //public IActionResult List(string id = "All")
        //{
        //    // localhost:7257/Product/List/Larry = Product Controller, List Action, id: Larry
        //    return Content($"Product Controller, List Action, id: {id}");
        //}

        // creates an AmbiguousMatchException - Overloading method doesn't work here
        //public IActionResult List(int id = 0)
        //{
        //    return Content($"Product Controller, List Action, id: {id}");
        //}

        // custom routing pattern. 4 required segments. Pattern place in program.cs i.e., additional app.MapControllerRoute ordered by detailed to less detailed
        public IActionResult List(string id, int num)
        {
            return Content($"Product Controller, List Action, Category id: {id}, Page: {num}");
        }

        // uses default routing and decorating with a route attribute to shorten the url/segment requirement from /Product/Detail/3 to /Product/3
        // dynamic alternative [Route("[controller]/{id}")] and/or [Route("[controller]/[action]")]
        [Route("Product/{id}")]
        public IActionResult Detail(int id)
        {
            return Content($"Product Controller, Detail Action, id: {id}");
        }

        // not significant to routing
        [NonAction]
        public string GetSlug(string str) => str.Replace(" ", "-").ToLower();

    }
}
