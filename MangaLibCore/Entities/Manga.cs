namespace MangaLibCore.Entities
{
    public class Manga
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public byte[] Cover { get; set; }
        public DateTime AddedAt { get; set; }
        public string Author { get; set; }
        public int PagesCount { get; set; }
        public int Chapters { get; set; }
        public virtual List<Pages> Pages { get; set; }
    }
}