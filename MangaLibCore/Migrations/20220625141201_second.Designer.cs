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
    [Migration("20220625141201_second")]
    partial class second
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

                    b.Property<string>("WrittenMangas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Kei",
                            Surname = "Urana",
                            UpdatedAt = new DateTime(2022, 6, 25, 14, 11, 59, 978, DateTimeKind.Utc).AddTicks(6163),
                            WrittenMangas = "[\"Soul Eater\",\"Fire Force\",\"Gachiakuta\"]"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kouhei",
                            Surname = "Horikoshi",
                            UpdatedAt = new DateTime(2022, 6, 25, 14, 11, 59, 978, DateTimeKind.Utc).AddTicks(6178),
                            WrittenMangas = "[\"Boku no Hero Academia\"]"
                        },
                        new
                        {
                            Id = 3,
                            Name = "KAGYU",
                            Surname = "Kumo",
                            UpdatedAt = new DateTime(2022, 6, 25, 14, 11, 59, 978, DateTimeKind.Utc).AddTicks(6184),
                            WrittenMangas = "[\"Goblin Slayer\"]"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Yabako",
                            Surname = "Sandrovich",
                            UpdatedAt = new DateTime(2022, 6, 25, 14, 11, 59, 978, DateTimeKind.Utc).AddTicks(6191),
                            WrittenMangas = "[\"Kengan Ashua\",\"Kengan Omega\"]"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Minami",
                            Surname = "Katsuhusa",
                            UpdatedAt = new DateTime(2022, 6, 25, 14, 11, 59, 978, DateTimeKind.Utc).AddTicks(6198),
                            WrittenMangas = "[\"The Fable\"]"
                        });
                });

            modelBuilder.Entity("MangaLibCore.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Mangas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            Mangas = "[\"some manga\"]",
                            Name = "Shounen",
                            UpdatedAt = new DateTime(2022, 6, 25, 14, 11, 59, 978, DateTimeKind.Utc).AddTicks(5692)
                        },
                        new
                        {
                            Id = 2,
                            Mangas = "[\"some manga\"]",
                            Name = "Shoujo",
                            UpdatedAt = new DateTime(2022, 6, 25, 14, 11, 59, 978, DateTimeKind.Utc).AddTicks(5716)
                        },
                        new
                        {
                            Id = 3,
                            Mangas = "[\"some manga\"]",
                            Name = "Seinen",
                            UpdatedAt = new DateTime(2022, 6, 25, 14, 11, 59, 978, DateTimeKind.Utc).AddTicks(5722)
                        },
                        new
                        {
                            Id = 4,
                            Mangas = "[\"some manga\"]",
                            Name = "Comedy",
                            UpdatedAt = new DateTime(2022, 6, 25, 14, 11, 59, 978, DateTimeKind.Utc).AddTicks(5727)
                        },
                        new
                        {
                            Id = 5,
                            Mangas = "[\"some manga\"]",
                            Name = "Action",
                            UpdatedAt = new DateTime(2022, 6, 25, 14, 11, 59, 978, DateTimeKind.Utc).AddTicks(5733)
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

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("Mangas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Minami Katsuhisa",
                            ChaptersCount = 206,
                            Description = "some description",
                            PublishedAt = "01/11/2014",
                            Title = "The Fable",
                            Type = 0,
                            UpdatedAt = new DateTime(2022, 6, 25, 14, 11, 59, 978, DateTimeKind.Utc).AddTicks(6281)
                        },
                        new
                        {
                            Id = 2,
                            Author = "Horikoshi Kouhei",
                            ChaptersCount = 355,
                            Description = "MIDORYA MY BOI, LISTEN I HAVE MY ANUS SORE, PLEASE LUBE IT",
                            PublishedAt = "",
                            Title = "Bocu no Pico Academia",
                            Type = 0,
                            UpdatedAt = new DateTime(2022, 6, 25, 16, 11, 59, 978, DateTimeKind.Local).AddTicks(6302)
                        },
                        new
                        {
                            Id = 3,
                            Author = "KAGYU Kumo",
                            ChaptersCount = 58,
                            Description = "Golin. Dead. Yes.",
                            PublishedAt = "",
                            Title = "Goblin Slayer",
                            Type = 0,
                            UpdatedAt = new DateTime(2022, 6, 25, 16, 11, 59, 978, DateTimeKind.Local).AddTicks(6392)
                        },
                        new
                        {
                            Id = 4,
                            Author = "Yabako Sandrovich",
                            ChaptersCount = 236,
                            Description = "They beat the shit out of each other",
                            PublishedAt = "",
                            Title = "Kengan Ashua",
                            Type = 0,
                            UpdatedAt = new DateTime(2022, 6, 25, 16, 11, 59, 978, DateTimeKind.Local).AddTicks(6404)
                        },
                        new
                        {
                            Id = 5,
                            Author = "Kei Urana",
                            ChaptersCount = 304,
                            Description = " F I R E.",
                            PublishedAt = "",
                            Title = "Fire Force",
                            Type = 0,
                            UpdatedAt = new DateTime(2022, 6, 25, 16, 11, 59, 978, DateTimeKind.Local).AddTicks(6415)
                        });
                });

            modelBuilder.Entity("MangaLibCore.Entities.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ChapterId")
                        .HasColumnType("int");

                    b.Property<byte[]>("PageData")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("PageNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChapterId");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("MangaLibCore.Entities.Page", b =>
                {
                    b.HasOne("MangaLibCore.Entities.Chapter", null)
                        .WithMany("Pages")
                        .HasForeignKey("ChapterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MangaLibCore.Entities.Chapter", b =>
                {
                    b.Navigation("Pages");
                });
#pragma warning restore 612, 618
        }
    }
}
