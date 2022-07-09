using Microsoft.AspNetCore.Http;

namespace MangaLibApp.Interfaces
{
    public interface IUploadService
    {
       Task UploadCoverAsync(IFormFile file, string fileName,string mangaName);
       Task UploadChapterAsync(List<IFormFile> files, string chapterName, string mangaName);
       Task UploadPageAsync(IFormFile file, int pageNumber, string MangaName);
    }
}