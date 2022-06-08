using MangaLibCore.Enums;
using MangaLibCore.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace MangaLibCore
{
    public static class DbSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
            .Property(m => m.Mangas)
            .HasConversion(
                listOfStringNames => JsonConvert.SerializeObject(listOfStringNames),
                namesJsonRepresentation => JsonConvert.DeserializeObject<List<string>>(namesJsonRepresentation)
            );

            modelBuilder.Entity<Author>()
            .Property(m => m.WrittenMangas)
            .HasConversion( listOfStringNames => JsonConvert.SerializeObject(listOfStringNames),
                namesJsonRepresentation => JsonConvert.DeserializeObject<List<string>>(namesJsonRepresentation)
            );

            modelBuilder.Entity<Category>()
            .HasData(
                new Category { 
                    Id = 1, 
                    Name = "Shounen", 
                    UpdatedAt = DateTime.UtcNow, 
                    Mangas = new List<string> {"some manga"}
                    },
                new Category { 
                    Id = 2, 
                    Name = "Shoujo", 
                    UpdatedAt = DateTime.UtcNow,  
                    Mangas = new List<string> {"some manga"} 
                    },
                new Category { 
                    Id = 3, 
                    Name = "Seinen",
                    UpdatedAt = DateTime.UtcNow,  
                    Mangas = new List<string> {"some manga"} 
                    },
                new Category { 
                    Id = 4, 
                    Name = "Comedy", 
                    UpdatedAt = DateTime.UtcNow,  
                    Mangas = new List<string> {"some manga"} 
                    },
                new Category { 
                    Id = 5, 
                    Name = "Action", 
                    UpdatedAt = DateTime.UtcNow,  
                    Mangas = new List<string> {"some manga"} 
                    }
            );

            modelBuilder.Entity<Author>().HasData(
                new Author { 
                    Id = 1, 
                    Name = "Kei", 
                    Surname = "Urana", 
                    UpdatedAt = DateTime.UtcNow, 
                    WrittenMangas = new List<string> {"Soul Eater", "Fire Force", "Gachiakuta"} 
                    },
                new Author { 
                    Id = 2, 
                    Name = "Kouhei", 
                    Surname = "Horikoshi", 
                    UpdatedAt = DateTime.UtcNow, 
                    WrittenMangas = new List<string> {"Boku no Hero Academia"} 
                    },
                new Author { 
                    Id = 3, 
                    Name = "KAGYU", 
                    Surname = "Kumo", 
                    UpdatedAt = DateTime.UtcNow, 
                    WrittenMangas = new List<string> {"Goblin Slayer"} 
                    },
                new Author { 
                    Id = 4, 
                    Name = "Yabako", 
                    Surname = "Sandrovich", 
                    UpdatedAt = DateTime.UtcNow, 
                    WrittenMangas = new List<string> {"Kengan Ashua", "Kengan Omega"} 
                    },
                new Author { 
                    Id = 5,
                    Name = "Minami", 
                    Surname = "Katsuhusa", 
                    UpdatedAt = DateTime.UtcNow, 
                    WrittenMangas = new List<string> {"The Fable"}
                    }
            );

            modelBuilder.Entity<Manga>().HasData(
                new Manga 
                {
                    Id = 1,
                    Type = MangaType.Manga,
                    Title = "The Fable",
                    PublishedAt = "01/11/2014",
                    UpdatedAt = DateTime.UtcNow,
                    Author = "Minami Katsuhisa",
                    Description = "some description",
                    ChaptersCount = 206 
                },
                new Manga
                {
                    Id = 2,
                    Type = MangaType.Manga,
                    Title = "Bocu no Pico Academia",
                    PublishedAt = "",
                    UpdatedAt = DateTime.Now,
                    Author = "Horikoshi Kouhei",
                    Description = "MIDORYA MY BOI, LISTEN I HAVE MY ANUS SORE, PLEASE LUBE IT",
                    ChaptersCount = 355
                }
            );
        }
    }
}