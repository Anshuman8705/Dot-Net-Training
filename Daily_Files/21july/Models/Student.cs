using System.ComponentModel.DataAnnotations;

namespace _21july.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Student name is mandatory")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name should be between 3 and 20 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is mandatory")]
        [Range(18,25, ErrorMessage = "Age should be between 18 and 25")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Email is mandatory")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Course is mandatory")]
        public string Course { get; set; }
    }
}