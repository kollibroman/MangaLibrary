using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class IDK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MangaId1",
                table: "Pages",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pages_MangaId1",
                table: "Pages",
                column: "MangaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Mangas_MangaId1",
                table: "Pages",
                column: "MangaId1",
                principalTable: "Mangas",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Mangas_MangaId1",
                table: "Pages");

            migrationBuilder.DropIndex(
                name: "IX_Pages_MangaId1",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "MangaId1",
                table: "Pages");
        }
    }
}
