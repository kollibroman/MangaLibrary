using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaLibrary.Api.Persistence.Models;

public class Page : BaseTrackingEntity
{
    public required int PageNumber { get; set; }
    public required byte[] PageData { get; set; }
    
    public int ChapterId { get; set; }
    public required Chapter Chapter { get; set; }
}

public class PageConfiguration : BaseTrackingEntityConfiguration<Page>
{
    public override void Configure(EntityTypeBuilder<Page> builder)
    {
        base.Configure(builder);
    }
}