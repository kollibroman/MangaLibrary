using MangaLibApp.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MangaLibApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UpdateController : ControllerBase
    {
        private readonly IUpdateService _service;
        public UpdateController(IUpdateService service)
        {
            _service = service;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCover([FromRoute] int id, IFormFile file)
        {
            var isUpdated = await _service.UpdateCover(id, file);

            if(!isUpdated)
            {
                return NotFound();
            }

            return NoContent();
        }
        
    }
}