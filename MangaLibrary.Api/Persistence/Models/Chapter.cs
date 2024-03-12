using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaLibrary.Api.Persistence.Models;

public class Chapter : BaseTrackingEntity
{
    public required string Name { get; set; }
    public required int PagesCount { get; set; }
    public required int ChapterIndex { get; set; }
    
    public int WrittenEntityId { get; set; }
    public required WrittenEntity WrittenEntity { get; set; }
    
    public List<Page>? Pages { get; set; }
}

public class ChapterConfiguration : BaseTrackingEntityConfiguration<Chapter>
{
    public override void Configure(EntityTypeBuilder<Chapter> builder)
    {
        base.Configure(builder);
    }
}