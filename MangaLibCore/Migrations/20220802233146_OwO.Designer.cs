﻿// <auto-generated />
using System;
using MangaLibCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MangaLibCore.Migrations
{
    [DbContext(typeof(MangaLibDbContext))]
    [Migration("20220802233146_OwO")]
    partial class OwO
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            UpdatedAt = new DateTime(2022, 8, 2, 23, 31, 45, 853, DateTimeKind.Utc).AddTicks(5017)
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kouhei",
                            Surname = "Horikoshi",
                            UpdatedAt = new DateTime(2022, 8, 2, 23, 31, 45, 853, DateTimeKind.Utc).AddTicks(5020)
                        },
                        new
                        {
                            Id = 3,
                            Name = "KAGYU",
                            Surname = "Kumo",
                            UpdatedAt = new DateTime(2022, 8, 2, 23, 31, 45, 853, DateTimeKind.Utc).AddTicks(5022)
                        },
                        new
                        {
                            Id = 4,
                            Name = "Yabako",
                            Surname = "Sandrovich",
                            UpdatedAt = new DateTime(2022, 8, 2, 23, 31, 45, 853, DateTimeKind.Utc).AddTicks(5023)
                        },
                        new
                        {
                            Id = 5,
                            Name = "Minami",
                            Surname = "Katsuhisa",
                            UpdatedAt = new DateTime(2022, 8, 2, 23, 31, 45, 853, DateTimeKind.Utc).AddTicks(5024)
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

                    b.Property<int>("MangaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("MangaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MangaId")
                        .IsUnique();

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

                    b.ToTable("Mangas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 5,
                            ChaptersCount = 206,
                            Description = "some description",
                            PublishedAt = "01/11/2014",
                            Title = "The Fable",
                            Type = 0,
                            UpdatedAt = new DateTime(2022, 8, 2, 23, 31, 45, 853, DateTimeKind.Utc).AddTicks(5585)
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            ChaptersCount = 355,
                            Description = "MIDORYA MY BOI, LISTEN I HAVE MY ANUS SORE, PLEASE LUBE IT",
                            PublishedAt = "",
                            Title = "Bocu no Pico Academia",
                            Type = 0,
                            UpdatedAt = new DateTime(2022, 8, 2, 23, 31, 45, 853, DateTimeKind.Local).AddTicks(5597)
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            ChaptersCount = 58,
                            Description = "Golin. Dead. Yes.",
                            PublishedAt = "",
                            Title = "Goblin Slayer",
                            Type = 0,
                            UpdatedAt = new DateTime(2022, 8, 2, 23, 31, 45, 853, DateTimeKind.Local).AddTicks(5625)
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 4,
                            ChaptersCount = 236,
                            Description = "They beat the shit out of each other",
                            PublishedAt = "",
                            Title = "Kengan Ashua",
                            Type = 0,
                            UpdatedAt = new DateTime(2022, 8, 2, 23, 31, 45, 853, DateTimeKind.Local).AddTicks(5628)
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 1,
                            ChaptersCount = 304,
                            Description = " F I R E.",
                            PublishedAt = "",
                            Title = "Fire Force",
                            Type = 0,
                            UpdatedAt = new DateTime(2022, 8, 2, 23, 31, 45, 853, DateTimeKind.Local).AddTicks(5631)
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

            modelBuilder.Entity("MangaLibCore.Entities.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagId"), 1L, 1);

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("MangaTag", b =>
                {
                    b.Property<int>("MangasId")
                        .HasColumnType("int");

                    b.Property<int>("TagsTagId")
                        .HasColumnType("int");

                    b.HasKey("MangasId", "TagsTagId");

                    b.HasIndex("TagsTagId");

                    b.ToTable("MangaTag");
                });

            modelBuilder.Entity("MangaLibCore.Entities.Cover", b =>
                {
                    b.HasOne("MangaLibCore.Entities.Manga", "Manga")
                        .WithOne("Cover")
                        .HasForeignKey("MangaLibCore.Entities.Cover", "MangaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manga");
                });

            modelBuilder.Entity("MangaLibCore.Entities.Manga", b =>
                {
                    b.HasOne("MangaLibCore.Entities.Author", "Author")
                        .WithMany("WrittenMangas")
                        .HasForeignKey("AuthorId")
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

            modelBuilder.Entity("MangaTag", b =>
                {
                    b.HasOne("MangaLibCore.Entities.Manga", null)
                        .WithMany()
                        .HasForeignKey("MangasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MangaLibCore.Entities.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MangaLibCore.Entities.Author", b =>
                {
                    b.Navigation("WrittenMangas");
                });

            modelBuilder.Entity("MangaLibCore.Entities.Chapter", b =>
                {
                    b.Navigation("Pages");
                });

            modelBuilder.Entity("MangaLibCore.Entities.Manga", b =>
                {
                    b.Navigation("Cover")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
