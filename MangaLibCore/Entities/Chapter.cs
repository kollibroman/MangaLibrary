using System.ComponentModel.DataAnnotations.Schema;
using MangaLibCore.Enums;

namespace MangaLibCore.Entities
{
    public class Chapter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int PagesCount { get; set; }
        public int ChapterIndex { get; set; }
        public EntityType Type { get; set; }
        public string MangaName { get; set; }
        public string ChapterName { get; set; }
        public List<Page> Pages { get; set; }
    }
}