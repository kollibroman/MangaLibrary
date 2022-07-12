using MangaLibApp.Models;

namespace MangaLibApp.Interfaces.Client
{
    public interface ICoverClientService
    {
        Task<List<CoverDto>> GetCoversAsync();
        Task<CoverDto> GetCoverAsync(string Name);
    }
}