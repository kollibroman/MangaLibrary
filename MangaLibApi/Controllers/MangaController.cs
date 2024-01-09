using MangaLibApp.Filter;
using MangaLibApp.Helpers;
using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using MangaLibApp.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace MangaLibApi.Controllers
{
    [ApiController]
    [Route("api/manga")]
    public class MangaController : ControllerBase
    {
        private readonly IMangaService _service;
        private readonly IUriService _uriService;

        public MangaController(IMangaService service, IUriService uriService)
        {
            _service = service;
            _uriService = uriService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMangas([FromQuery] PaginationFilter paginationFilter, CancellationToken ct)
        {
            var route = Request.Path.Value;
            
            if (route is null)
            {
                return BadRequest();
            }
            var validFilter = new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize);

            var mangas = await _service.GetAll(validFilter, ct);
            var mangaCount = await _service.GetTotalRecords(ct);

             var pagedResponse = PaginationHelper.CreatePagedReponse(mangas, validFilter, mangaCount, _uriService, route);
            return Ok(pagedResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMangaByName([FromRoute]int id, CancellationToken ct)
        {
            var manga = await _service.GetById(id, ct);

            return Ok(new Response<MangaDto>(manga));
        }

        // [HttpGet("tags")]
        // public async Task<IActionResult> GetTags()
        // {
        //     var Tags = await _tagService.GetTagsAsync();

        //     return Ok(new Response<TagDto>());
        // }
        
        //TODO: w serwisie zrobic wyszukanie mangi i dorzucic do niej tagi
        // [HttpPut("tag/{mangaId}")]
        // public async Task<IActionResult> Tag([FromRoute] int id, [FromBody] string TagName)
        // {
        //     
        // }
        //TODO: to samo co wyzej ale odtagowanie     
        // [HttpPut("untag/{id}")]
        // public async Task<IActionResult> UnTag()
        // {
        //     
        // }
        

        [HttpPost]
        public async Task<IActionResult> CreateManga([FromBody] CreateMangaDto dto, CancellationToken ct)
        {
            await _service.Create(dto, ct);
            return Created($"api/manga/title/{dto.Title}", null);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateManga([FromRoute]int id, [FromBody] UpdateMangaDto dto, CancellationToken ct)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            var isUpdated = await _service.Update(id, dto, ct);

            if(!isUpdated)
            {
                return NotFound("DUPA");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteManga([FromRoute] int id, CancellationToken ct)
        {
            var isDeleted = await _service.Delete(id, ct);

            if(isDeleted)
            {
                return NoContent();
            }

            return NotFound();
        }
    }
}