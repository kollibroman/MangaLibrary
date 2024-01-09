using Microsoft.AspNetCore.Http;

namespace MangaLibApp.Interfaces
{
    public interface IApiConverter
    {
        Task<byte[]> ConvertToByte(IFormFile file, CancellationToken ct);
        IFormFile ConvertToFile(byte[] byteArr, string title, string fileName);
    }
}