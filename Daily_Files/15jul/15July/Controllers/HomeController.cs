// brain of MVC 
//receives user request,processes it and returns the appropriate response

using _15July.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _15July.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() // is a action method - every url calls an action method 
        {
            return View(); // returns a view to the browser - view is a html page which is sent to the browser
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
