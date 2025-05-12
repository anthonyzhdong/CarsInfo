using System.ComponentModel.DataAnnotations;

namespace CarsInfo.Api.Models
 
{
    public class PointOfInterestForCreationDto
    {
        [Required(ErrorMessage = "You should provide a name value")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(10)]
        public string? Description { get; set; } = string.Empty;
    }
}
