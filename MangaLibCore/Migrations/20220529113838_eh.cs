using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class eh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mangas_Authors_AuthorId",
                table: "Mangas");

            migrationBuilder.DropForeignKey(
                name: "FK_Mangas_Categories_CategoryId",
                table: "Mangas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Chapter_ChapterId1",
                table: "Pages");

            migrationBuilder.DropTable(
                name: "Chapter");

            migrationBuilder.DropIndex(
                name: "IX_Pages_ChapterId1",
                table: "Pages");

            migrationBuilder.DropIndex(
                name: "IX_Mangas_AuthorId",
                table: "Mangas");

            migrationBuilder.DropIndex(
                name: "IX_Mangas_CategoryId",
                table: "Mangas");

            migrationBuilder.DropColumn(
                name: "ChapterId1",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Mangas");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Mangas");

            migrationBuilder.AddColumn<List<string>>(
                name: "Chapters",
                table: "Mangas",
                type: "text[]",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Mangas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<List<string>>(
                name: "Mangas",
                table: "Categories",
                type: "text[]",
                nullable: false);

            migrationBuilder.AddColumn<List<string>>(
                name: "WrittenMangas",
                table: "Authors",
                type: "text[]",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chapters",
                table: "Mangas");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Mangas");

            migrationBuilder.DropColumn(
                name: "Mangas",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "WrittenMangas",
                table: "Authors");

            migrationBuilder.AddColumn<int>(
                name: "ChapterId1",
                table: "Pages",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Mangas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Mangas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Chapter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MangaId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
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
                name: "IX_Mangas_AuthorId",
                table: "Mangas",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Mangas_CategoryId",
                table: "Mangas",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Chapter_MangaId",
                table: "Chapter",
                column: "MangaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mangas_Authors_AuthorId",
                table: "Mangas",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mangas_Categories_CategoryId",
                table: "Mangas",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Chapter_ChapterId1",
                table: "Pages",
                column: "ChapterId1",
                principalTable: "Chapter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
