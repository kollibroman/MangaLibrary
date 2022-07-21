using MangaLibApp.Models;

namespace MangaLibApp.Interfaces.Client
{
    public interface IAuthorClientService
    {
        Task<IList<AuthorViewModel>> GetAuthorsAsync(int pageNumber);
        Task<AuthorViewModel> GetAuthorAsync(int id);
    }
}