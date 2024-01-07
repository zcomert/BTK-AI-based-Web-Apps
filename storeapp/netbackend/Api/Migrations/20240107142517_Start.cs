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
                    ImageURL = table.Column<string>(type: "TEXT", nullable: true, defaultValue: "/images/default.jpg"),
                    AtCreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    AtCreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AtCreatedDate", "ImageURL", "Name", "Price" },
                values: new object[] { 1, new DateTime(2024, 1, 7, 17, 25, 17, 318, DateTimeKind.Local).AddTicks(2187), "/images/1.jpg", "Laptop", 1500m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AtCreatedDate", "ImageURL", "Name", "Price" },
                values: new object[] { 2, new DateTime(2024, 1, 7, 17, 25, 17, 318, DateTimeKind.Local).AddTicks(2192), "/images/2.jpg", "Smartphone", 800m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AtCreatedDate", "ImageURL", "Name", "Price" },
                values: new object[] { 3, new DateTime(2024, 1, 7, 17, 25, 17, 318, DateTimeKind.Local).AddTicks(2194), "/images/3.jpg", "Headphones", 100m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AtCreatedDate", "ImageURL", "Name", "Price" },
                values: new object[] { 4, new DateTime(2024, 1, 7, 17, 25, 17, 318, DateTimeKind.Local).AddTicks(2195), "/images/4.jpg", "Tablet", 600m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AtCreatedDate", "ImageURL", "Name", "Price" },
                values: new object[] { 5, new DateTime(2024, 1, 7, 17, 25, 17, 318, DateTimeKind.Local).AddTicks(2195), "/images/5.jpg", "Smartwatch", 300m });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "AtCreatedDate", "ProductId", "Text" },
                values: new object[] { 1, new DateTime(2024, 1, 7, 17, 25, 17, 318, DateTimeKind.Local).AddTicks(1324), 1, "Harika bir ürün." });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "AtCreatedDate", "ProductId", "Text" },
                values: new object[] { 2, new DateTime(2024, 1, 7, 17, 25, 17, 318, DateTimeKind.Local).AddTicks(1336), 1, "Harika bir ürün, kesinlikle tavsiye ediyorum." });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "AtCreatedDate", "ProductId", "Text" },
                values: new object[] { 3, new DateTime(2024, 1, 7, 17, 25, 17, 318, DateTimeKind.Local).AddTicks(1337), 1, "Kargo biraz gecikti ama beklediğime değdi. Teşekkürler" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
