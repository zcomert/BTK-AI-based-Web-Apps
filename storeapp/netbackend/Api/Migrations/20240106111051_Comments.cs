using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    public partial class Comments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Comments",
                columns: new[] { "CommentId", "AtCreatedDate", "ProductId", "Text" },
                values: new object[] { 1, new DateTime(2024, 1, 6, 14, 10, 50, 978, DateTimeKind.Local).AddTicks(2143), 1, "Harika bir ürün." });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "AtCreatedDate", "ProductId", "Text" },
                values: new object[] { 2, new DateTime(2024, 1, 6, 14, 10, 50, 978, DateTimeKind.Local).AddTicks(2157), 1, "Harika bir ürün, kesinlikle tavsiye ediyorum." });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "AtCreatedDate", "ProductId", "Text" },
                values: new object[] { 3, new DateTime(2024, 1, 6, 14, 10, 50, 978, DateTimeKind.Local).AddTicks(2158), 1, "Kargo biraz gecikti ama beklediğime değdi. Teşekkürler" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AtCreatedDate",
                value: new DateTime(2024, 1, 6, 14, 10, 50, 978, DateTimeKind.Local).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AtCreatedDate",
                value: new DateTime(2024, 1, 6, 14, 10, 50, 978, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AtCreatedDate",
                value: new DateTime(2024, 1, 6, 14, 10, 50, 978, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "AtCreatedDate",
                value: new DateTime(2024, 1, 6, 14, 10, 50, 978, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "AtCreatedDate",
                value: new DateTime(2024, 1, 6, 14, 10, 50, 978, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AtCreatedDate",
                value: new DateTime(2024, 1, 6, 12, 2, 34, 240, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AtCreatedDate",
                value: new DateTime(2024, 1, 6, 12, 2, 34, 240, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AtCreatedDate",
                value: new DateTime(2024, 1, 6, 12, 2, 34, 240, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "AtCreatedDate",
                value: new DateTime(2024, 1, 6, 12, 2, 34, 240, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "AtCreatedDate",
                value: new DateTime(2024, 1, 6, 12, 2, 34, 240, DateTimeKind.Local).AddTicks(8181));
        }
    }
}
