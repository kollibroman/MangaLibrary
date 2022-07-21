using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class fuck_it : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mangas",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Mangas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Local).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Local).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Local).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Local).AddTicks(7540) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mangas_Categories_CategoryId",
                table: "Mangas");

            migrationBuilder.DropIndex(
                name: "IX_Mangas_CategoryId",
                table: "Mangas");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Mangas");

            migrationBuilder.AddColumn<string>(
                name: "Mangas",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Utc).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Utc).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Utc).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Utc).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Mangas", "UpdatedAt" },
                values: new object[] { "[\"some manga\"]", new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Utc).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Mangas", "UpdatedAt" },
                values: new object[] { "[\"some manga\"]", new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Utc).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Mangas", "UpdatedAt" },
                values: new object[] { "[\"some manga\"]", new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Utc).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Mangas", "UpdatedAt" },
                values: new object[] { "[\"some manga\"]", new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Utc).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Mangas", "UpdatedAt" },
                values: new object[] { "[\"some manga\"]", new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Utc).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Utc).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 27, 13, 749, DateTimeKind.Local).AddTicks(7951));
        }
    }
}
