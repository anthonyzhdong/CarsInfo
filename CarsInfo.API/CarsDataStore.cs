using CarsInfo.API.Models;

namespace CarsInfo.API
{
    public class PorscheDataStore
    {
        public List<CarDto> Cars { get; set; }
        public static PorscheDataStore Current { get; } = new PorscheDataStore();

        public PorscheDataStore()
        {
            Cars = new List<CarDto>()
            {
                new CarDto()
                {
                    Id = 1,
                    Company = "Porsche",
                    Name = "911",
                    Model = "Carrera",
                    Variant = "S",
                    Year = 2023,
                    ImageUrl = "",
                    PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto(){ Id = 1, Name = "Flat-Six Engine", Description = "Twin-turbo 3.0L engine" },
                        new PointOfInterestDto(){ Id = 2, Name = "PDK Transmission", Description = "Dual-clutch automatic" }
                    }
                },
                new CarDto()
                {
                    Id = 2,
                    Company = "Porsche",
                    Name = "Taycan",
                    Model = "Turbo",
                    Variant = "S",
                    Year = 2023,
                    ImageUrl = "",
                    PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto(){ Id = 3, Name = "Electric Motors", Description = "Dual motor setup" },
                        new PointOfInterestDto(){ Id = 4, Name = "800V System", Description = "High-voltage battery" }
                    }
                },
                new CarDto()
                {
                    Id = 3,
                    Company = "Porsche",
                    Name = "Cayenne",
                    Model = "GTS",
                    Variant = "Coupe",
                    Year = 2024,
                    ImageUrl = "",
                    PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto(){ Id = 5, Name = "V8 Engine", Description = "Twin-turbo power" },
                        new PointOfInterestDto(){ Id = 6, Name = "Air Suspension", Description = "Adaptive system" }
                    }
                },
                new CarDto()
                {
                    Id = 4,
                    Company = "Porsche",
                    Name = "718",
                    Model = "Cayman",
                    Variant = "GT4 RS",
                    Year = 2023,
                    ImageUrl = "",
                    PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto(){ Id = 7, Name = "Flat-Six Engine", Description = "Naturally aspirated" },
                        new PointOfInterestDto(){ Id = 8, Name = "Track-Focused", Description = "Aerodynamic design" }
                    }
                },
                new CarDto()
                {
                    Id = 5,
                    Company = "Porsche",
                    Name = "Macan",
                    Model = "Electric",
                    Variant = "Turbo",
                    Year = 2024,
                    ImageUrl = "",
                    PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto(){ Id = 9, Name = "PPE Platform", Description = "Electric architecture" },
                        new PointOfInterestDto(){ Id = 10, Name = "Fast Charging", Description = "270kW capability" }
                    }
                }
            };
        }
    }
}