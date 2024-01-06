using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    public partial class Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    AtCreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AtCreatedDate", "Name", "Price" },
                values: new object[] { 1, new DateTime(2023, 12, 31, 17, 7, 1, 799, DateTimeKind.Local).AddTicks(5123), "Laptop", 1500m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AtCreatedDate", "Name", "Price" },
                values: new object[] { 2, new DateTime(2023, 12, 31, 17, 7, 1, 799, DateTimeKind.Local).AddTicks(5138), "Smartphone", 800m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AtCreatedDate", "Name", "Price" },
                values: new object[] { 3, new DateTime(2023, 12, 31, 17, 7, 1, 799, DateTimeKind.Local).AddTicks(5140), "Headphones", 100m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AtCreatedDate", "Name", "Price" },
                values: new object[] { 4, new DateTime(2023, 12, 31, 17, 7, 1, 799, DateTimeKind.Local).AddTicks(5141), "Tablet", 600m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AtCreatedDate", "Name", "Price" },
                values: new object[] { 5, new DateTime(2023, 12, 31, 17, 7, 1, 799, DateTimeKind.Local).AddTicks(5142), "Smartwatch", 300m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
