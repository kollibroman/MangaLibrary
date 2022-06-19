using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MangaId",
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
                    PagesCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cover",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Data = table.Column<byte[]>(type: "bytea", nullable: false),
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

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 16, 19, 56, 3, 261, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 16, 19, 56, 3, 261, DateTimeKind.Utc).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 16, 19, 56, 3, 261, DateTimeKind.Utc).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 16, 19, 56, 3, 261, DateTimeKind.Utc).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 16, 19, 56, 3, 261, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 16, 19, 56, 3, 261, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 16, 19, 56, 3, 261, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 16, 19, 56, 3, 261, DateTimeKind.Utc).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 16, 19, 56, 3, 261, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 16, 19, 56, 3, 261, DateTimeKind.Utc).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 16, 19, 56, 3, 261, DateTimeKind.Utc).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 16, 21, 56, 3, 261, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 16, 21, 56, 3, 261, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 16, 21, 56, 3, 261, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 16, 21, 56, 3, 261, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.CreateIndex(
                name: "IX_Pages_ChapterId1",
                table: "Pages",
                column: "ChapterId1");

            migrationBuilder.CreateIndex(
                name: "IX_Cover_MangaId",
                table: "Cover",
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

            migrationBuilder.DropTable(
                name: "Cover");

            migrationBuilder.DropIndex(
                name: "IX_Pages_ChapterId1",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ChapterId1",
                table: "Pages");

            migrationBuilder.AddColumn<string>(
                name: "MangaId",
                table: "Pages",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 13, 14, 3, 135, DateTimeKind.Utc).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 13, 14, 3, 135, DateTimeKind.Utc).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 13, 14, 3, 135, DateTimeKind.Utc).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 13, 14, 3, 135, DateTimeKind.Utc).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 13, 14, 3, 135, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 13, 14, 3, 135, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 13, 14, 3, 135, DateTimeKind.Utc).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 13, 14, 3, 135, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 13, 14, 3, 135, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 13, 14, 3, 135, DateTimeKind.Utc).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 13, 14, 3, 135, DateTimeKind.Utc).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 15, 14, 3, 135, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 15, 14, 3, 135, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 15, 14, 3, 135, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 15, 14, 3, 135, DateTimeKind.Local).AddTicks(5852));
        }
    }
}
