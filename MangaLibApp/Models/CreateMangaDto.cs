using MangaLibCore.Entities;

namespace MangaLibApp.Models
{
    public class CreateMangaDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime AddedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int PagesCount { get; set; }
        public int ChaptersCount { get; set; }
        public string Description { get; set; }

        public List<string> Chapters { get; set; }
    }
}