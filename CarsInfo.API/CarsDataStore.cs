using CarsInfo.API.Models;

namespace CarsInfo.API
{
    public class CarsDataStore
    {
        public List<CarDto> Cars { get; set; }
        public static CarsDataStore Current { get; } = new CarsDataStore();

        public CarsDataStore()
        {
            Cars = new List<CarDto>()
            {
                new CarDto() { Id = 1, Name = "BMW", Model = "X5", Year = 2020 },
                new CarDto() { Id = 2, Name = "Audi", Model = "A6", Year = 2019 },
                new CarDto() { Id = 3, Name = "Mercedes", Model = "C-Class", Year = 2021 }
            };
        }
    }
}
