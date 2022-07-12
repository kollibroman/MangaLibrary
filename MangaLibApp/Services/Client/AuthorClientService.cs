using MangaLibApp.Interfaces.Client;
using MangaLibApp.Models;

namespace MangaLibApp.Services.Client
{
    public class AuthorClientService : IAuthorClientService
    {
        public Task<AuthorDto> GetAuthorAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<AuthorDto>> GetAuthorsAsync()
        {
            throw new NotImplementedException();
        }
    }
}