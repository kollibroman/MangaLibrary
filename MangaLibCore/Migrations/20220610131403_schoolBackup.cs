using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class schoolBackup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Mangas",
                columns: new[] { "Id", "Author", "ChaptersCount", "Description", "PublishedAt", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 4, "Yabako Sandrovich", 236, "They beat the shit out of each other", "", "Kengan Ashua", 0, new DateTime(2022, 6, 10, 15, 14, 3, 135, DateTimeKind.Local).AddTicks(5850) },
                    { 5, "Kei Urana", 304, " F I R E.", "", "Fire Force", 0, new DateTime(2022, 6, 10, 15, 14, 3, 135, DateTimeKind.Local).AddTicks(5852) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 13, 8, 15, 379, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 13, 8, 15, 379, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 13, 8, 15, 379, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 13, 8, 15, 379, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 13, 8, 15, 379, DateTimeKind.Utc).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 13, 8, 15, 379, DateTimeKind.Utc).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 13, 8, 15, 379, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 13, 8, 15, 379, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 13, 8, 15, 379, DateTimeKind.Utc).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 13, 8, 15, 379, DateTimeKind.Utc).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 13, 8, 15, 379, DateTimeKind.Utc).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 15, 8, 15, 379, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 10, 15, 8, 15, 379, DateTimeKind.Local).AddTicks(7555));
        }
    }
}
