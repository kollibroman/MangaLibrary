using MangaLibApp.Models;

namespace MangaLibApp.Interfaces.Client
{
    public interface IAuthorClientService
    {
        Task<List<AuthorDto>> GetAuthorsAsync();
        Task<AuthorDto> GetAuthorAsync(int id);
    }
}