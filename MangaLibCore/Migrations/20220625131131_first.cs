using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class first : Migration
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WrittenMangas = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChaptersCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mangas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageNumber = table.Column<int>(type: "int", nullable: false),
                    PageData = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ChapterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pages_Chapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "Chapters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name", "Surname", "UpdatedAt", "WrittenMangas" },
                values: new object[,]
                {
                    { 1, "Kei", "Urana", new DateTime(2022, 6, 25, 13, 11, 31, 4, DateTimeKind.Utc).AddTicks(4609), "[\"Soul Eater\",\"Fire Force\",\"Gachiakuta\"]" },
                    { 2, "Kouhei", "Horikoshi", new DateTime(2022, 6, 25, 13, 11, 31, 4, DateTimeKind.Utc).AddTicks(4652), "[\"Boku no Hero Academia\"]" },
                    { 3, "KAGYU", "Kumo", new DateTime(2022, 6, 25, 13, 11, 31, 4, DateTimeKind.Utc).AddTicks(4676), "[\"Goblin Slayer\"]" },
                    { 4, "Yabako", "Sandrovich", new DateTime(2022, 6, 25, 13, 11, 31, 4, DateTimeKind.Utc).AddTicks(4713), "[\"Kengan Ashua\",\"Kengan Omega\"]" },
                    { 5, "Minami", "Katsuhusa", new DateTime(2022, 6, 25, 13, 11, 31, 4, DateTimeKind.Utc).AddTicks(4751), "[\"The Fable\"]" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Mangas", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "[\"some manga\"]", "Shounen", new DateTime(2022, 6, 25, 13, 11, 31, 4, DateTimeKind.Utc).AddTicks(4107) },
                    { 2, "[\"some manga\"]", "Shoujo", new DateTime(2022, 6, 25, 13, 11, 31, 4, DateTimeKind.Utc).AddTicks(4156) },
                    { 3, "[\"some manga\"]", "Seinen", new DateTime(2022, 6, 25, 13, 11, 31, 4, DateTimeKind.Utc).AddTicks(4175) },
                    { 4, "[\"some manga\"]", "Comedy", new DateTime(2022, 6, 25, 13, 11, 31, 4, DateTimeKind.Utc).AddTicks(4199) },
                    { 5, "[\"some manga\"]", "Action", new DateTime(2022, 6, 25, 13, 11, 31, 4, DateTimeKind.Utc).AddTicks(4224) }
                });

            migrationBuilder.InsertData(
                table: "Mangas",
                columns: new[] { "Id", "Author", "ChaptersCount", "Description", "PublishedAt", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Minami Katsuhisa", 206, "some description", "01/11/2014", "The Fable", 0, new DateTime(2022, 6, 25, 13, 11, 31, 4, DateTimeKind.Utc).AddTicks(4827) },
                    { 2, "Horikoshi Kouhei", 355, "MIDORYA MY BOI, LISTEN I HAVE MY ANUS SORE, PLEASE LUBE IT", "", "Bocu no Pico Academia", 0, new DateTime(2022, 6, 25, 15, 11, 31, 4, DateTimeKind.Local).AddTicks(4871) },
                    { 3, "KAGYU Kumo", 58, "Golin. Dead. Yes.", "", "Goblin Slayer", 0, new DateTime(2022, 6, 25, 15, 11, 31, 4, DateTimeKind.Local).AddTicks(4980) },
                    { 4, "Yabako Sandrovich", 236, "They beat the shit out of each other", "", "Kengan Ashua", 0, new DateTime(2022, 6, 25, 15, 11, 31, 4, DateTimeKind.Local).AddTicks(5024) },
                    { 5, "Kei Urana", 304, " F I R E.", "", "Fire Force", 0, new DateTime(2022, 6, 25, 15, 11, 31, 4, DateTimeKind.Local).AddTicks(5070) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pages_ChapterId",
                table: "Pages",
                column: "ChapterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Cover");

            migrationBuilder.DropTable(
                name: "Mangas");

            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.DropTable(
                name: "Chapters");
        }
    }
}
