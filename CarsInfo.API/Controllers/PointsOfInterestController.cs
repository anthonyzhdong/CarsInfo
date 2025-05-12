using Microsoft.AspNetCore.Mvc;
using CarsInfo.API.Models;

namespace CarsInfo.API.Controllers
{
    [Route("api/cars/{carId}/pointsofinterest")]
    [ApiController]
    public class PointsOfInterestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PointOfInterestDto>> GetPointsOfInterest(int carId)
        {
            var car = CarsDataStore.Current.Cars.FirstOrDefault(c => c.Id == carId);
            if (car == null)
            {
                return NotFound();
            }
            return Ok(car.PointsOfInterest);
        }


    }
}
