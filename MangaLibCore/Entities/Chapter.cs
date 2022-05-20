namespace MangaLibCore.Entities
{
    public class Chapter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PagesCount { get; set; }

        public Manga Manga { get; set; }
        public List<Pages> Pages { get; set; }
    }
}