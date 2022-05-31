using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class ah : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 37, 28, 276, DateTimeKind.Utc).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 37, 28, 276, DateTimeKind.Utc).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 37, 28, 276, DateTimeKind.Utc).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 37, 28, 276, DateTimeKind.Utc).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 37, 28, 276, DateTimeKind.Utc).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 37, 28, 276, DateTimeKind.Utc).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 37, 28, 276, DateTimeKind.Utc).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 37, 28, 276, DateTimeKind.Utc).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 37, 28, 276, DateTimeKind.Utc).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 37, 28, 276, DateTimeKind.Utc).AddTicks(5010));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 10, 36, 9, 448, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 10, 36, 9, 448, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 10, 36, 9, 448, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 10, 36, 9, 448, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 10, 36, 9, 448, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 10, 36, 9, 448, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 10, 36, 9, 448, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 10, 36, 9, 448, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 10, 36, 9, 448, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 10, 36, 9, 448, DateTimeKind.Local).AddTicks(9328));
        }
    }
}
