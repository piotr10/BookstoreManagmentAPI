using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class removeCustomerAddressTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerAddresses",
                table: "CustomerAddresses");

            migrationBuilder.RenameTable(
                name: "CustomerAddresses",
                newName: "CustomerAddress");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerAddress",
                table: "CustomerAddress",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 171, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "CustomerAddress",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "CustomerAddress",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(9142));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerAddress",
                table: "CustomerAddress");

            migrationBuilder.RenameTable(
                name: "CustomerAddress",
                newName: "CustomerAddresses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerAddresses",
                table: "CustomerAddresses",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2459));
        }
    }
}
