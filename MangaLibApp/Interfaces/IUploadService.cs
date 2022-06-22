using Microsoft.AspNetCore.Http;

namespace MangaLibApp.Interfaces
{
    public interface IUploadService
    {
       Task UploadCoverAsync(IFormFile file, string mangaName);
       Task UploadChapterAsync(IFormFile file, string mangaName);
       Task UploadPageAsync(IFormFile file, string mangaName);
    }
}