using MangaLibApp.Interfaces;
using Microsoft.AspNetCore.Http;

namespace MangaLibApp.Helpers
{
    public class ApiConverter : IApiConverter
    {
        public async Task<byte[]> ConvertToByte(IFormFile file, CancellationToken ct)
        {
            MemoryStream ms = new();
            await file.CopyToAsync(ms, ct);
            var byteArr = ms.ToArray();

            await ms.DisposeAsync();
            ms.Close();

            return byteArr;
        }

        public IFormFile ConvertToFile(byte[] byteArr, string title, string fileName)
        {
            var stream = new MemoryStream(byteArr);

            IFormFile file = new FormFile(stream, 0, byteArr.Length, title, fileName);

            return file;
        }
    }
}