using MangaLibApp.Filter;
using MangaLibApp.Helpers;
using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using MangaLibApp.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace MangaLibApi.Controllers
{
    [ApiController]
    [Route("api/author")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _service;
        private readonly IUriService _uriService;

        public AuthorController(IAuthorService service, IUriService uriService)
        {
            _service = service;
            _uriService = uriService;
        }

        [HttpGet]
        public IActionResult GetAuthors([FromQuery] PaginationFilter paginationFilter)
        {
            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize);

            var authors = _service.GetAll(validFilter);
            var authorsCount = _service.GetTotalRecords();

            var pagedResponse = PaginationHelper.CreatePagedReponse<AuthorDto>(authors, validFilter, authorsCount, _uriService, route);
            return Ok(pagedResponse);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthorById([FromRoute] int id)
        {
            var author = _service.GetById(id);

            if(author is null)
            {
                return NotFound();
            }

            return Ok(new Response<AuthorDto>(author));
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
                return BadRequest("You are retarded!");
            }
            var isUpdated = _service.Update(id, dto);

            if(!isUpdated)
            {
                return NotFound("DUPA");
            }
            return Ok("Niedupa");
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