namespace MangaLibApp.Models
{
    public class UploadChapterDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PagesCount { get; set; }
        public string MangaName { get; set; }
        public string ChapterName { get; set; }
        public List<UploadPageDto> Pages { get; set; }
    }
}