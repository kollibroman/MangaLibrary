using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    WrittenMangas = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Mangas = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chapters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PagesCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapters", x => x.Id);
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
                    Author = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ChaptersCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mangas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PageNumber = table.Column<int>(type: "integer", nullable: false),
                    PageTitle = table.Column<string>(type: "text", nullable: false),
                    PageData = table.Column<byte[]>(type: "bytea", nullable: false),
                    ChapterId1 = table.Column<int>(type: "integer", nullable: false),
                    ChapterId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pages_Chapters_ChapterId1",
                        column: x => x.ChapterId1,
                        principalTable: "Chapters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cover",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Data = table.Column<byte[]>(type: "bytea", nullable: false),
                    MangaName = table.Column<string>(type: "text", nullable: false),
                    MangaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cover", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cover_Mangas_MangaId",
                        column: x => x.MangaId,
                        principalTable: "Mangas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name", "Surname", "UpdatedAt", "WrittenMangas" },
                values: new object[,]
                {
                    { 1, "Kei", "Urana", new DateTime(2022, 6, 21, 20, 59, 54, 893, DateTimeKind.Utc).AddTicks(6201), "[\"Soul Eater\",\"Fire Force\",\"Gachiakuta\"]" },
                    { 2, "Kouhei", "Horikoshi", new DateTime(2022, 6, 21, 20, 59, 54, 893, DateTimeKind.Utc).AddTicks(6220), "[\"Boku no Hero Academia\"]" },
                    { 3, "KAGYU", "Kumo", new DateTime(2022, 6, 21, 20, 59, 54, 893, DateTimeKind.Utc).AddTicks(6234), "[\"Goblin Slayer\"]" },
                    { 4, "Yabako", "Sandrovich", new DateTime(2022, 6, 21, 20, 59, 54, 893, DateTimeKind.Utc).AddTicks(6249), "[\"Kengan Ashua\",\"Kengan Omega\"]" },
                    { 5, "Minami", "Katsuhusa", new DateTime(2022, 6, 21, 20, 59, 54, 893, DateTimeKind.Utc).AddTicks(6263), "[\"The Fable\"]" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Mangas", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "[\"some manga\"]", "Shounen", new DateTime(2022, 6, 21, 20, 59, 54, 893, DateTimeKind.Utc).AddTicks(5910) },
                    { 2, "[\"some manga\"]", "Shoujo", new DateTime(2022, 6, 21, 20, 59, 54, 893, DateTimeKind.Utc).AddTicks(5934) },
                    { 3, "[\"some manga\"]", "Seinen", new DateTime(2022, 6, 21, 20, 59, 54, 893, DateTimeKind.Utc).AddTicks(5972) },
                    { 4, "[\"some manga\"]", "Comedy", new DateTime(2022, 6, 21, 20, 59, 54, 893, DateTimeKind.Utc).AddTicks(6010) },
                    { 5, "[\"some manga\"]", "Action", new DateTime(2022, 6, 21, 20, 59, 54, 893, DateTimeKind.Utc).AddTicks(6045) }
                });

            migrationBuilder.InsertData(
                table: "Mangas",
                columns: new[] { "Id", "Author", "ChaptersCount", "Description", "PublishedAt", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Minami Katsuhisa", 206, "some description", "01/11/2014", "The Fable", 0, new DateTime(2022, 6, 21, 20, 59, 54, 893, DateTimeKind.Utc).AddTicks(6325) },
                    { 2, "Horikoshi Kouhei", 355, "MIDORYA MY BOI, LISTEN I HAVE MY ANUS SORE, PLEASE LUBE IT", "", "Bocu no Pico Academia", 0, new DateTime(2022, 6, 21, 22, 59, 54, 893, DateTimeKind.Local).AddTicks(6345) },
                    { 3, "KAGYU Kumo", 58, "Golin. Dead. Yes.", "", "Goblin Slayer", 0, new DateTime(2022, 6, 21, 22, 59, 54, 893, DateTimeKind.Local).AddTicks(6398) },
                    { 4, "Yabako Sandrovich", 236, "They beat the shit out of each other", "", "Kengan Ashua", 0, new DateTime(2022, 6, 21, 22, 59, 54, 893, DateTimeKind.Local).AddTicks(6413) },
                    { 5, "Kei Urana", 304, " F I R E.", "", "Fire Force", 0, new DateTime(2022, 6, 21, 22, 59, 54, 893, DateTimeKind.Local).AddTicks(6432) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cover_MangaId",
                table: "Cover",
                column: "MangaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pages_ChapterId1",
                table: "Pages",
                column: "ChapterId1");
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
                name: "Pages");

            migrationBuilder.DropTable(
                name: "Mangas");

            migrationBuilder.DropTable(
                name: "Chapters");
        }
    }
}
