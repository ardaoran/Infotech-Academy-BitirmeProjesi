using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BitirmeProjesi.DAL.Migrations
{
    /// <inheritdoc />
    public partial class OrderandOrderDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "ProductPicture",
                type: "Varchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(150)",
                oldMaxLength: 150);

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true),
                    PaymentOption = table.Column<int>(type: "int", nullable: false),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    RecDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    Distirct = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    Country = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    ZipCode = table.Column<string>(type: "Varchar(10)", maxLength: 10, nullable: true),
                    Phone = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true),
                    MailAddress = table.Column<string>(type: "Varchar(80)", maxLength: 80, nullable: true),
                    NameSurname = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    ShipFee = table.Column<decimal>(type: "decimal(18,2)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    ProductPicture = table.Column<string>(type: "Varchar(150)", maxLength: 150, nullable: true),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastLongDate",
                value: new DateTime(2023, 9, 17, 12, 49, 50, 504, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "ProductPicture",
                type: "Varchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "Varchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastLongDate",
                value: new DateTime(2023, 9, 11, 21, 43, 33, 526, DateTimeKind.Local).AddTicks(1460));
        }
    }
}
