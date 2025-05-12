using Microsoft.AspNetCore.Mvc;
using CarsInfo.API.Models;
using CarsInfo.Api.Models;

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

        [HttpGet("{pointOfInterestId}", Name = "GetPointOfInterest")]
        public ActionResult<PointOfInterestDto> GetPointOfInterest(int carId, int pointOfInterestId)
        {
            var car = CarsDataStore.Current.Cars.FirstOrDefault(c => c.Id == carId);
            if (car == null)
            {
                return NotFound();
            }
            var pointOfInterest = car.PointsOfInterest.FirstOrDefault(p => p.Id == pointOfInterestId);
            if (pointOfInterest == null)
            {
                return NotFound();
            }
            return Ok(pointOfInterest);
        }

        [HttpPost]
        public ActionResult<PointOfInterestDto> CreatePointOfInterest(int carId, [FromBody] PointOfInterestForCreationDto pointOfInterest)
        {

            var car = CarsDataStore.Current.Cars.FirstOrDefault(c => c.Id == carId);
            if (car == null)
            {
                return NotFound();
            }
            var maxPointOfInterestId = CarsDataStore.Current.Cars.SelectMany(c => c.PointsOfInterest).Max(p => p.Id);

            var newPointOfInterest = new PointOfInterestDto()
            {
                Id = ++maxPointOfInterestId,
                Name = pointOfInterest.Name,
                Description = pointOfInterest.Description
            };

            car.PointsOfInterest.Add(newPointOfInterest);

            return CreatedAtRoute("GetPointOfInterest", new { carId = carId, pointOfInterestId = newPointOfInterest.Id }, newPointOfInterest);


        }
        // id of point of interest
        [HttpPut("{pointOfInterestId}")]
        public ActionResult UpdatePointOfInterest(int carId, int pointOfInterestId, PointoFInterestForUpdateDto pointOfInterest)
        {
            var car = CarsDataStore.Current.Cars.FirstOrDefault(c => c.Id == carId);
            if (car == null)
            {
                return NotFound();
            }

            var pointOfInterestFromStore = car.PointsOfInterest.FirstOrDefault(p => p.Id == pointOfInterestId);
            if (pointOfInterestFromStore == null)
            {
                return NotFound();
            }

            pointOfInterestFromStore.Name = pointOfInterest.Name;
            pointOfInterestFromStore.Description = pointOfInterest.Description;
            return NoContent();

        }



    }
}
