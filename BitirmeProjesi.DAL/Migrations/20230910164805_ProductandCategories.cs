using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BitirmeProjesi.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ProductandCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "ProductPicture",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastLongDate",
                value: new DateTime(2023, 9, 10, 19, 48, 4, 960, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.CreateIndex(
                name: "IX_ProductPicture_ProductID",
                table: "ProductPicture",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPicture_Product_ProductID",
                table: "ProductPicture",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductPicture_Product_ProductID",
                table: "ProductPicture");

            migrationBuilder.DropIndex(
                name: "IX_ProductPicture_ProductID",
                table: "ProductPicture");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "ProductPicture");

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastLongDate",
                value: new DateTime(2023, 9, 10, 19, 35, 29, 643, DateTimeKind.Local).AddTicks(8892));
        }
    }
}
