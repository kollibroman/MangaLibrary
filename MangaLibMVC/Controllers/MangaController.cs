using MangaLibApp.Interfaces.Client;
using Microsoft.AspNetCore.Mvc;

namespace MangaLibMVC.Controllers
{
    public class MangaController : Controller
    {
        private readonly IMangaClientService _service;

        public MangaController(IMangaClientService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var Mangas = await _service.GetMangasAsync();

            return View("Index",Mangas);
        }
        
    }
}