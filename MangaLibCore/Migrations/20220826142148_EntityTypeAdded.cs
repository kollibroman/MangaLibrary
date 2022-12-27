using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class EntityTypeAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Pages",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Cover",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Chapters",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Authors",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Type", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2022, 8, 26, 14, 21, 47, 839, DateTimeKind.Utc).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Type", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2022, 8, 26, 14, 21, 47, 839, DateTimeKind.Utc).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Type", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2022, 8, 26, 14, 21, 47, 839, DateTimeKind.Utc).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Type", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2022, 8, 26, 14, 21, 47, 839, DateTimeKind.Utc).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Type", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2022, 8, 26, 14, 21, 47, 839, DateTimeKind.Utc).AddTicks(287) });

            migrationBuilder.UpdateData(
                table: "Cover",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Cover",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Cover",
                keyColumn: "Id",
                keyValue: 3,
                column: "Type",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Cover",
                keyColumn: "Id",
                keyValue: 4,
                column: "Type",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Cover",
                keyColumn: "Id",
                keyValue: 5,
                column: "Type",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 26, 14, 21, 47, 839, DateTimeKind.Utc).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 26, 14, 21, 47, 839, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 26, 14, 21, 47, 839, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 26, 14, 21, 47, 839, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 26, 14, 21, 47, 839, DateTimeKind.Local).AddTicks(434));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Cover");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Authors");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 13, 23, 0, 0, 747, DateTimeKind.Utc).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 13, 23, 0, 0, 747, DateTimeKind.Utc).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 13, 23, 0, 0, 747, DateTimeKind.Utc).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 13, 23, 0, 0, 747, DateTimeKind.Utc).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 13, 23, 0, 0, 747, DateTimeKind.Utc).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 13, 23, 0, 0, 747, DateTimeKind.Utc).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 13, 23, 0, 0, 747, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 13, 23, 0, 0, 747, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 13, 23, 0, 0, 747, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 13, 23, 0, 0, 747, DateTimeKind.Local).AddTicks(9628));
        }
    }
}
