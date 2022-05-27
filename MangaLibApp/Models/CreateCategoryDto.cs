using MangaLibCore.Entities;

namespace MangaLibApp.Models
{
    public class CreateCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<Manga> Mangas { get; set; }
    }
}