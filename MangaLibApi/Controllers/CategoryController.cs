using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MangaLibApi.Controllers
{
    [ApiController]
    [Route("api/category")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)        
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
            var categories = _service.GetAll();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var category = _service.GetById(id);
            return Ok(category);
        }
        
        [HttpPut("{id}")]
        public IActionResult UpdateCategory([FromRoute]int id, [FromBody] UpdateCategoryDto dto)
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

        [HttpPost]
        public IActionResult AddCategory([FromBody] CreateCategoryDto dto)
        {
            _service.Create(dto);
            return Created($"/api/category/{dto.Id}", null);       
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory([FromRoute] int id)
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