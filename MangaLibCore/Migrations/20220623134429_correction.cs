using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class correction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PageTitle",
                table: "Pages");

            migrationBuilder.AddColumn<string>(
                name: "MangaName",
                table: "Chapters",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 44, 28, 254, DateTimeKind.Utc).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 44, 28, 254, DateTimeKind.Utc).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 44, 28, 254, DateTimeKind.Utc).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 44, 28, 254, DateTimeKind.Utc).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 44, 28, 254, DateTimeKind.Utc).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 44, 28, 254, DateTimeKind.Utc).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 44, 28, 254, DateTimeKind.Utc).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 44, 28, 254, DateTimeKind.Utc).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 44, 28, 254, DateTimeKind.Utc).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 44, 28, 254, DateTimeKind.Utc).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 44, 28, 254, DateTimeKind.Utc).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 15, 44, 28, 254, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 15, 44, 28, 254, DateTimeKind.Local).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 15, 44, 28, 254, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 15, 44, 28, 254, DateTimeKind.Local).AddTicks(2941));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MangaName",
                table: "Chapters");

            migrationBuilder.AddColumn<string>(
                name: "PageTitle",
                table: "Pages",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 19, 39, 12, 986, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 19, 39, 12, 986, DateTimeKind.Utc).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 19, 39, 12, 986, DateTimeKind.Utc).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 19, 39, 12, 986, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 19, 39, 12, 986, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 19, 39, 12, 986, DateTimeKind.Utc).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 19, 39, 12, 986, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 19, 39, 12, 986, DateTimeKind.Utc).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 19, 39, 12, 986, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 19, 39, 12, 986, DateTimeKind.Utc).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 19, 39, 12, 986, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 21, 39, 12, 986, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 21, 39, 12, 986, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 21, 39, 12, 986, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 21, 39, 12, 986, DateTimeKind.Local).AddTicks(7153));
        }
    }
}
