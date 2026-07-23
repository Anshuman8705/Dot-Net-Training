using _22july.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _22july.Controllers
{
    public class HomeController : Controller
    {
        //display form
        public IActionResult Index()
        {
            return View();
        }

        // receive form data
        [HttpPost]
        public ActionResult Index(Product product)
        {
            if (ModelState.IsValid)
            {
                // Normally save to database
                return Content($"Product: {product.Name}, " +
                               $"Price: {product.Price}, " +
                               $"Category: {product.Category}, " +
                               $"Stock: {product.Stock}");
            }

            // Return the view with validation errors
            return View(product);
        }
    }
}
