namespace MangaLibApp.Models
{
    public class ChapterDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PagesCount { get; set; }
        public List<PageDto> Pages { get; set; }
    }
}