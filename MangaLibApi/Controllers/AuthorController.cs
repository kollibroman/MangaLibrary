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
        public async Task<IActionResult> GetAuthors([FromQuery] PaginationFilter paginationFilter, CancellationToken ct)
        {
            var route = Request.Path.Value;

            if (route is null)
            {
                return BadRequest();
            }
            
            var validFilter = new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize);

            var authors = await _service.GetAll(validFilter, ct);
            var authorsCount= await _service.GetTotalRecords(ct);

            var pagedResponse = PaginationHelper.CreatePagedReponse(authors, validFilter, authorsCount, _uriService, route);
            return Ok(pagedResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthorById([FromRoute] int id, CancellationToken ct)
        {
            var author = await _service.GetById(id, ct);

            return Ok(new Response<AuthorDto>(author));
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateAuthor([FromBody] CreateAuthorDto dto, CancellationToken ct)
        {
            await _service.Create(dto, ct);
            return Created($"/api/author/name/{dto.Name}", null);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAuthor([FromRoute] int id, [FromBody] UpdateAuthorDto dto, CancellationToken ct)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("You are retarded!");
            }
            var isUpdated = await _service.Update(id, dto, ct);

            if(!isUpdated)
            {
                return NotFound("DUPA");
            }
            return Ok("Niedupa");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor([FromRoute] int id, CancellationToken ct)
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