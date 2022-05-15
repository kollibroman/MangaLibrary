namespace MangaLibCore.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        List<Manga> Mangas { get; set; }
    }
}