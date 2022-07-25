namespace MangaLibCore.Entities
{
    public class Tag
    {
        public int TagId { get; set; }
        public string TagName { get; set; }

        public ICollection<Manga> Mangas { get; set; }
    }
}