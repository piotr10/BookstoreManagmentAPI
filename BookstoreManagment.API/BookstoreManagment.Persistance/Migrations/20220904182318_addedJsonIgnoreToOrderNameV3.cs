using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class addedJsonIgnoreToOrderNameV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 23, 17, 527, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 23, 17, 527, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 23, 17, 527, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 23, 17, 527, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 23, 17, 527, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 23, 17, 527, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 23, 17, 527, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 23, 17, 527, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 23, 17, 527, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 23, 17, 527, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 23, 17, 527, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 23, 17, 527, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 23, 17, 527, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 23, 17, 527, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 23, 17, 527, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 23, 17, 527, DateTimeKind.Local).AddTicks(6220));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 18, 30, 447, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 18, 30, 447, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 18, 30, 447, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 18, 30, 447, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 18, 30, 447, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 18, 30, 447, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 18, 30, 447, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 18, 30, 447, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 18, 30, 448, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 18, 30, 448, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 18, 30, 448, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 18, 30, 448, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 18, 30, 447, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 18, 30, 447, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 18, 30, 448, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 18, 30, 448, DateTimeKind.Local).AddTicks(235));
        }
    }
}
