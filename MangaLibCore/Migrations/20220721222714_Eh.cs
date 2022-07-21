using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class Eh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mangas = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chapters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PagesCount = table.Column<int>(type: "int", nullable: false),
                    ChapterIndex = table.Column<int>(type: "int", nullable: false),
                    MangaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChapterName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cover",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MangaName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cover", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mangas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishedAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChaptersCount = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageNumber = table.Column<int>(type: "int", nullable: false),
                    PageData = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    MangaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChapterId = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name", "Surname", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Kei", "Urana", new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Utc).AddTicks(7748) },
                    { 2, "Kouhei", "Horikoshi", new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Utc).AddTicks(7750) },
                    { 3, "KAGYU", "Kumo", new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Utc).AddTicks(7751) },
                    { 4, "Yabako", "Sandrovich", new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Utc).AddTicks(7752) },
                    { 5, "Minami", "Katsuhisa", new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Utc).AddTicks(7753) }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Mangas", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "[\"some manga\"]", "Shounen", new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Utc).AddTicks(7620) },
                    { 2, "[\"some manga\"]", "Shoujo", new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Utc).AddTicks(7628) },
                    { 3, "[\"some manga\"]", "Seinen", new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Utc).AddTicks(7630) },
                    { 4, "[\"some manga\"]", "Comedy", new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Utc).AddTicks(7632) },
                    { 5, "[\"some manga\"]", "Action", new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Utc).AddTicks(7634) }
                });

            migrationBuilder.InsertData(
                table: "Mangas",
                columns: new[] { "Id", "AuthorId", "ChaptersCount", "Description", "PublishedAt", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 5, 206, "some description", "01/11/2014", "The Fable", 0, new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Utc).AddTicks(7925) },
                    { 2, 2, 355, "MIDORYA MY BOI, LISTEN I HAVE MY ANUS SORE, PLEASE LUBE IT", "", "Bocu no Pico Academia", 0, new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Local).AddTicks(7931) },
                    { 3, 3, 58, "Golin. Dead. Yes.", "", "Goblin Slayer", 0, new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Local).AddTicks(7948) },
                    { 4, 4, 236, "They beat the shit out of each other", "", "Kengan Ashua", 0, new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Local).AddTicks(7950) },
                    { 5, 1, 304, " F I R E.", "", "Fire Force", 0, new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Local).AddTicks(7951) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mangas_AuthorId",
                table: "Mangas",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pages_ChapterId",
                table: "Pages",
                column: "ChapterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Cover");

            migrationBuilder.DropTable(
                name: "Mangas");

            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Chapters");
        }
    }
}
