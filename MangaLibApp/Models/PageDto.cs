namespace MangaLibApp.Models
{
    public class PageDto
    {
        public int Id { get; set; }
        public int PageNumber { get; set; }
        public string PageTitle { get; set; }
        public byte[] PageData { get; set; }
    }
}