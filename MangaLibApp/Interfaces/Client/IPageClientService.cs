using MangaLibApp.Models;

namespace MangaLibApp.Interfaces.Client
{
    public interface IPageClientService
    {
        Task<List<PageDto>> GetPagesAsync();
        Task<PageDto> GetPageAsync(int id);
    }
}