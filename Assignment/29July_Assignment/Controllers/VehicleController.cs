using _29July_Assignment.Models;
using _29July_Assignment.Services;
using Microsoft.AspNetCore.Mvc;

namespace _29July_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _service;

        public VehicleController(IVehicleService service)
        {
            _service = service;
        }

        // Get all vehicles
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetVehicles());
        }

        // Get vehicle by Id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var vehicle = _service.GetVehicleById(id);

            if (vehicle == null)
            {
                return NotFound("Vehicle not found.");
            }

            return Ok(vehicle);
        }

        // Get vehicle by Vehicle Number
        [HttpGet("number/{vehicleNumber}")]
        public IActionResult GetByNumber(string vehicleNumber)
        {
            var vehicle = _service.GetVehicleByNumber(vehicleNumber);

            if (vehicle == null)
            {
                return NotFound("Vehicle not found.");
            }

            return Ok(vehicle);
        }

        // Add new vehicle
        [HttpPost]
        public IActionResult Post(Vehicle vehicle)
        {
            var result = _service.AddVehicle(vehicle);
            return Ok(result);
        }
    }
}