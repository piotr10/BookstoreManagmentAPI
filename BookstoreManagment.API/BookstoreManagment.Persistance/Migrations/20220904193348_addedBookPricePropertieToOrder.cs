using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class addedBookPricePropertieToOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "BookPrice",
                table: "Orders",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookPrice", "Created" },
                values: new object[] { 10m, new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookPrice", "Created" },
                values: new object[] { 15m, new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8737) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookPrice",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 39, 15, 69, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 39, 15, 69, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 39, 15, 69, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 39, 15, 69, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 39, 15, 69, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 39, 15, 69, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 39, 15, 69, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 39, 15, 69, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 39, 15, 69, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 39, 15, 69, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 39, 15, 69, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 39, 15, 69, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 39, 15, 69, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 39, 15, 69, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 39, 15, 69, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 39, 15, 69, DateTimeKind.Local).AddTicks(9624));
        }
    }
}
