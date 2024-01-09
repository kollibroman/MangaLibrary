using Microsoft.AspNetCore.Http;

namespace MangaLibApp.Interfaces
{
    public interface IUploadService
    {
       Task UploadCoverAsync(IFormFile file, string fileName,string mangaName, CancellationToken ct);
       Task UploadChapterAsync(List<IFormFile> files, string chapterName, string mangaName, CancellationToken ct);
       Task UploadPageAsync(IFormFile file, int pageNumber, string mangaName, CancellationToken ct);
    }
}