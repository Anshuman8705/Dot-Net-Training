using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Controllers
{
    // ==================================================================
    // DepartmentController
    // Same idea as EmployeeController, but for departments.
    // ==================================================================
    public class DepartmentController : Controller
    {
        // This runs when the browser visits /Department or /Department/Index
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>
            {
                new Department
                {
                    DeptName = "IT",
                    DepartmentHead = "Sanjay Mehta",
                    HeadContact = "9876543210",
                    HeadEmail = "sanjay.mehta@company.com"
                },
                new Department
                {
                    DeptName = "HR",
                    DepartmentHead = "Neha Kapoor",
                    HeadContact = "9123456780",
                    HeadEmail = "neha.kapoor@company.com"
                },
                new Department
                {
                    DeptName = "Finance",
                    DepartmentHead = "Ravi Kumar",
                    HeadContact = "9988776655",
                    HeadEmail = "ravi.kumar@company.com"
                }
            };

            // Sends this list to Views/Department/Index.cshtml
            return View(departments);
        }
    }
}