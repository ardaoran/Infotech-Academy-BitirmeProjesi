using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BitirmeProjesi.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Category2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentID",
                table: "Category",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastLongDate",
                value: new DateTime(2023, 9, 9, 20, 51, 39, 356, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.CreateIndex(
                name: "IX_Category_ParentID",
                table: "Category",
                column: "ParentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Category_ParentID",
                table: "Category",
                column: "ParentID",
                principalTable: "Category",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Category_ParentID",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_ParentID",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ParentID",
                table: "Category");

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastLongDate",
                value: new DateTime(2023, 9, 9, 15, 50, 31, 706, DateTimeKind.Local).AddTicks(7303));
        }
    }
}
