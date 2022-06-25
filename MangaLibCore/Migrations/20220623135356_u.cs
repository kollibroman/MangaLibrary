using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class u : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChapterName",
                table: "Chapters",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 53, 55, 876, DateTimeKind.Utc).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 53, 55, 876, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 53, 55, 876, DateTimeKind.Utc).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 53, 55, 876, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 53, 55, 876, DateTimeKind.Utc).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 53, 55, 876, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 53, 55, 876, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 53, 55, 876, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 53, 55, 876, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 53, 55, 876, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 53, 55, 876, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 15, 53, 55, 876, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 15, 53, 55, 876, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 15, 53, 55, 876, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 15, 53, 55, 876, DateTimeKind.Local).AddTicks(4898));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChapterName",
                table: "Chapters");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 49, 48, 716, DateTimeKind.Utc).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 49, 48, 716, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 49, 48, 716, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 49, 48, 716, DateTimeKind.Utc).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 49, 48, 716, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 49, 48, 716, DateTimeKind.Utc).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 49, 48, 716, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 49, 48, 716, DateTimeKind.Utc).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 49, 48, 716, DateTimeKind.Utc).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 49, 48, 716, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 13, 49, 48, 716, DateTimeKind.Utc).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 15, 49, 48, 716, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 15, 49, 48, 716, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 15, 49, 48, 716, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 23, 15, 49, 48, 717, DateTimeKind.Local));
        }
    }
}
