using _21july.Models;
using Microsoft.AspNetCore.Mvc;

namespace _21july.Controllers
{
    public class HomeController : Controller
    {
        // Display Form
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // Handle Form Submission
        [HttpPost]
        public IActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                TempData["StudentName"] = student.Name;
                return RedirectToAction("Schedule");
            }

            // Return the view with validation errors
            return View(student);
        }
        // COURSE SCHEDULE PAGE 
        public ActionResult Schedule()
        {
            List<Course> courses = new List<Course>
            {
                new Course { courseName = "Mathematics", sem = "1st", sessionTime = "9:00 AM - 10:30 AM", days = "Mon, Wed, Fri" },
                new Course { courseName = "Physics", sem = "1st", sessionTime = "11:00 AM - 12:30 PM", days = "Tue, Thu" },
                new Course { courseName = "Chemistry", sem = "1st", sessionTime = "2:00 PM - 3:30 PM", days = "Mon, Wed" },
                new Course { courseName = "Biology", sem = "1st", sessionTime = "4:00 PM - 5:30 PM", days = "Tue, Thu" }
            };
            return View(courses);
        }
    }
}
