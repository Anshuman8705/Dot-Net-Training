using System.ComponentModel.DataAnnotations;

namespace _29July.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name of Employee is Required")]
        [StringLength(30,MinimumLength =3,ErrorMessage ="Name must be at least 3 Letters")]
        public string Name { get; set; }
        [Range(8,10,ErrorMessage ="Number Must be 8 Digit or 10 Digit")]
        public long PhoneNum { get; set; }
        [Required(ErrorMessage = "Email of Employee is Required")]
        [EmailAddress(ErrorMessage ="Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Department Id of Employee is Required")]
        public int DeptId { get; set; }

    }
}
