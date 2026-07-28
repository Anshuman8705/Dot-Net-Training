using CourseRegistrationAPI.Models;

namespace CourseRegistrationAPI.Services
{
    public class CourseService : ICourseService
    {
        private static List<Course> courses = new List<Course>()
        {
            new Course() { Id = 1, Title = "Data Structures", Credits = 4, Duration = 16 },
            new Course() { Id = 2, Title = "Computer Organization", Credits = 3, Duration = 14 },
            new Course() { Id = 3, Title = "Web Application Development", Credits = 4, Duration = 12 },
            new Course() { Id = 4, Title = "Database Management Systems", Credits = 3, Duration = 16 }
        };

        public List<Course> GetAll()
        {
            return courses;
        }

        public Course? GetById(int id)
        {
            return courses.FirstOrDefault(c => c.Id == id);
        }

        public Course RegisterCourse(Course course)
        {
            // Auto-generate the next Id, similar to how a DB identity column would behave
            course.Id = courses.Any() ? courses.Max(c => c.Id) + 1 : 1;
            courses.Add(course);
            return course;
        }

        public Course? UpdateDuration(int id, int duration)
        {
            var existing = courses.FirstOrDefault(c => c.Id == id);

            if (existing == null)
                return null;

            existing.Duration = duration;

            return existing;
        }

        public bool CancelCourse(int id)
        {
            var course = courses.FirstOrDefault(c => c.Id == id);

            if (course == null)
                return false;

            courses.Remove(course);
            return true;
        }
    }
}