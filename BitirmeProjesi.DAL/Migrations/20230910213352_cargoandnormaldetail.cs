using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BitirmeProjesi.DAL.Migrations
{
    /// <inheritdoc />
    public partial class cargoandnormaldetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CargoDetail",
                table: "Product",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "Product",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastLongDate",
                value: new DateTime(2023, 9, 11, 0, 33, 52, 36, DateTimeKind.Local).AddTicks(551));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CargoDetail",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Detail",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastLongDate",
                value: new DateTime(2023, 9, 10, 21, 32, 50, 232, DateTimeKind.Local).AddTicks(5505));
        }
    }
}
