using MangaLibApp.Models;

namespace MangaLibApp.Interfaces;

public interface IAccountService
{
    public Task<AccountDto> GetUserDetails(string UserName);
}