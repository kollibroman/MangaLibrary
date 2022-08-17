using MangaLibApp.Interfaces.Client;
using Microsoft.AspNetCore.Http;

namespace MangaLibApp.Services.Client
{
    public class UpdateClientService : IUpdateClientService
    {
        public Task<bool> UpdateChapterAsync(string MangaName, IFormFile file)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCoverAsync(string MangaName, IFormFile file)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCoverAsync(IFormFile file, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCoverAsync(int id, IFormFile file)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePageAsync(int id, IFormFile file)
        {
            throw new NotImplementedException();
        }
    }
}