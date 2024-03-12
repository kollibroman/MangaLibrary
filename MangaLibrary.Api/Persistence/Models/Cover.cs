using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaLibrary.Api.Persistence.Models;

public class Cover : BaseTrackingEntity
{
    public required string Name { get; set; }
    public required byte[] Data { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    
    public int WrittenEntityId { get; set; }
    public required WrittenEntity WrittenEntity { get; set; }
}

public class CoverConfiguration : BaseTrackingEntityConfiguration<Cover>
{
    public override void Configure(EntityTypeBuilder<Cover> builder)
    {
        base.Configure(builder);
    }
}