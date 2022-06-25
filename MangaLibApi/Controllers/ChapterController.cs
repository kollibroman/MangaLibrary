using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using MangaLibApp.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace MangaLibApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChapterController : ControllerBase
    {
        private readonly IChapterService _service;
        private readonly ILogger<ChapterController> _logger;

        public ChapterController(IChapterService service, ILogger<ChapterController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetChapterFromMangaName([FromQuery] string MangaName)
        {
            var chapters = await _service.GetAllFromManga(MangaName);
            return Ok(new Response<List<ChapterDto>>(chapters));
        }

        [HttpGet("{ChapterName}")]
        public async Task<IActionResult> GetChapterByName([FromRoute]string ChapterName)
        {
           var chapter = await _service.GetByName(ChapterName);
           
           if(chapter is null)
           {
                return NotFound();
           }

           return Ok(new Response<ChapterDto>(chapter));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChapter([FromRoute] int id)
        {
           var isDeleted = await _service.Delete(id);

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