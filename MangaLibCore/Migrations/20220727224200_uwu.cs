using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaLibCore.Migrations
{
    public partial class uwu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MangaId",
                table: "Cover",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 27, 22, 42, 0, 66, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 27, 22, 42, 0, 66, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 27, 22, 42, 0, 66, DateTimeKind.Utc).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 27, 22, 42, 0, 66, DateTimeKind.Utc).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 27, 22, 42, 0, 66, DateTimeKind.Utc).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 27, 22, 42, 0, 66, DateTimeKind.Utc).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 27, 22, 42, 0, 66, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 27, 22, 42, 0, 66, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 27, 22, 42, 0, 66, DateTimeKind.Utc).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 27, 22, 42, 0, 66, DateTimeKind.Utc).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 27, 22, 42, 0, 66, DateTimeKind.Utc).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 27, 22, 42, 0, 66, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 27, 22, 42, 0, 66, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 27, 22, 42, 0, 66, DateTimeKind.Local).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 27, 22, 42, 0, 66, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.CreateIndex(
                name: "IX_Cover_MangaId",
                table: "Cover",
                column: "MangaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cover_Mangas_MangaId",
                table: "Cover",
                column: "MangaId",
                principalTable: "Mangas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Utc).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2022, 7, 21, 22, 55, 45, 805, DateTimeKind.Local).AddTicks(7540));
        }
    }
}
