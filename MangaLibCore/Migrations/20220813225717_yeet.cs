using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class yeet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chapters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PagesCount = table.Column<int>(type: "integer", nullable: false),
                    ChapterIndex = table.Column<int>(type: "integer", nullable: false),
                    MangaName = table.Column<string>(type: "text", nullable: false),
                    ChapterName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cover",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Data = table.Column<byte[]>(type: "bytea", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    MangaName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cover", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TagName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PageNumber = table.Column<int>(type: "integer", nullable: false),
                    PageData = table.Column<byte[]>(type: "bytea", nullable: false),
                    MangaName = table.Column<string>(type: "text", nullable: false),
                    ChapterId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pages_Chapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "Chapters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Mangas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    PublishedAt = table.Column<string>(type: "text", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ChaptersCount = table.Column<int>(type: "integer", nullable: false),
                    AuthorId = table.Column<int>(type: "integer", nullable: false),
                    CoverId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mangas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mangas_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mangas_Cover_CoverId",
                        column: x => x.CoverId,
                        principalTable: "Cover",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MangaTag",
                columns: table => new
                {
                    MangasId = table.Column<int>(type: "integer", nullable: false),
                    TagsTagId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaTag", x => new { x.MangasId, x.TagsTagId });
                    table.ForeignKey(
                        name: "FK_MangaTag_Mangas_MangasId",
                        column: x => x.MangasId,
                        principalTable: "Mangas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MangaTag_Tags_TagsTagId",
                        column: x => x.TagsTagId,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name", "Surname", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Kei", "Urana", new DateTime(2022, 8, 13, 22, 57, 17, 20, DateTimeKind.Utc).AddTicks(7849) },
                    { 2, "Kouhei", "Horikoshi", new DateTime(2022, 8, 13, 22, 57, 17, 20, DateTimeKind.Utc).AddTicks(7852) },
                    { 3, "KAGYU", "Kumo", new DateTime(2022, 8, 13, 22, 57, 17, 20, DateTimeKind.Utc).AddTicks(7853) },
                    { 4, "Yabako", "Sandrovich", new DateTime(2022, 8, 13, 22, 57, 17, 20, DateTimeKind.Utc).AddTicks(7855) },
                    { 5, "Minami", "Katsuhisa", new DateTime(2022, 8, 13, 22, 57, 17, 20, DateTimeKind.Utc).AddTicks(7856) }
                });

            migrationBuilder.InsertData(
                table: "Cover",
                columns: new[] { "Id", "Data", "MangaName", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new byte[0], "The Fable", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new byte[0], "Bocu no Pico Academia", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new byte[0], "The Fable", "Goblin Slayer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new byte[0], "The Fable", "Kengan Ashua", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new byte[0], "The Fable", "Fire Force", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Mangas",
                columns: new[] { "Id", "AuthorId", "ChaptersCount", "CoverId", "Description", "PublishedAt", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 5, 206, 1, "some description", "01/11/2014", "The Fable", 0, new DateTime(2022, 8, 13, 22, 57, 17, 20, DateTimeKind.Utc).AddTicks(8115) },
                    { 2, 2, 355, 2, "MIDORYA MY BOI, LISTEN I HAVE MY ANUS SORE, PLEASE LUBE IT", "", "Bocu no Pico Academia", 0, new DateTime(2022, 8, 13, 22, 57, 17, 20, DateTimeKind.Local).AddTicks(8130) },
                    { 3, 3, 58, 3, "Golin. Dead. Yes.", "", "Goblin Slayer", 0, new DateTime(2022, 8, 13, 22, 57, 17, 20, DateTimeKind.Local).AddTicks(8157) },
                    { 4, 4, 236, 4, "They beat the shit out of each other", "", "Kengan Ashua", 0, new DateTime(2022, 8, 13, 22, 57, 17, 20, DateTimeKind.Local).AddTicks(8162) },
                    { 5, 1, 304, 5, " F I R E.", "", "Fire Force", 0, new DateTime(2022, 8, 13, 22, 57, 17, 20, DateTimeKind.Local).AddTicks(8165) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mangas_AuthorId",
                table: "Mangas",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Mangas_CoverId",
                table: "Mangas",
                column: "CoverId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MangaTag_TagsTagId",
                table: "MangaTag",
                column: "TagsTagId");

            migrationBuilder.CreateIndex(
                name: "IX_Pages_ChapterId",
                table: "Pages",
                column: "ChapterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MangaTag");

            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.DropTable(
                name: "Mangas");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Chapters");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Cover");
        }
    }
}
