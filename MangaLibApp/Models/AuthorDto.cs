using MangaLibCore.Entities;

namespace MangaLibApp.Models
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<Manga> WrittenMangas { get; set; }
    }
}