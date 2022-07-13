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

        public async Task<IActionResult> Index()
        {  
            var response = await _service.GetAuthorsAsync(); 
        
            return View(response);
        }

        public async Task<IActionResult> SearchedAuthor([FromServices]int id)
        {
           var response = await _service.GetAuthorAsync(id);
            return View();
        }
        
    }
}