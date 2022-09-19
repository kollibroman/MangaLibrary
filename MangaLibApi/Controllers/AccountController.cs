using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MangaLibApi.Controllers;

[Route("api/account")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly IRegisterService _service;

    public AccountController(IRegisterService service)
    {
        _service = service;
    }
    [HttpPost("register")]
    public async Task<ActionResult> RegisterUser([FromBody] RegisterUserDto dto)
    {
        await _service.RegisterUser(dto);
        return Ok();
    }

    [HttpPost("login")]
    public async Task<ActionResult> LoginUser([FromBody] LoginDto dto)
    {
        string token = await _service.GenerateKJwt(dto);
        return Ok(token); 
    }
}