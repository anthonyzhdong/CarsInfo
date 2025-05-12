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
    

    [HttpPost]
        public async Task<ActionResult> CreateFile(IFormFile file)
        {
            if (file.Length == 0 || file.Length > 20971520)
            {
                return BadRequest("No file or an invalid one has been inputted");
            }
            var path = Path.Combine(Directory.GetCurrentDirectory(),$"uploaded_file_{Guid.NewGuid()}.jpeg");
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return Ok("File uploaded successfully");

        }
    }
}
