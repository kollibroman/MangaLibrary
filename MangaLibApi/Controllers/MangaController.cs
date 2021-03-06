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
        public async Task<IActionResult> GetAllMangas([FromQuery] PaginationFilter paginationFilter)
        {
            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize);

            var mangas = await _service.GetAll(validFilter);
            var MangaCount = await _service.GetTotalRecords();

             var pagedResponse = PaginationHelper.CreatePagedReponse<MangaDto>(mangas, validFilter, MangaCount, _uriService, route);
            return Ok(pagedResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMangaByName([FromRoute]int id)
        {
            var manga = await _service.GetById(id);

            if(manga is null)
            {
                return NotFound();
            }

            return Ok(new Response<MangaDto>(manga));
        }

        [HttpPost]
        public async Task<IActionResult> CreateManga([FromBody] CreateMangaDto dto)
        {
            await _service.Create(dto);
            return Created($"api/manga/{dto.Id}", null);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActionName([FromRoute]int id, [FromBody] UpdateMangaDto dto)
        {
          if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            var isUpdated = await _service.Update(id, dto);

            if(!isUpdated)
            {
                return NotFound("DUPA");
            }

            return Ok("Niedupa");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteManga([FromRoute] int id)
        {
            var isDeleted = await _service.Delete(id);

            if(isDeleted)
            {
                return NoContent();
            }

            return NotFound();
        }
        
    }
}