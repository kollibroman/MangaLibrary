using MangaLibCore.Enums;
using MangaLibCore.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using Microsoft.EntityFrameworkCore.Design;
using System.Runtime.InteropServices;

namespace MangaLibCore
{
    public static class DbSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author { 
                    Id = 1, 
                    Name = "Kei", 
                    Surname = "Urana", 
                    UpdatedAt = DateTime.UtcNow, 
                    },
                new Author { 
                    Id = 2, 
                    Name = "Kouhei", 
                    Surname = "Horikoshi", 
                    UpdatedAt = DateTime.UtcNow, 
                    },
                new Author { 
                    Id = 3, 
                    Name = "KAGYU", 
                    Surname = "Kumo", 
                    UpdatedAt = DateTime.UtcNow, 
                    },
                new Author { 
                    Id = 4, 
                    Name = "Yabako", 
                    Surname = "Sandrovich", 
                    UpdatedAt = DateTime.UtcNow, 
                    },
                new Author { 
                    Id = 5,
                    Name = "Minami", 
                    Surname = "Katsuhisa", 
                    UpdatedAt = DateTime.UtcNow, 
                    }
            );

            modelBuilder.Entity<Manga>().HasData(
                new Manga 
                {
                    Id = 1,
                    AuthorId = 5,
                    CoverId = 1,
                    Type = EntityType.Manga,
                    Title = "The Fable",
                    PublishedAt = "01/11/2014",
                    UpdatedAt = DateTime.UtcNow,
                    Description = "some description",
                    ChaptersCount = 206 
                },
                new Manga
                {
                    Id = 2,
                    AuthorId = 2,
                    CoverId = 2,
                    Type = EntityType.Manga,
                    Title = "Bocu no Pico Academia",
                    PublishedAt = "",
                    UpdatedAt = DateTime.Now,
                    Description = "MIDORYA MY BOI, LISTEN I HAVE MY ANUS SORE, PLEASE LUBE IT",
                    ChaptersCount = 355
                },
                new Manga
                {
                    Id = 3,
                    AuthorId = 3,
                    CoverId = 3,
                    Type = EntityType.Manga,
                    Title = "Goblin Slayer",
                    PublishedAt = "",
                    UpdatedAt = DateTime.Now,
                    Description = "Golin. Dead. Yes.",
                    ChaptersCount = 58
                },
                new Manga
                {
                    Id = 4,
                    AuthorId = 4,
                    CoverId = 4,
                    Type = EntityType.Manga,
                    Title = "Kengan Ashua",
                    PublishedAt = "",
                    UpdatedAt = DateTime.Now,
                    Description = "They beat the shit out of each other",
                    ChaptersCount = 236
                },
                new Manga
                {
                    Id = 5,
                    AuthorId = 1,
                    CoverId = 5,
                    Type = EntityType.Manga,
                    Title = "Fire Force",
                    PublishedAt = "",
                    UpdatedAt = DateTime.Now,
                    Description = " F I R E.",
                    ChaptersCount = 304
                }
            );

            modelBuilder.Entity<Cover>().HasData(
                new Cover
                {
                    Id = 1,
                    Name = "",
                    Data = Array.Empty<byte>(),
                    MangaName = "The Fable"
                },
                new Cover
                {
                    Id = 2,
                    Name = "",
                    Data = Array.Empty<byte>(),
                    MangaName = "Bocu no Pico Academia"
                },
                new Cover
                {
                    Id = 3,
                    Name = "Goblin Slayer",
                    Data = Array.Empty<byte>(),
                    MangaName = "The Fable"
                },
                new Cover
                {
                    Id = 4,
                    Name = "Kengan Ashua",
                    Data = Array.Empty<byte>(),
                    MangaName = "The Fable"
                },
                new Cover
                {
                    Id = 5,
                    Name = "Fire Force",
                    Data = Array.Empty<byte>(),
                    MangaName = "The Fable"
                }  
            );
        }
    }
}