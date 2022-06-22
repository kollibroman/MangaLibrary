using MangaLibApp.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MangaLibApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UploadController : ControllerBase
    {
        private readonly IUploadService _service;
        private readonly ILogger<UploadController> _logger;

        public UploadController(IUploadService service, ILogger<UploadController> logger)
        {
            _service = service;
            _logger = logger;
        }

        // [HttpPost]
        // public async Task<IActionResult> UploadPage()
        // {
            
        // }

        // [HttpPost]
        // public async Task<IActionResult> UploadChapter()
        // {
           
        // }

        [HttpPost("cover")]
        public async Task<IActionResult> UploadCover(IFormFile file, string mangaName)
        {
           await _service.UploadCoverAsync(file, mangaName);

           _logger.LogInformation("NIEDUPA");
           return Created($"api/cover/{mangaName}", null);
        }
    }
}