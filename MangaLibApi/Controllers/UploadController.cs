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
        public async Task<IActionResult> UploadPage(IFormFile file, int pageNumber, [FromQuery]string mangaName, CancellationToken ct)
        {
            await _service.UploadPageAsync(file, pageNumber, mangaName, ct);

            _logger.LogInformation("NIEDUPA");
            return Created($"api/page/{mangaName}", null);
        }

        [HttpPost("chapter")]
        public async Task<IActionResult> UploadChapter(List<IFormFile> files, [FromQuery]string chapterName, [FromQuery]string mangaName, CancellationToken ct)
        {
           await _service.UploadChapterAsync(files, chapterName, mangaName, ct);

            _logger.LogInformation("NIEDUPA");
            return Created($"api/chapter/{chapterName}", null);
        }

        [HttpPost("cover")]
        public async Task<IActionResult> UploadCover(IFormFile file, [FromQuery]string fileName,[FromQuery]string mangaName, CancellationToken ct)
        {
           await _service.UploadCoverAsync(file, fileName,mangaName, ct);

           _logger.LogInformation("NIEDUPA");
           return Created($"api/cover/{mangaName}", null);
        }
    }
}