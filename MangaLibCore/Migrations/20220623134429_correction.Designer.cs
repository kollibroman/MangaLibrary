﻿// <auto-generated />
using System;
using MangaLibCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MangaLibCore.Migrations
{
    [DbContext(typeof(MangaLibDbContext))]
    [Migration("20220623134429_correction")]
    partial class correction
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MangaLibCore.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("WrittenMangas")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Kei",
                            Surname = "Urana",
                            UpdatedAt = new DateTime(2022, 6, 23, 13, 44, 28, 254, DateTimeKind.Utc).AddTicks(2566),
                            WrittenMangas = "[\"Soul Eater\",\"Fire Force\",\"Gachiakuta\"]"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kouhei",
                            Surname = "Horikoshi",
                            UpdatedAt = new DateTime(2022, 6, 23, 13, 44, 28, 254, DateTimeKind.Utc).AddTicks(2590),
                            WrittenMangas = "[\"Boku no Hero Academia\"]"
                        },
                        new
                        {
                            Id = 3,
                            Name = "KAGYU",
                            Surname = "Kumo",
                            UpdatedAt = new DateTime(2022, 6, 23, 13, 44, 28, 254, DateTimeKind.Utc).AddTicks(2609),
                            WrittenMangas = "[\"Goblin Slayer\"]"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Yabako",
                            Surname = "Sandrovich",
                            UpdatedAt = new DateTime(2022, 6, 23, 13, 44, 28, 254, DateTimeKind.Utc).AddTicks(2628),
                            WrittenMangas = "[\"Kengan Ashua\",\"Kengan Omega\"]"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Minami",
                            Surname = "Katsuhusa",
                            UpdatedAt = new DateTime(2022, 6, 23, 13, 44, 28, 254, DateTimeKind.Utc).AddTicks(2646),
                            WrittenMangas = "[\"The Fable\"]"
                        });
                });

            modelBuilder.Entity("MangaLibCore.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Mangas")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Mangas = "[\"some manga\"]",
                            Name = "Shounen",
                            UpdatedAt = new DateTime(2022, 6, 23, 13, 44, 28, 254, DateTimeKind.Utc).AddTicks(2213)
                        },
                        new
                        {
                            Id = 2,
                            Mangas = "[\"some manga\"]",
                            Name = "Shoujo",
                            UpdatedAt = new DateTime(2022, 6, 23, 13, 44, 28, 254, DateTimeKind.Utc).AddTicks(2261)
                        },
                        new
                        {
                            Id = 3,
                            Mangas = "[\"some manga\"]",
                            Name = "Seinen",
                            UpdatedAt = new DateTime(2022, 6, 23, 13, 44, 28, 254, DateTimeKind.Utc).AddTicks(2280)
                        },
                        new
                        {
                            Id = 4,
                            Mangas = "[\"some manga\"]",
                            Name = "Comedy",
                            UpdatedAt = new DateTime(2022, 6, 23, 13, 44, 28, 254, DateTimeKind.Utc).AddTicks(2299)
                        },
                        new
                        {
                            Id = 5,
                            Mangas = "[\"some manga\"]",
                            Name = "Action",
                            UpdatedAt = new DateTime(2022, 6, 23, 13, 44, 28, 254, DateTimeKind.Utc).AddTicks(2318)
                        });
                });

            modelBuilder.Entity("MangaLibCore.Entities.Chapter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("MangaName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PagesCount")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Chapters");
                });

            modelBuilder.Entity("MangaLibCore.Entities.Cover", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("MangaName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Cover");
                });

            modelBuilder.Entity("MangaLibCore.Entities.Manga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ChaptersCount")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PublishedAt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

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
                            UpdatedAt = new DateTime(2022, 6, 23, 13, 44, 28, 254, DateTimeKind.Utc).AddTicks(2759)
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
                            UpdatedAt = new DateTime(2022, 6, 23, 15, 44, 28, 254, DateTimeKind.Local).AddTicks(2802)
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
                            UpdatedAt = new DateTime(2022, 6, 23, 15, 44, 28, 254, DateTimeKind.Local).AddTicks(2898)
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
                            UpdatedAt = new DateTime(2022, 6, 23, 15, 44, 28, 254, DateTimeKind.Local).AddTicks(2917)
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
                            UpdatedAt = new DateTime(2022, 6, 23, 15, 44, 28, 254, DateTimeKind.Local).AddTicks(2941)
                        });
                });

            modelBuilder.Entity("MangaLibCore.Entities.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ChapterId")
                        .HasColumnType("integer");

                    b.Property<byte[]>("PageData")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<int>("PageNumber")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ChapterId");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("MangaLibCore.Entities.Page", b =>
                {
                    b.HasOne("MangaLibCore.Entities.Chapter", null)
                        .WithMany("Pages")
                        .HasForeignKey("ChapterId");
                });

            modelBuilder.Entity("MangaLibCore.Entities.Chapter", b =>
                {
                    b.Navigation("Pages");
                });
#pragma warning restore 612, 618
        }
    }
}
