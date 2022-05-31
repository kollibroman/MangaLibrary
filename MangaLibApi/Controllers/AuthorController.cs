using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MangaLibApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _service;

        public AuthorController(IAuthorService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors = _service.GetAll();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthorById([FromRoute] int id)
        {
            var author = _service.GetById(id);
            return Ok(author);
        }
        
        [HttpPost]
        public IActionResult CreateAuthor([FromBody] CreateAuthorDto dto)
        {
            _service.Create(dto);
            return Created($"/api/author/{dto.Id}", null);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAuthor([FromRoute] int id, [FromBody] UpdateAuthorDto dto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("You are retarded!, bad id in request");
            }
            var isUpdated = _service.Update(id, dto);

            if(!isUpdated)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAuthor([FromRoute] int id)
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