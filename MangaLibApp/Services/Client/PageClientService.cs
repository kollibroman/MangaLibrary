using MangaLibApp.Interfaces.Client;
using MangaLibApp.Models;

namespace MangaLibApp.Services.Client
{
    public class PageClientService : IPageClientService
    {
        public Task<PageDto> GetAuthorAsync(string Name)
        {
            throw new NotImplementedException();
        }

        public Task<List<PageDto>> GetAuthorsAsync()
        {
            throw new NotImplementedException();
        }
    }
}