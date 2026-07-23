using Microsoft.AspNetCore.Mvc;
using _22july.Models;

namespace _22july.Controllers
{
    public class StationeryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Stationery stationery)
        {
            if (ModelState.IsValid)
            {
                return Content(
                    $"Item: {stationery.ItemName}\n" +
                    $"Brand: {stationery.Brand}\n" +
                    $"Quantity: {stationery.Quantity}\n" +
                    $"Price: {stationery.Price}\n" +
                    $"Category: {stationery.Category}"
                );
            }

            return View(stationery);
        }
    }
}