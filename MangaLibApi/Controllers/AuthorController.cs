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
        public async Task<IActionResult> GetAuthors([FromQuery] PaginationFilter paginationFilter)
        {
            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize);

            var authors = await _service.GetAll(validFilter);
            var authorsCount = await _service.GetTotalRecords();

            var pagedResponse = PaginationHelper.CreatePagedReponse<AuthorDto>(authors, validFilter, authorsCount, _uriService, route);
            return Ok(pagedResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthorById([FromRoute] int id)
        {
            var author = await _service.GetById(id);

            if(author is null)
            {
                return NotFound();
            }

            return Ok(new Response<AuthorDto>(author));
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateAuthor([FromBody] CreateAuthorDto dto)
        {
            await _service.Create(dto);
            return Created($"/api/author/name/{dto.Name}", null);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAuthor([FromRoute] int id, [FromBody] UpdateAuthorDto dto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("You are retarded!");
            }
            var isUpdated = await _service.Update(id, dto);

            if(!isUpdated)
            {
                return NotFound("DUPA");
            }
            return Ok("Niedupa");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor([FromRoute] int id)
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