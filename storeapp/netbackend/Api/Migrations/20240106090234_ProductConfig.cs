using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    public partial class ProductConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Products",
                type: "TEXT",
                nullable: true,
                defaultValue: "/images/default.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AtCreatedDate", "ImageURL" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 2, 34, 240, DateTimeKind.Local).AddTicks(8165), "/images/1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AtCreatedDate", "ImageURL" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 2, 34, 240, DateTimeKind.Local).AddTicks(8177), "/images/2.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AtCreatedDate", "ImageURL" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 2, 34, 240, DateTimeKind.Local).AddTicks(8179), "/images/3.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AtCreatedDate", "ImageURL" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 2, 34, 240, DateTimeKind.Local).AddTicks(8180), "/images/4.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AtCreatedDate", "ImageURL" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 2, 34, 240, DateTimeKind.Local).AddTicks(8181), "/images/5.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AtCreatedDate",
                value: new DateTime(2024, 1, 6, 11, 20, 20, 575, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AtCreatedDate",
                value: new DateTime(2024, 1, 6, 11, 20, 20, 575, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AtCreatedDate",
                value: new DateTime(2024, 1, 6, 11, 20, 20, 575, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "AtCreatedDate",
                value: new DateTime(2024, 1, 6, 11, 20, 20, 575, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "AtCreatedDate",
                value: new DateTime(2024, 1, 6, 11, 20, 20, 575, DateTimeKind.Local).AddTicks(3812));
        }
    }
}
