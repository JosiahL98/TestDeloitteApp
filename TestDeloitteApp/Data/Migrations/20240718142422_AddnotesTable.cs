using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestDeloitteApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddnotesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaseDiaryNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CaseDiaryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Line1 = table.Column<string>(type: "TEXT", nullable: true),
                    Line2 = table.Column<string>(type: "TEXT", nullable: true),
                    Line3 = table.Column<string>(type: "TEXT", nullable: true),
                    Line4 = table.Column<string>(type: "TEXT", nullable: true),
                    Line5 = table.Column<string>(type: "TEXT", nullable: true),
                    Line6 = table.Column<string>(type: "TEXT", nullable: true),
                    Line7 = table.Column<string>(type: "TEXT", nullable: true),
                    Line8 = table.Column<string>(type: "TEXT", nullable: true),
                    Line9 = table.Column<string>(type: "TEXT", nullable: true),
                    Line10 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseDiaryNotes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "CaseDiaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 18, 10, 24, 22, 203, DateTimeKind.Local).AddTicks(3422), new DateTime(2024, 7, 18, 10, 24, 22, 203, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "CaseDiaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 18, 10, 24, 22, 203, DateTimeKind.Local).AddTicks(3431), new DateTime(2024, 7, 18, 10, 24, 22, 203, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "CaseDiaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 18, 10, 24, 22, 203, DateTimeKind.Local).AddTicks(3439), new DateTime(2024, 7, 18, 10, 24, 22, 203, DateTimeKind.Local).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "CaseDiaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 18, 10, 24, 22, 203, DateTimeKind.Local).AddTicks(3447), new DateTime(2024, 7, 18, 10, 24, 22, 203, DateTimeKind.Local).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "CaseDiaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 18, 10, 24, 22, 203, DateTimeKind.Local).AddTicks(3453), new DateTime(2024, 7, 18, 10, 24, 22, 203, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "CaseDiaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DueDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 18, 10, 24, 22, 203, DateTimeKind.Local).AddTicks(3460), new DateTime(2024, 7, 18, 10, 24, 22, 203, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "CaseDiaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DueDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 18, 10, 24, 22, 203, DateTimeKind.Local).AddTicks(3467), new DateTime(2024, 7, 18, 10, 24, 22, 203, DateTimeKind.Local).AddTicks(3464) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaseDiaryNotes");

            migrationBuilder.UpdateData(
                table: "CaseDiaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DueDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1219), new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "CaseDiaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1228), new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1226) });

            migrationBuilder.UpdateData(
                table: "CaseDiaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1236), new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "CaseDiaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DueDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1240), new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "CaseDiaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DueDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1244), new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "CaseDiaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DueDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1249), new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "CaseDiaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DueDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1253), new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1252) });
        }
    }
}
