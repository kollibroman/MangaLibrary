using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaLibrary.Api.Persistence.Models;

public class Author : BaseTrackingEntity
{
    public required string Name { get; set; }
    public required string Surname { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    
    public List<WrittenEntity>? WrittenEntities { get; set; }
}

public class AuthorConfiguration : BaseTrackingEntityConfiguration<Author>
{
    public override void Configure(EntityTypeBuilder<Author> builder)
    {
        base.Configure(builder);
    }
}