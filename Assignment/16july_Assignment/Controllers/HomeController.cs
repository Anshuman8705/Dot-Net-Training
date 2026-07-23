using _16july_Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _16july_Assignment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
