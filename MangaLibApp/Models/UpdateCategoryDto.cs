using MangaLibCore.Entities;

namespace MangaLibApp.Models
{
    public class UpdateCategoryDto
    {
        public string Name { get; set; }

        public List<Manga> Mangas { get; set; }
    }
}