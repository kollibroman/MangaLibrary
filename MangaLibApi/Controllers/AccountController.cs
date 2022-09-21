using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MangaLibApi.Controllers;

[Route("api/account")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly IRegisterService _service;
    private readonly IAccountService _accountService;

    public AccountController(IRegisterService service, IAccountService accountService)
    {
        _service = service;
        _accountService = accountService;
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

    [HttpGet("{UserName}")]
    public async Task<IActionResult> GetUserInfo([FromRoute] string UserName)
    {
        var accountInfo = await _accountService.GetUserDetails(UserName);
        return Ok(accountInfo);
    }
}