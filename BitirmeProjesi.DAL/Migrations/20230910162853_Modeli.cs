using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BitirmeProjesi.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Modeli : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Product",
                newName: "Modeli");

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastLongDate",
                value: new DateTime(2023, 9, 10, 19, 28, 52, 978, DateTimeKind.Local).AddTicks(9044));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Modeli",
                table: "Product",
                newName: "Model");

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastLongDate",
                value: new DateTime(2023, 9, 10, 18, 53, 20, 237, DateTimeKind.Local).AddTicks(3309));
        }
    }
}
