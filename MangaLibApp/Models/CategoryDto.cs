using MangaLibCore.Entities;

namespace MangaLibApp.Models
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<string> Mangas { get; set; }
    }
}