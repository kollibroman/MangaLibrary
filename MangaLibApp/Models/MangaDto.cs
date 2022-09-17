using MangaLibCore.Entities;

namespace MangaLibApp.Models
{
    public class MangaDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime AddedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int PagesCount { get; set; }
        public int ChaptersCount { get; set; }
        public string Description { get; set; }

        public CoverDto Cover { get; set; }
    }
}