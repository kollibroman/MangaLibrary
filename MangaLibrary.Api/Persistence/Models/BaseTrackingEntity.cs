using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaLibrary.Api.Persistence.Models;

public abstract class BaseTrackingEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;
}

public class BaseTrackingEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseTrackingEntity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasIndex(x => new { x.IsActive, x.Id } );
        builder.HasQueryFilter(x => x.IsActive);
        builder.HasIndex(x => x.CreatedAt).IsDescending();
    }
}