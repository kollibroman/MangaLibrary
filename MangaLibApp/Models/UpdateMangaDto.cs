using MangaLibCore.Entities;

namespace MangaLibApp.Models
{
    public class UpdateMangaDto
    {
        public string Title { get; set; }
        public byte[] Cover { get; set; }
        public string Author { get; set; }
        public int PagesCount { get; set; }
        public int ChaptersCount { get; set; }
        public List<string> Chapters { get; set; }
    }
}