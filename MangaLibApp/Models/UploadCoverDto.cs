namespace MangaLibApp.Models
{
    public class UploadCoverDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public string MangaName { get; set; }
    }
}