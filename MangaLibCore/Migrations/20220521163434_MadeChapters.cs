using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class MadeChapters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Mangas_MangaId",
                table: "Pages");

            migrationBuilder.RenameColumn(
                name: "MangaId",
                table: "Pages",
                newName: "ChapterId");

            migrationBuilder.RenameIndex(
                name: "IX_Pages_MangaId",
                table: "Pages",
                newName: "IX_Pages_ChapterId");

            migrationBuilder.RenameColumn(
                name: "Chapters",
                table: "Mangas",
                newName: "ChaptersCount");

            migrationBuilder.CreateTable(
                name: "Chapter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PagesCount = table.Column<int>(type: "integer", nullable: false),
                    MangaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chapter_Mangas_MangaId",
                        column: x => x.MangaId,
                        principalTable: "Mangas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chapter_MangaId",
                table: "Chapter",
                column: "MangaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Chapter_ChapterId",
                table: "Pages",
                column: "ChapterId",
                principalTable: "Chapter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Chapter_ChapterId",
                table: "Pages");

            migrationBuilder.DropTable(
                name: "Chapter");

            migrationBuilder.RenameColumn(
                name: "ChapterId",
                table: "Pages",
                newName: "MangaId");

            migrationBuilder.RenameIndex(
                name: "IX_Pages_ChapterId",
                table: "Pages",
                newName: "IX_Pages_MangaId");

            migrationBuilder.RenameColumn(
                name: "ChaptersCount",
                table: "Mangas",
                newName: "Chapters");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Mangas_MangaId",
                table: "Pages",
                column: "MangaId",
                principalTable: "Mangas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
