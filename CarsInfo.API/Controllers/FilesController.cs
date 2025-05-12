using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace CarsInfo.Api.Controllers
{
    [Route("api/files")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        [HttpGet("{fileId}")]
        public ActionResult GetFile(string fileId)
        {

            var pathToFile = "porsche.jpg";

            if (!System.IO.File.Exists(pathToFile))

            {
                return NotFound();
            }

            var bytes = System.IO.File.ReadAllBytes(pathToFile);
            return File(bytes, "image/jpeg", Path.GetFileName(pathToFile));
        }
    }
}
