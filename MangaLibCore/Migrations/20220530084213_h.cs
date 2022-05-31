using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
