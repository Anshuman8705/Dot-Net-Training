using CourseRegistrationAPI.Models;

namespace CourseRegistrationAPI.Services
{
    public interface ICourseService
    {
        List<Course> GetAll();

        Course? GetById(int id);

        Course RegisterCourse(Course course);

        Course? UpdateDuration(int id, int duration);

        bool CancelCourse(int id);
    }
}