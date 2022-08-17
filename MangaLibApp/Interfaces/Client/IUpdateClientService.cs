using Microsoft.AspNetCore.Http;

namespace MangaLibApp.Interfaces.Client
{
    public interface IUpdateClientService
    {
        Task<bool> UpdateCoverAsync(string MangaName, IFormFile file);
        Task<bool> UpdateCoverAsync(IFormFile file, int id);
        Task<bool> UpdateChapterAsync(string MangaName, IFormFile file);
        Task<bool> UpdateCoverAsync(int id, IFormFile file);
        Task<bool> UpdatePageAsync(int id, IFormFile file);
    }
}