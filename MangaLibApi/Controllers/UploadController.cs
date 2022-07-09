using System.Reflection.Metadata.Ecma335;
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

        [HttpPost("page")]
        public async Task<IActionResult> UploadPage(IFormFile file, int pageNumber, [FromQuery]string MangaName)
        {
            await _service.UploadPageAsync(file, pageNumber, MangaName);

            _logger.LogInformation("NIEDUPA");
            return Created($"api/page/{MangaName}", null);
        }

        [HttpPost("chapter")]
        public async Task<IActionResult> UploadChapter(List<IFormFile> files, string ChapterName, string MangaName)
        {
           await _service.UploadChapterAsync(files, ChapterName, MangaName);

            _logger.LogInformation("NIEDUPA");
            return Created($"api/chapter/{ChapterName}", null);
        }

        [HttpPost("cover")]
        public async Task<IActionResult> UploadCover(IFormFile file, [FromQuery]string fileName,[FromQuery]string mangaName)
        {
           await _service.UploadCoverAsync(file, fileName,mangaName);

           _logger.LogInformation("NIEDUPA");
           return Created($"api/cover/{mangaName}", null);
        }
    }
}