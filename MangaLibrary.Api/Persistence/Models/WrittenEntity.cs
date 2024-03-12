using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaLibrary.Api.Persistence.Models;

public class WrittenEntity : BaseTrackingEntity
{
    public string Title { get; set; }
    public string PublishedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string Description { get; set; }
    public int ChaptersCount { get; set; }

    public required Author Author { get; set; }
    
    public List<Chapter>? Chapters { get; set; }
}

public class MangaConfiguration : BaseTrackingEntityConfiguration<WrittenEntity>
{
    public override void Configure(EntityTypeBuilder<WrittenEntity> builder)
    {
        base.Configure(builder);
    }
}