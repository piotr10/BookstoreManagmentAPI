using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class addedJsonIgnoreToOrderPriceV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 34, 36, 283, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 34, 36, 283, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 34, 36, 283, DateTimeKind.Local).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 34, 36, 283, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 34, 36, 283, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 34, 36, 283, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 34, 36, 283, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 34, 36, 283, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 34, 36, 283, DateTimeKind.Local).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 34, 36, 283, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 34, 36, 283, DateTimeKind.Local).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 34, 36, 283, DateTimeKind.Local).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 34, 36, 283, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 34, 36, 283, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 34, 36, 283, DateTimeKind.Local).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 34, 36, 283, DateTimeKind.Local).AddTicks(3521));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 29, 33, 338, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 29, 33, 338, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 29, 33, 338, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 29, 33, 338, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 29, 33, 338, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 29, 33, 338, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 29, 33, 338, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 29, 33, 338, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 29, 33, 338, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 29, 33, 338, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 29, 33, 338, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 29, 33, 338, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 29, 33, 338, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 29, 33, 338, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 29, 33, 338, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 29, 33, 338, DateTimeKind.Local).AddTicks(2734));
        }
    }
}
