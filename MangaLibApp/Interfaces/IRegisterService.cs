using MangaLibApp.Models;

namespace MangaLibApp.Interfaces;

public interface IRegisterService
{
    Task RegisterUser(RegisterUserDto dto);
}