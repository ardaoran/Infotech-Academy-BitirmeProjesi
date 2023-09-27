using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BitirmeProjesi.DAL.Migrations
{
    /// <inheritdoc />
    public partial class stttringlenghtupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "Product",
                type: "Varchar(MAX)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(8000)",
                oldMaxLength: 8000);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastLongDate",
                value: new DateTime(2023, 9, 19, 2, 52, 59, 747, DateTimeKind.Local).AddTicks(6703));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "Product",
                type: "Varchar(8000)",
                maxLength: 8000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(MAX)");

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastLongDate",
                value: new DateTime(2023, 9, 19, 2, 50, 55, 646, DateTimeKind.Local).AddTicks(8601));
        }
    }
}
