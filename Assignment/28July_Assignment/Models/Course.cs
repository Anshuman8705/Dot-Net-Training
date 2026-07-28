using System.ComponentModel.DataAnnotations;

namespace CourseRegistrationAPI.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Course Title is Required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Course Title must be between 3 and 100 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Credits are Required")]
        [Range(1, 10, ErrorMessage = "Credits must be between 1 and 10")]
        public int Credits { get; set; }

        [Required(ErrorMessage = "Duration is Required")]
        [Range(1, 52, ErrorMessage = "Duration (in weeks) must be between 1 and 52")]
        public int Duration { get; set; }
    }
}