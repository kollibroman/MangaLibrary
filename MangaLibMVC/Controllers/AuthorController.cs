using MangaLibApp.Interfaces.Client;
using Microsoft.AspNetCore.Mvc;

namespace MangaLibMVC.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorClientService _service;

        public AuthorController(IAuthorClientService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index([FromQuery]int pageNumber)
        {  
            var response = await _service.GetAuthorsAsync(1); 
            Console.WriteLine(response);
            return View("Index" ,response);
        }

        public async Task<IActionResult> Details([FromRoute]int id)
        {
           var response = await _service.GetAuthorAsync(id);
            return View("Details", response);
        }
        
        
    }
}