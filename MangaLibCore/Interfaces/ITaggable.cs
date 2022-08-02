using MangaLibCore.Entities;

namespace MangaLibCore.Interfaces
{
    public interface ITaggable
    {
        ICollection<Tag> Tags { get; set; }
    }
}