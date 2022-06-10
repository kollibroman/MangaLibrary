using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class jjjjj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Mangas",
                columns: new[] { "Id", "Author", "ChaptersCount", "Description", "PublishedAt", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, "Horikoshi Kouhei", 355, "MIDORYA MY BOI, LISTEN I HAVE MY ANUS SORE, PLEASE LUBE IT", "", "Bocu no Pico Academia", 0, new DateTime(2022, 6, 10, 15, 8, 15, 379, DateTimeKind.Local).AddTicks(7507) },
                    { 3, "KAGYU Kumo", 58, "Golin. Dead. Yes.", "", "Goblin Slayer", 0, new DateTime(2022, 6, 10, 15, 8, 15, 379, DateTimeKind.Local).AddTicks(7555) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 8, 21, 2, 33, 37, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 8, 21, 2, 33, 37, DateTimeKind.Utc).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 8, 21, 2, 33, 37, DateTimeKind.Utc).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 8, 21, 2, 33, 37, DateTimeKind.Utc).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 8, 21, 2, 33, 37, DateTimeKind.Utc).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 8, 21, 2, 33, 37, DateTimeKind.Utc).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 8, 21, 2, 33, 37, DateTimeKind.Utc).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 8, 21, 2, 33, 37, DateTimeKind.Utc).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 8, 21, 2, 33, 37, DateTimeKind.Utc).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 8, 21, 2, 33, 37, DateTimeKind.Utc).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 8, 21, 2, 33, 37, DateTimeKind.Utc).AddTicks(3269));
        }
    }
}
