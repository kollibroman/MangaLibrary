namespace MangaLibCore.Entities
{
    public class Chapter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Pages { get; set; }
        public List<string> MangaId { get; set; }
    }
}