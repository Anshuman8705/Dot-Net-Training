using System.ComponentModel.DataAnnotations;

namespace CourseRegistrationAPI.Models
{
    // Small DTO so the "update duration" endpoint only accepts what it needs,
    // instead of requiring the whole Course object in the request body.
    public class UpdateDurationRequest
    {
        [Required(ErrorMessage = "Duration is Required")]
        [Range(1, 52, ErrorMessage = "Duration (in weeks) must be between 1 and 52")]
        public int Duration { get; set; }
    }
}