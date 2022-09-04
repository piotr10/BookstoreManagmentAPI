using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class addedNewSeedDataV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 1, 2, 20, 52, 705, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 1, 2, 20, 52, 705, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 1, 2, 20, 52, 705, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 1, 2, 20, 52, 705, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 1, 2, 20, 52, 705, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 1, 2, 20, 52, 705, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 1, 2, 20, 52, 705, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 1, 2, 20, 52, 705, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 1, 2, 20, 52, 705, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "StatusId" },
                values: new object[] { new DateTime(2022, 9, 1, 2, 20, 52, 705, DateTimeKind.Local).AddTicks(9867), 1 });

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 1, 2, 20, 52, 705, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 1, 2, 20, 52, 705, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 1, 2, 20, 52, 705, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 1, 2, 20, 52, 705, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 1, 2, 20, 52, 705, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BookId", "Created", "CreatedBy", "CustomerId", "DeliveryDate", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "OrderDate", "OrderPrice", "OrderTransportTypeId", "PaymentMethodId", "Quantity", "StatusId" },
                values: new object[] { 2, 2, new DateTime(2022, 9, 1, 2, 20, 52, 705, DateTimeKind.Local).AddTicks(9963), "", 2, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", null, "", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33m, 2, 1, 2, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 1, 0, 10, 27, 124, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 1, 0, 10, 27, 124, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 1, 0, 10, 27, 124, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 1, 0, 10, 27, 124, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 1, 0, 10, 27, 124, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 1, 0, 10, 27, 124, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 1, 0, 10, 27, 124, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 1, 0, 10, 27, 124, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 1, 0, 10, 27, 124, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "StatusId" },
                values: new object[] { new DateTime(2022, 9, 1, 0, 10, 27, 124, DateTimeKind.Local).AddTicks(6554), 2 });

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 1, 0, 10, 27, 124, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 1, 0, 10, 27, 124, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 1, 0, 10, 27, 124, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 1, 0, 10, 27, 124, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 1, 0, 10, 27, 124, DateTimeKind.Local).AddTicks(6595));
        }
    }
}
