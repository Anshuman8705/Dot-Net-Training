using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Controllers
{
    // ==================================================================
    // EmployeeController
    // Its job is only this: build the list of employees, and hand it
    // to the View so the View can display it. No database yet - the
    // list is hardcoded here for now, same as the console app projects.
    // ==================================================================
    public class EmployeeController : Controller
    {
        // This runs when the browser visits /Employee or /Employee/Index
        public IActionResult Index()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    EmployeeId = 1,
                    Name = "Rahul Sharma",
                    Department = "IT",
                    Salary = 55000,
                    Email = "rahul.sharma@company.com"
                },
                new Employee
                {
                    EmployeeId = 2,
                    Name = "Priya Singh",
                    Department = "HR",
                    Salary = 48000,
                    Email = "priya.singh@company.com"
                },
                new Employee
                {
                    EmployeeId = 3,
                    Name = "Amit Verma",
                    Department = "Finance",
                    Salary = 62000,
                    Email = "amit.verma@company.com"
                }
            };

            // "View(employees)" sends this list to Views/Employee/Index.cshtml
            return View(employees);
        }
    }
}