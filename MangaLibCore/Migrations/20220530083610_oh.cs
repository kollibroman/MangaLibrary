using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class oh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Mangas",
                table: "Categories",
                type: "text",
                nullable: false,
                oldClrType: typeof(List<string>),
                oldType: "text[]");

            migrationBuilder.AlterColumn<string>(
                name: "WrittenMangas",
                table: "Authors",
                type: "text",
                nullable: false,
                oldClrType: typeof(List<string>),
                oldType: "text[]");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name", "Surname", "UpdatedAt", "WrittenMangas" },
                values: new object[,]
                {
                    { 1, "Kei", "Urana", new DateTime(2022, 5, 30, 10, 36, 9, 448, DateTimeKind.Local).AddTicks(9572), "[\"Soul Eater\",\"Fire Force\",\"Gachiakuta\"]" },
                    { 2, "Kouhei", "Horikoshi", new DateTime(2022, 5, 30, 10, 36, 9, 448, DateTimeKind.Local).AddTicks(9584), "[\"Boku no Hero Academia\"]" },
                    { 3, "KAGYU", "Kumo", new DateTime(2022, 5, 30, 10, 36, 9, 448, DateTimeKind.Local).AddTicks(9590), "[\"Goblin Slayer\"]" },
                    { 4, "Yabako", "Sandrovich", new DateTime(2022, 5, 30, 10, 36, 9, 448, DateTimeKind.Local).AddTicks(9598), "[\"Kengan Ashua\",\"Kengan Omega\"]" },
                    { 5, "Minami", "Katsuhusa", new DateTime(2022, 5, 30, 10, 36, 9, 448, DateTimeKind.Local).AddTicks(9605), "[\"The Fable\"]" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Mangas", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "[\"some manga\"]", "Shounen", new DateTime(2022, 5, 30, 10, 36, 9, 448, DateTimeKind.Local).AddTicks(9219) },
                    { 2, "[\"some manga\"]", "Shoujo", new DateTime(2022, 5, 30, 10, 36, 9, 448, DateTimeKind.Local).AddTicks(9309) },
                    { 3, "[\"some manga\"]", "Seinen", new DateTime(2022, 5, 30, 10, 36, 9, 448, DateTimeKind.Local).AddTicks(9316) },
                    { 4, "[\"some manga\"]", "Comedy", new DateTime(2022, 5, 30, 10, 36, 9, 448, DateTimeKind.Local).AddTicks(9322) },
                    { 5, "[\"some manga\"]", "Action", new DateTime(2022, 5, 30, 10, 36, 9, 448, DateTimeKind.Local).AddTicks(9328) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<List<string>>(
                name: "Mangas",
                table: "Categories",
                type: "text[]",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<List<string>>(
                name: "WrittenMangas",
                table: "Authors",
                type: "text[]",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
