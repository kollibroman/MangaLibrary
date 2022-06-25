using MangaLibApp.Filter;
using MangaLibApp.Helpers;
using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using MangaLibApp.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace MangaLibApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoverController : ControllerBase
    {
        private readonly ICoverService _service;
        private readonly IUriService _uriService;

        public CoverController(ICoverService service, IUriService uriService)
        {
            _service = service;
            _uriService = uriService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery]PaginationFilter paginationFilter)
        {
            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize);

            var covers = await _service.GetAll(validFilter);
            var authorsCount = await _service.GetTotalRecords();

            var pagedResponse = PaginationHelper.CreatePagedReponse<CoverDto>(covers, validFilter, authorsCount, _uriService, route);
            return Ok(pagedResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute]int id)
        {
           var cover = await _service.GetById(id);

            if(cover is null)
            {
                return NotFound();
            }

           return Ok(new Response<CoverDto>(cover));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCover([FromRoute] int id, IFormFile file)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("You are retarded!");
            }
            var isUpdated = await _service.Update(id, file);

            if(!isUpdated)
            {
                return NotFound("DUPA");
            }
            return Ok("Niedupa");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCover([FromRoute] int id)
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