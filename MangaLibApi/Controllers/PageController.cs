using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using MangaLibApp.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace MangaLibApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PageController : ControllerBase
    {
        private readonly IPageService _service;
        private readonly ILogger<PageController> _logger;

        public PageController(IPageService service, ILogger<PageController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetChapterFromMangaName([FromQuery] string mangaName, CancellationToken ct)
        {
            var pages = await _service.GetAllFromManga(mangaName, ct);
            return Ok(new Response<List<PageDto>>(pages));
        }

        [HttpGet("{ChapterName}")]
        public async Task<IActionResult> GetChapterByName([FromRoute]int pageNumber, CancellationToken ct)
        {
           var page = await _service.GetByNumber(pageNumber, ct);
           
           return Ok(new Response<PageDto>(page));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChapter([FromRoute] int id, CancellationToken ct)
        {
           var isDeleted = await _service.Delete(id, ct);

           if(!isDeleted)
           {
                _logger.LogError("DUPA");
                return NotFound();
           }
           
           _logger.LogInformation("NIEDUPA");
           return NoContent();
        }
    }
}