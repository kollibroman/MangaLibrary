namespace MangaLibApp.Models
{
    public class UploadChapterDto
    {
        public string Name { get; set; }
        public int PagesCount { get; set; }
        public List<PageDto> Pages { get; set; }
    }
}