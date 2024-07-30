using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestDeloitteApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaseDiaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CaseId = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DueDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Function = table.Column<string>(type: "TEXT", nullable: false),
                    SubFunction = table.Column<string>(type: "TEXT", nullable: false),
                    Open = table.Column<string>(type: "TEXT", nullable: false),
                    Prim = table.Column<string>(type: "TEXT", nullable: false),
                    Mother = table.Column<string>(type: "TEXT", nullable: false),
                    Father = table.Column<string>(type: "TEXT", nullable: false),
                    MotherViolence = table.Column<bool>(type: "INTEGER", nullable: false),
                    FatherViolence = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseDiaries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CaseDiaries",
                columns: new[] { "Id", "CaseId", "DueDate", "Father", "FatherViolence", "Function", "Mother", "MotherViolence", "Open", "Prim", "StartDate", "SubFunction" },
                values: new object[,]
                {
                    { 1, "2323", new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1219), "asassa", false, "aaaaa", "asassa", true, "Yes", "No", new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1177), "bbbb" },
                    { 2, "2323", new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1228), "asassa", false, "aaaaa", "asassa", true, "Yes", "No", new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1226), "bbbb" },
                    { 3, "2323", new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1236), "asassa", false, "aaaaa", "asassa", true, "Yes", "No", new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1232), "bbbb" },
                    { 4, "2323", new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1240), "asassa", false, "aaaaa", "asassa", true, "Yes", "No", new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1238), "bbbb" },
                    { 5, "2323", new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1244), "asassa", false, "aaaaa", "asassa", true, "Yes", "No", new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1243), "bbbb" },
                    { 6, "111", new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1249), "asassa", false, "aaaaa", "asassa", true, "Yes", "No", new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1247), "bbbb" },
                    { 7, "111", new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1253), "asassa", false, "aaaaa", "asassa", true, "Yes", "No", new DateTime(2024, 7, 17, 15, 26, 42, 39, DateTimeKind.Local).AddTicks(1252), "bbbb" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaseDiaries");
        }
    }
}
