using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class yeeet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 13, 22, 57, 17, 20, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 13, 22, 57, 17, 20, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 13, 22, 57, 17, 20, DateTimeKind.Utc).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 13, 22, 57, 17, 20, DateTimeKind.Utc).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 13, 22, 57, 17, 20, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 13, 22, 57, 17, 20, DateTimeKind.Utc).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 13, 22, 57, 17, 20, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 13, 22, 57, 17, 20, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 13, 22, 57, 17, 20, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 13, 22, 57, 17, 20, DateTimeKind.Local).AddTicks(8165));
        }
    }
}
