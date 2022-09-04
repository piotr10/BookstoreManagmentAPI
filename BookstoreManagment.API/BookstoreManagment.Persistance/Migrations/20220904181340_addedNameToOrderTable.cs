using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class addedNameToOrderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 13, 39, 470, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 13, 39, 470, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 13, 39, 470, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 13, 39, 470, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 13, 39, 470, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 13, 39, 470, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 13, 39, 470, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 13, 39, 470, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 13, 39, 470, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 13, 39, 470, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 13, 39, 470, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 13, 39, 470, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 13, 39, 470, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 13, 39, 470, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 20, 13, 39, 470, DateTimeKind.Local).AddTicks(6682), "Ogniem i Mieczem" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 20, 13, 39, 470, DateTimeKind.Local).AddTicks(6687), "Potop" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 19, 58, 15, 19, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 19, 58, 15, 19, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 19, 58, 15, 19, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 19, 58, 15, 19, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 19, 58, 15, 19, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 19, 58, 15, 19, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 19, 58, 15, 19, DateTimeKind.Local).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 19, 58, 15, 19, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 19, 58, 15, 19, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 19, 58, 15, 19, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 19, 58, 15, 19, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 19, 58, 15, 19, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 19, 58, 15, 19, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 19, 58, 15, 19, DateTimeKind.Local).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 19, 58, 15, 19, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 19, 58, 15, 19, DateTimeKind.Local).AddTicks(1957));
        }
    }
}
