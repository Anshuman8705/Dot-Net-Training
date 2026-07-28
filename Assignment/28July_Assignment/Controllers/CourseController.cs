using CourseRegistrationAPI.Models;
using CourseRegistrationAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CourseRegistrationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _service;

        public CoursesController(ICourseService service)
        {
            _service = service;
        }

        // GET api/courses  -> View available courses
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        // GET api/courses/1  -> View a single course
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var course = _service.GetById(id);

            if (course == null)
                return NotFound();

            return Ok(course);
        }

        // POST api/courses  -> Register for / create a course
        [HttpPost]
        public IActionResult Register(Course course)
        {
            var created = _service.RegisterCourse(course);

            return CreatedAtAction(nameof(GetById),
                new { id = created.Id },
                created);
        }

        // PUT api/courses/1/duration  -> Update course duration
        [HttpPut("{id}/duration")]
        public IActionResult UpdateDuration(int id, UpdateDurationRequest request)
        {
            var updated = _service.UpdateDuration(id, request.Duration);

            if (updated == null)
                return NotFound();

            return Ok(updated);
        }

        // DELETE api/courses/1  -> Cancel a course
        [HttpDelete("{id}")]
        public IActionResult Cancel(int id)
        {
            bool cancelled = _service.CancelCourse(id);

            if (!cancelled)
                return NotFound();

            return Ok("Course Cancelled Successfully");
        }
    }
}