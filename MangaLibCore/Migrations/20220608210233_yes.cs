using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class yes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedAt",
                table: "Mangas");

            migrationBuilder.DropColumn(
                name: "Chapters",
                table: "Mangas");

            migrationBuilder.DropColumn(
                name: "Cover",
                table: "Mangas");

            migrationBuilder.RenameColumn(
                name: "PagesCount",
                table: "Mangas",
                newName: "Type");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Mangas",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<string>(
                name: "PublishedAt",
                table: "Mangas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Categories",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Authors",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

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

            migrationBuilder.InsertData(
                table: "Mangas",
                columns: new[] { "Id", "Author", "ChaptersCount", "Description", "PublishedAt", "Title", "Type", "UpdatedAt" },
                values: new object[] { 1, "Minami Katsuhisa", 206, "some description", "01/11/2014", "The Fable", 0, new DateTime(2022, 6, 8, 21, 2, 33, 37, DateTimeKind.Utc).AddTicks(3269) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "PublishedAt",
                table: "Mangas");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Mangas",
                newName: "PagesCount");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Mangas",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedAt",
                table: "Mangas",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<List<string>>(
                name: "Chapters",
                table: "Mangas",
                type: "text[]",
                nullable: false);

            migrationBuilder.AddColumn<byte[]>(
                name: "Cover",
                table: "Mangas",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Authors",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 42, 12, 611, DateTimeKind.Utc).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 42, 12, 611, DateTimeKind.Utc).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 42, 12, 611, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 42, 12, 611, DateTimeKind.Utc).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 42, 12, 611, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 42, 12, 611, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 42, 12, 611, DateTimeKind.Utc).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 42, 12, 611, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 42, 12, 611, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 42, 12, 611, DateTimeKind.Utc).AddTicks(3087));
        }
    }
}
