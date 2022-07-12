using MangaLibApp.Models;

namespace MangaLibApp.Interfaces.Client
{
    public interface IMangaClientService
    {
        Task<List<MangaDto>> GetMangasAsync();
        Task<MangaDto> GetMangaAsync(string Name);  
    }
}