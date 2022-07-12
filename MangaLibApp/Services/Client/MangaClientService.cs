using MangaLibApp.Interfaces.Client;
using MangaLibApp.Models;

namespace MangaLibApp.Services.Client
{
    public class MangaClientService : IMangaClientService
    {
        public Task<MangaDto> GetMangaAsync(string Name)
        {
            throw new NotImplementedException();
        }

        public Task<List<MangaDto>> GetMangasAsync()
        {
            throw new NotImplementedException();
        }
    }
}