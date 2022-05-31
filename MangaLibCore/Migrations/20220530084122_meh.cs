using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class meh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 41, 21, 817, DateTimeKind.Utc).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 41, 21, 817, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 41, 21, 817, DateTimeKind.Utc).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 41, 21, 817, DateTimeKind.Utc).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 41, 21, 817, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 41, 21, 817, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 41, 21, 817, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 41, 21, 817, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 41, 21, 817, DateTimeKind.Utc).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 5, 30, 8, 41, 21, 817, DateTimeKind.Utc).AddTicks(3920));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
