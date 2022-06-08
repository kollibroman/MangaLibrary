using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MangaLibApi.Controllers
{
    [ApiController]
    [Route("api/manga")]
    public class MangaController : ControllerBase
    {
        private readonly IMangaService _service;

        public MangaController(IMangaService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllMangas()
        {
            var mangas = _service.GetAll();
            return Ok(mangas);
        }

        [HttpGet("{id}")]
        public IActionResult GetMangaById([FromRoute]int id)
        {
            var manga = _service.GetById(id);
            return Ok(manga);
        }

        [HttpPost]
        public IActionResult CreateManga([FromBody] CreateMangaDto dto)
        {
            _service.Create(dto);
            return Created($"api/manga/{dto.Id}", null);
        }

        [HttpPut("{id}")]
        public IActionResult ActionName([FromRoute]int id, [FromBody] UpdateMangaDto dto)
        {
          if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            var isUpdated = _service.Update(id, dto);

            if(!isUpdated)
            {
                return NotFound("DUPA");
            }

            return Ok("Niedupa");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteManga([FromRoute] int id)
        {
            var isDeleted = _service.Delete(id);

            if(isDeleted)
            {
                return NoContent();
            }

            return NotFound();
        }
        
    }
}