using System.ComponentModel.DataAnnotations;

namespace _29July_Assignment.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vehicle Name is Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Vehicle Name Must be atleast 2 letters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Vehicle Number is Required")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Vehicle Number Must be Valid")]
        public string VehicleNumber { get; set; }

        [Required(ErrorMessage = "Owner Name is Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Owner Name Must be atleast 2 letters")]
        public string OwnerName { get; set; }
    }
}