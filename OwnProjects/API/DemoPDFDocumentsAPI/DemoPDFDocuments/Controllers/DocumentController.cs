using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoPDFDocuments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {

        private readonly IWebHostEnvironment _appEnvironment;

        public DocumentController(IWebHostEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }
        // GET: api/<DocumentController>
        [HttpGet("files")]
        public async Task<ActionResult> DownloadFile()
        {
            
            var filePath = @$"{_appEnvironment.WebRootPath}/Files/arbol.jpg"; 

            var provider = new FileExtensionContentTypeProvider();
            if (!provider.TryGetContentType(filePath, out var contentType))
            {
                contentType = "application/octet-stream";
            }

            var bytes = await System.IO.File.ReadAllBytesAsync(filePath);
            return File(bytes, contentType, Path.GetFileName(filePath));
        }


        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
