using _16_jul.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _16_jul.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>() { 
            new Student { Id = 1, Name = "John", Age = 20, Course = "Computer Science" , Gender = 'M', Fees= 20000 , Qualification = "HSC" },
            new Student { Id = 2, Name = "Jane", Age = 22, Course = "Mathematics", Gender = 'M', Fees= 20000 , Qualification = "HSC" },
            new Student {Id = 3, Name = "Mike", Age = 21, Course = "Physics", Gender = 'M', Fees = 20000, Qualification = "HSC"},
            new Student {Id = 4, Name = "Emily", Age = 19, Course = "Chemistry", Gender = 'F', Fees = 20000, Qualification = "HSC"},
            new Student {Id = 5, Name = "David", Age = 23, Course = "Biology", Gender = 'M', Fees = 20000, Qualification = "HSC"},
            };
            
            return View(students);
        }

    }
}
