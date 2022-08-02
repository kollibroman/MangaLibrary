using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class OwO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mangas_Categories_CategoryId",
                table: "Mangas");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Mangas_CategoryId",
                table: "Mangas");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Mangas");

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "MangaTag",
                columns: table => new
                {
                    MangasId = table.Column<int>(type: "int", nullable: false),
                    TagsTagId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 2, 23, 31, 45, 853, DateTimeKind.Utc).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 2, 23, 31, 45, 853, DateTimeKind.Utc).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 2, 23, 31, 45, 853, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 2, 23, 31, 45, 853, DateTimeKind.Utc).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 2, 23, 31, 45, 853, DateTimeKind.Utc).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 2, 23, 31, 45, 853, DateTimeKind.Utc).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 2, 23, 31, 45, 853, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 2, 23, 31, 45, 853, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 2, 23, 31, 45, 853, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 2, 23, 31, 45, 853, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.CreateIndex(
                name: "IX_MangaTag_TagsTagId",
                table: "MangaTag",
                column: "TagsTagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MangaTag");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Mangas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 28, 20, 1, 43, 194, DateTimeKind.Utc).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 28, 20, 1, 43, 194, DateTimeKind.Utc).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 28, 20, 1, 43, 194, DateTimeKind.Utc).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 28, 20, 1, 43, 194, DateTimeKind.Utc).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 28, 20, 1, 43, 194, DateTimeKind.Utc).AddTicks(17));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Shounen", new DateTime(2022, 7, 28, 20, 1, 43, 193, DateTimeKind.Utc).AddTicks(9773) },
                    { 2, "Shoujo", new DateTime(2022, 7, 28, 20, 1, 43, 193, DateTimeKind.Utc).AddTicks(9777) },
                    { 3, "Seinen", new DateTime(2022, 7, 28, 20, 1, 43, 193, DateTimeKind.Utc).AddTicks(9778) },
                    { 4, "Comedy", new DateTime(2022, 7, 28, 20, 1, 43, 193, DateTimeKind.Utc).AddTicks(9780) },
                    { 5, "Action", new DateTime(2022, 7, 28, 20, 1, 43, 193, DateTimeKind.Utc).AddTicks(9781) }
                });

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2022, 7, 28, 20, 1, 43, 194, DateTimeKind.Utc).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2022, 7, 28, 20, 1, 43, 194, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2022, 7, 28, 20, 1, 43, 194, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2022, 7, 28, 20, 1, 43, 194, DateTimeKind.Local).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2022, 7, 28, 20, 1, 43, 194, DateTimeKind.Local).AddTicks(165) });

            migrationBuilder.CreateIndex(
                name: "IX_Mangas_CategoryId",
                table: "Mangas",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mangas_Categories_CategoryId",
                table: "Mangas",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
