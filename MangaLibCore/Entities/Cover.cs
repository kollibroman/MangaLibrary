namespace MangaLibCore.Entities
{
    public class Cover
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public int MangaId { get; set; }
        public Manga Manga { get; set; }
    }
}