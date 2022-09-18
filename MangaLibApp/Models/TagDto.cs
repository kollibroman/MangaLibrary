namespace MangaLibApp.Models
{
    public class TagDto
    {
        public int TagId { get; set; }
        public string TagName { get; set; }

        public virtual List<MangaDto> Mangas { get; set; }
    }
}