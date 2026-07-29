using _29July.Models;
using _29July.Services;
using Microsoft.AspNetCore.Mvc;

namespace _29July.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        // Get all employees
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.getEmployees());
        }

        // Get employee by Department Id
        [HttpGet("{deptid}")]
        public IActionResult GetByDeptId(int deptid)
        {
            var employee = _service.getEmployees(deptid);

            if (employee == null)
            {
                return NotFound("Employee not found.");
            }

            return Ok(employee);
        }

        // Get employee by Name
        [HttpGet("name/{name}")]
        public IActionResult GetByName(string name)
        {
            var employee = _service.getEmployees(name);

            if (employee == null)
            {
                return NotFound("Employee not found.");
            }

            return Ok(employee);
        }

        // Add new employee
        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            var result = _service.addEmployees(employee);
            return Ok(result);
        }
    }
}