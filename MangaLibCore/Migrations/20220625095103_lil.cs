using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class lil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Chapters_ChapterId",
                table: "Pages");

            migrationBuilder.AlterColumn<int>(
                name: "ChapterId",
                table: "Pages",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 25, 9, 51, 2, 577, DateTimeKind.Utc).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 25, 9, 51, 2, 577, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 25, 9, 51, 2, 577, DateTimeKind.Utc).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 25, 9, 51, 2, 577, DateTimeKind.Utc).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 25, 9, 51, 2, 577, DateTimeKind.Utc).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 25, 9, 51, 2, 577, DateTimeKind.Utc).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 25, 9, 51, 2, 577, DateTimeKind.Utc).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 25, 9, 51, 2, 577, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 25, 9, 51, 2, 577, DateTimeKind.Utc).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 25, 9, 51, 2, 577, DateTimeKind.Utc).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 25, 9, 51, 2, 577, DateTimeKind.Utc).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 25, 11, 51, 2, 577, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 25, 11, 51, 2, 577, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 25, 11, 51, 2, 577, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 25, 11, 51, 2, 577, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Chapters_ChapterId",
                table: "Pages",
                column: "ChapterId",
                principalTable: "Chapters",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Chapters_ChapterId",
                table: "Pages");

            migrationBuilder.AlterColumn<int>(
                name: "ChapterId",
                table: "Pages",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Chapters_ChapterId",
                table: "Pages",
                column: "ChapterId",
                principalTable: "Chapters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
