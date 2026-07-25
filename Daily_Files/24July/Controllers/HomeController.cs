using _24July.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _24July.Controllers
{
    public class HomeController : Controller
    {
        //Get: Login
        public IActionResult Index()
        {
            return View();
        }
        //Post: login
        [HttpPost]
        public ActionResult Index(Student student)
        {
            if (ModelState.IsValid)
            {
                if (student.Username == "admin" && student.Password == "12345")
                {
                    HttpContext.Session.SetString("User", student.Username);
                    return RedirectToAction("Dashboard");
                }
                ViewBag.Error = "Invalid Username Or Password";

            }
            return View(student);
        }

        // DASHBOARD
        public ActionResult Dashboard()
        {
            var User = HttpContext.Session.GetString("User");
            if (string.IsNullOrEmpty(User))
            {
                return RedirectToAction("Index");

            }
            ViewBag.User = User;
            Info emp = new Info()
            {
                Id = 101,
                Name = "Anshu",
                Salary = 50000,

            };
            
            return View(emp);
        }

        // logout 
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
