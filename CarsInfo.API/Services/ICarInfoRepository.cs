using CarsInfo.Api.Entities;

namespace CarsInfo.Api.Services
{
    public interface ICarInfoRepository
    {
        IEnumerable<Car> GetCars();
    }
}
