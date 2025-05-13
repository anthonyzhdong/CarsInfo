using CarsInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarsInfo.API.Controllers
{
    [ApiController]
    [Route("api/cars")]
    public class CarsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<CarDto>> GetCars()
        {
            return Ok(CarsDataStore.Current.Cars);

        }

        [HttpGet("{id}")]
        public ActionResult<CarDto> GetCar(int id)
        {
            var carToReturn = CarsDataStore.Current.Cars.FirstOrDefault(c => c.Id == id);

            if (carToReturn == null) 
            {
                return NotFound();
            }

            return Ok(carToReturn);
        }

        [HttpGet("{id}/company")]
        public ActionResult<string> GetCarCompany(int id)
        {
            var carToReturn = CarsDataStore.Current.Cars.FirstOrDefault(c => c.Id == id);
            if (carToReturn == null)
            {
                return NotFound();
            }
            return Ok(carToReturn.Company);
        }

    }
}
