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

        [HttpGet("{id}/name")]
        public ActionResult<string> GetCarName(int id)
        {
            var carToReturn = CarsDataStore.Current.Cars.FirstOrDefault(c => c.Id == id);
            if (carToReturn == null)
            {
                return NotFound();
            }
            return Ok(carToReturn.Name);
        }

        [HttpGet("{id}/model")]
        public ActionResult<string> GetCarModel(int id)
        {
            var carToReturn = CarsDataStore.Current.Cars.FirstOrDefault(c => c.Id == id);
            if (carToReturn == null)
            {
                return NotFound();
            }
            return Ok(carToReturn.Model);
        }

        [HttpGet("{id}/variant")]
        public ActionResult<string> GetCarVariant(int id)
        {
            var carToReturn = CarsDataStore.Current.Cars.FirstOrDefault(c => c.Id == id);
            if (carToReturn == null)
            {
                return NotFound();
            }
            return Ok(carToReturn.Variant);
        }

        [HttpGet("{id}/year")]
        public ActionResult<int> GetCarYear(int id)
        {
            var carToReturn = CarsDataStore.Current.Cars.FirstOrDefault(c => c.Id == id);
            if (carToReturn == null)
            {
                return NotFound();
            }
            return Ok(carToReturn.Year);
        }



    }
}
