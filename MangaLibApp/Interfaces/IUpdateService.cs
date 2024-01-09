using Microsoft.AspNetCore.Http;

namespace MangaLibApp.Interfaces
{
    public interface IUpdateService
    {
        Task UpdatePage(int id, IFormFile file, CancellationToken ct);
        Task UpdateChapter(int id, IFormFile file, CancellationToken ct);
        Task<bool> UpdateCover(int id, IFormFile file, CancellationToken ct);
    }
}