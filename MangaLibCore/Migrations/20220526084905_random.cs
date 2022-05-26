using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class random : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "ChapterId1",
                table: "Pages",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Chapter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
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
                name: "IX_Pages_ChapterId1",
                table: "Pages",
                column: "ChapterId1");

            migrationBuilder.CreateIndex(
                name: "IX_Chapter_MangaId",
                table: "Chapter",
                column: "MangaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Chapter_ChapterId1",
                table: "Pages",
                column: "ChapterId1",
                principalTable: "Chapter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Chapter_ChapterId1",
                table: "Pages");

            migrationBuilder.DropTable(
                name: "Chapter");

            migrationBuilder.DropIndex(
                name: "IX_Pages_ChapterId1",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ChapterId1",
                table: "Pages");

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
    }
}
