namespace MangaLibCore.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<Manga> WrittenMangas { get; set; }
    }
}