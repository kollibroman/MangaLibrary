using MangaLibCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace MangaLibCore
{
    public class MangaLibDbContext : DbContext
    {
        private string _connectionstring = "Server=127.0.0.1;Port=5432;Database=MangaDb;User Id=postgres;Password=Miau8888;";
        public DbSet<Manga> Mangas { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Pages> Pages { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Cover> Cover { get; set; }

        public MangaLibDbContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manga>()
                .Property(t => t.Title)
                .IsRequired();
            modelBuilder.Entity<Category>()
                .Property(n => n.Name)
                .IsRequired();
            modelBuilder.Entity<Pages>()
                .Property(p => p.PageData)
                .IsRequired();
            modelBuilder.Entity<Author>()
                .Property(n => n.Name)
                .IsRequired();
            modelBuilder.Entity<Cover>()
                .Property(d => d.Data)
                .IsRequired();
                
            modelBuilder.Seed();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseNpgsql(_connectionstring);
        }
    }
}