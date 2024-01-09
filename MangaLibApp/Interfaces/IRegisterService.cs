using MangaLibApp.Models;

namespace MangaLibApp.Interfaces;

public interface IRegisterService
{
    Task RegisterUser(RegisterUserDto dto, CancellationToken ct);
    Task<string> GenerateKJwt(LoginDto dto, CancellationToken ct);
}