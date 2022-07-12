using MangaLibApp.Models;

namespace MangaLibApp.Interfaces.Client
{
    public interface IPageClientService
    {
        Task<List<PageDto>> GetAuthorsAsync();
        Task<PageDto> GetAuthorAsync(string Name);
    }
}