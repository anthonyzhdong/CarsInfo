using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarsInfo.Api.Entities
{
    public class PointOfInterest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // new Key generated once a new car is created
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; } = string.Empty;

        [ForeignKey("CarId")]
        public Car? Car { get; set; }
        //foreign key

        public int CarId { get; set; }

        public PointOfInterest(string name)
        {
            Name = name;
        }
    }
}
