using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarsInfo.API.Models;

namespace CarsInfo.Api.Entities
{
    public class Car
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // new Key generated once a new car is created
        public int Id { get; set; }

        public string Company { get; set; } = string.Empty;
        public string Name { get; set; }
        public string Model { get; set; } = string.Empty;
        public string Variant { get; set; } = string.Empty;
        public int Year { get; set; }
        public string ImageUrl { get; set; } = string.Empty;

        public int NumberOfPointsOfInterest
        {
            get
            {
                return PointsOfInterest.Count;
            }
        }
        public ICollection<PointOfInterest> PointsOfInterest { get; set; } = new List<PointOfInterest>();

        public Car(string name)
        {
            Name = name;
        }
    }
}
