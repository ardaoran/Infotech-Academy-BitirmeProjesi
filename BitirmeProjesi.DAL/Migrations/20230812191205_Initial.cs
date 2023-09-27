using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BitirmeProjesi.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "Varchar(32)", maxLength: 32, nullable: false),
                    NameSurname = table.Column<string>(type: "Varchar(32)", maxLength: 32, nullable: false),
                    LastLongDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLoginIP = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Slide",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Slogan1 = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: false),
                    Picture = table.Column<string>(type: "Varchar(150)", maxLength: 150, nullable: false),
                    Link = table.Column<string>(type: "Varchar(150)", maxLength: 150, nullable: false),
                    DisplayIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slide", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "ID", "LastLoginIP", "LastLongDate", "NameSurname", "Password", "UserName" },
                values: new object[] { 1, "", new DateTime(2023, 8, 12, 22, 12, 5, 786, DateTimeKind.Local).AddTicks(6427), "Arda Oran", "202cb962ac59075b964b07152d234b70", "arda" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Slide");
        }
    }
}
