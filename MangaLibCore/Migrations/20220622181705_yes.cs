using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class yes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cover_Mangas_MangaId",
                table: "Cover");

            migrationBuilder.DropIndex(
                name: "IX_Cover_MangaId",
                table: "Cover");

            migrationBuilder.DropColumn(
                name: "MangaId",
                table: "Cover");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 18, 17, 4, 472, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 18, 17, 4, 472, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 18, 17, 4, 472, DateTimeKind.Utc).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 18, 17, 4, 472, DateTimeKind.Utc).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 18, 17, 4, 472, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 18, 17, 4, 472, DateTimeKind.Utc).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 18, 17, 4, 472, DateTimeKind.Utc).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 18, 17, 4, 472, DateTimeKind.Utc).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 18, 17, 4, 472, DateTimeKind.Utc).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 18, 17, 4, 472, DateTimeKind.Utc).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 18, 17, 4, 472, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 20, 17, 4, 472, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 20, 17, 4, 472, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 20, 17, 4, 472, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 22, 20, 17, 4, 472, DateTimeKind.Local).AddTicks(7018));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MangaId",
                table: "Cover",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 21, 20, 59, 54, 893, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 21, 20, 59, 54, 893, DateTimeKind.Utc).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 21, 20, 59, 54, 893, DateTimeKind.Utc).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 21, 20, 59, 54, 893, DateTimeKind.Utc).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 21, 20, 59, 54, 893, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 21, 20, 59, 54, 893, DateTimeKind.Utc).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 21, 20, 59, 54, 893, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 21, 20, 59, 54, 893, DateTimeKind.Utc).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 21, 20, 59, 54, 893, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 21, 20, 59, 54, 893, DateTimeKind.Utc).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 21, 20, 59, 54, 893, DateTimeKind.Utc).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 21, 22, 59, 54, 893, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 21, 22, 59, 54, 893, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 21, 22, 59, 54, 893, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 6, 21, 22, 59, 54, 893, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.CreateIndex(
                name: "IX_Cover_MangaId",
                table: "Cover",
                column: "MangaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cover_Mangas_MangaId",
                table: "Cover",
                column: "MangaId",
                principalTable: "Mangas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
