using MangaLibApp.Filter;
using MangaLibApp.Helpers;
using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using MangaLibApp.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace MangaLibApi.Controllers
{
    [ApiController]
    [Route("api/category")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;
        private readonly IUriService _uriService;

        public CategoryController(ICategoryService service, IUriService uriService)        
        {
            _service = service;
            _uriService = uriService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories([FromQuery] PaginationFilter paginationFilter)
        {
            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize);

            var categories = await _service.GetAll(validFilter);
            var categoriesCount = await _service.GetTotalRecords();

             var pagedResponse = PaginationHelper.CreatePagedReponse<CategoryDto>(categories, validFilter, categoriesCount, _uriService, route);
            return Ok(pagedResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var category = await _service.GetById(id);

            if(category is null)
            {
                return NotFound();
            }

            return Ok(new Response<CategoryDto>(category));
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory([FromRoute]int id, [FromBody] UpdateCategoryDto dto)
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

        [HttpPost]
        public async Task<IActionResult> AddCategory([FromBody] CreateCategoryDto dto)
        {
            await _service.Create(dto);
            return Created($"/api/category/{dto.Id}", null);       
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory([FromRoute] int id)
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