using MangaLibrary.Api.Persistence.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MangaLibrary.Api.Persistence;

public class MangaLibContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
{
    public MangaLibContext(DbContextOptions<MangaLibContext> options) : base(options)
    {
    }

    public DbSet<Author> Authors => Set<Author>();
    public DbSet<Chapter> Chapters => Set<Chapter>();
    public DbSet<Cover> Covers => Set<Cover>();
    public DbSet<Page> Pages => Set<Page>();
    public DbSet<WrittenEntity> WrittenEntities => Set<WrittenEntity>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MangaLibContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}