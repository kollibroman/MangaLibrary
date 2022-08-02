using MangaLibCore.Entities;
using MangaLibCore.Interfaces;

namespace MangaLibCore.Idk;

public class AbstractTag : ITaggable
{
    public AbstractTag()
    {
        Tags = new List<Tag>();
    }

    public virtual ICollection<Tag> Tags { get; set; }
}
