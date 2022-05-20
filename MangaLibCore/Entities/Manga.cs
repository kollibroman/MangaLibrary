namespace MangaLibCore.Entities
{
    public class Manga
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public byte[] Cover { get; set; }
        public DateTime AddedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Author { get; set; }
        public int PagesCount { get; set; }
        public int ChaptersCount { get; set; }

        public Category Category { get; set; }
        public List<Chapter> Chapters { get; set; }
    }
}