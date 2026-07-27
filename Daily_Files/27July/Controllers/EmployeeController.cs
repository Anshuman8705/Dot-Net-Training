using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using _27July.Models;

namespace _27July.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee() { Id = 101, Name = "Anshu", LastName = "Agrawal", Dept = "IT", PhoneNum = "+919897969594", Profile = "Developer", Location = "Nagpur" },
            new Employee() { Id = 102, Name = "Rahul", LastName = "Sharma", Dept = "HR", PhoneNum = "+919897969595", Profile = "Manager", Location = "Pune" }
        };
        //get all employee list 
        [HttpGet("{id}")]
        public IActionResult getEmployeeById(int id)
        {
            var employee = employees.FirstOrDefault(x => x.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
        // add new employee record 
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            employees.Add(employee);
            return Ok(employee);

        }
        // edit employee Record 
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, Employee employee)
        {
            var employee1 = employees.FirstOrDefault(x => x.Id == id);
            if (employee1 == null)
            {
                return NotFound();
            }
            employee1.LastName = employee.LastName;
            return Ok(employee1);

        }
        [HttpGet("Dept/{dept}")] 
        public IActionResult GetEmployeeByDept(string dept) 
        { 
            var result = employees.Where(s => s.Dept.Equals(dept, StringComparison.OrdinalIgnoreCase)).ToList();
            if (!result.Any()) 
            { 
                return NotFound("Not employee found under this dept");
            } 
            return Ok(result); 
        }
        // get employee list by profile
        [HttpGet("Profile/{profile}")]
        public IActionResult GetEmployeeByProfile(string profile)
        {
            var result = employees.Where(x => x.Profile.Equals(profile, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!result.Any())
            {
                return NotFound("No employee found under this profile");
            }

            return Ok(result);
        }

        // get employee list by location
        [HttpGet("Location/{location}")]
        public IActionResult GetEmployeeByLocation(string location)
        {
            var result = employees.Where(x => x.Location.Equals(location, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!result.Any())
            {
                return NotFound("No employee found under this location");
            }

            return Ok(result);
        }
    }
}