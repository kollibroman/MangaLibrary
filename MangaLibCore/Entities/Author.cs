namespace MangaLibCore.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        List<Manga> WrittenMangas { get; set; }
    }
}