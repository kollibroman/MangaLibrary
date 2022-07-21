﻿// <auto-generated />
using System;
using MangaLibCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MangaLibCore.Migrations
{
    [DbContext(typeof(MangaLibDbContext))]
    partial class MangaLibDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MangaLibCore.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Kei",
                            Surname = "Urana",
                            UpdatedAt = new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7492)
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kouhei",
                            Surname = "Horikoshi",
                            UpdatedAt = new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7494)
                        },
                        new
                        {
                            Id = 3,
                            Name = "KAGYU",
                            Surname = "Kumo",
                            UpdatedAt = new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7495)
                        },
                        new
                        {
                            Id = 4,
                            Name = "Yabako",
                            Surname = "Sandrovich",
                            UpdatedAt = new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7496)
                        },
                        new
                        {
                            Id = 5,
                            Name = "Minami",
                            Surname = "Katsuhisa",
                            UpdatedAt = new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7497)
                        });
                });

            modelBuilder.Entity("MangaLibCore.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Shounen",
                            UpdatedAt = new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7354)
                        },
                        new
                        {
                            Id = 2,
                            Name = "Shoujo",
                            UpdatedAt = new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7356)
                        },
                        new
                        {
                            Id = 3,
                            Name = "Seinen",
                            UpdatedAt = new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7357)
                        },
                        new
                        {
                            Id = 4,
                            Name = "Comedy",
                            UpdatedAt = new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7358)
                        },
                        new
                        {
                            Id = 5,
                            Name = "Action",
                            UpdatedAt = new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7359)
                        });
                });

            modelBuilder.Entity("MangaLibCore.Entities.Chapter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ChapterIndex")
                        .HasColumnType("int");

                    b.Property<string>("ChapterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MangaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PagesCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Chapters");
                });

            modelBuilder.Entity("MangaLibCore.Entities.Cover", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("MangaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Cover");
                });

            modelBuilder.Entity("MangaLibCore.Entities.Manga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ChaptersCount")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublishedAt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Mangas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 5,
                            CategoryId = 3,
                            ChaptersCount = 206,
                            Description = "some description",
                            PublishedAt = "01/11/2014",
                            Title = "The Fable",
                            Type = 0,
                            UpdatedAt = new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7516)
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            CategoryId = 5,
                            ChaptersCount = 355,
                            Description = "MIDORYA MY BOI, LISTEN I HAVE MY ANUS SORE, PLEASE LUBE IT",
                            PublishedAt = "",
                            Title = "Bocu no Pico Academia",
                            Type = 0,
                            UpdatedAt = new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Local).AddTicks(7521)
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            CategoryId = 3,
                            ChaptersCount = 58,
                            Description = "Golin. Dead. Yes.",
                            PublishedAt = "",
                            Title = "Goblin Slayer",
                            Type = 0,
                            UpdatedAt = new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Local).AddTicks(7537)
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 4,
                            CategoryId = 5,
                            ChaptersCount = 236,
                            Description = "They beat the shit out of each other",
                            PublishedAt = "",
                            Title = "Kengan Ashua",
                            Type = 0,
                            UpdatedAt = new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Local).AddTicks(7539)
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 1,
                            CategoryId = 1,
                            ChaptersCount = 304,
                            Description = " F I R E.",
                            PublishedAt = "",
                            Title = "Fire Force",
                            Type = 0,
                            UpdatedAt = new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Local).AddTicks(7540)
                        });
                });

            modelBuilder.Entity("MangaLibCore.Entities.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ChapterId")
                        .HasColumnType("int");

                    b.Property<string>("MangaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PageData")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("PageNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChapterId");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("MangaLibCore.Entities.Manga", b =>
                {
                    b.HasOne("MangaLibCore.Entities.Author", "Author")
                        .WithMany("WrittenMangas")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MangaLibCore.Entities.Category", null)
                        .WithMany("Mangas")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("MangaLibCore.Entities.Page", b =>
                {
                    b.HasOne("MangaLibCore.Entities.Chapter", null)
                        .WithMany("Pages")
                        .HasForeignKey("ChapterId");
                });

            modelBuilder.Entity("MangaLibCore.Entities.Author", b =>
                {
                    b.Navigation("WrittenMangas");
                });

            modelBuilder.Entity("MangaLibCore.Entities.Category", b =>
                {
                    b.Navigation("Mangas");
                });

            modelBuilder.Entity("MangaLibCore.Entities.Chapter", b =>
                {
                    b.Navigation("Pages");
                });
#pragma warning restore 612, 618
        }
    }
}
