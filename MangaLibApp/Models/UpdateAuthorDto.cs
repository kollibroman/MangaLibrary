using MangaLibCore.Entities;

namespace MangaLibApp.Models
{
    public class UpdateAuthorDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<Manga> WrittenMangas { get; set; }
    }
}