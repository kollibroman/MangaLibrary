using MangaLibApp.Interfaces.Client;
using MangaLibApp.Models;

namespace MangaLibApp.Services.Client
{
    public class CoverClientService : ICoverClientService
    {
        public Task<CoverDto> GetCoverAsync(string Name)
        {
            throw new NotImplementedException();
        }

        public Task<List<CoverDto>> GetCoversAsync()
        {
            throw new NotImplementedException();
        }
    }
}