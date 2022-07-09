using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class eh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MangaNamep",
                table: "Pages",
                newName: "MangaName");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 21, 12, 34, 488, DateTimeKind.Utc).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 21, 12, 34, 488, DateTimeKind.Utc).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 21, 12, 34, 488, DateTimeKind.Utc).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 21, 12, 34, 488, DateTimeKind.Utc).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 21, 12, 34, 488, DateTimeKind.Utc).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 21, 12, 34, 488, DateTimeKind.Utc).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 21, 12, 34, 488, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 21, 12, 34, 488, DateTimeKind.Utc).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 21, 12, 34, 488, DateTimeKind.Utc).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 21, 12, 34, 488, DateTimeKind.Utc).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 21, 12, 34, 488, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 21, 12, 34, 488, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 21, 12, 34, 488, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 21, 12, 34, 488, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 21, 12, 34, 488, DateTimeKind.Local).AddTicks(9365));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MangaName",
                table: "Pages",
                newName: "MangaNamep");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 15, 10, 25, 109, DateTimeKind.Utc).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 15, 10, 25, 109, DateTimeKind.Utc).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 15, 10, 25, 109, DateTimeKind.Utc).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 15, 10, 25, 109, DateTimeKind.Utc).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 15, 10, 25, 109, DateTimeKind.Utc).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 15, 10, 25, 109, DateTimeKind.Utc).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 15, 10, 25, 109, DateTimeKind.Utc).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 15, 10, 25, 109, DateTimeKind.Utc).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 15, 10, 25, 109, DateTimeKind.Utc).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 15, 10, 25, 109, DateTimeKind.Utc).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 15, 10, 25, 109, DateTimeKind.Utc).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 15, 10, 25, 109, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 15, 10, 25, 109, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 15, 10, 25, 109, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 9, 15, 10, 25, 109, DateTimeKind.Local).AddTicks(5671));
        }
    }
}
