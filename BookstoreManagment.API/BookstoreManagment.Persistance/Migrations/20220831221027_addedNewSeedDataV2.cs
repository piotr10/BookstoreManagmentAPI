using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class addedNewSeedDataV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "CustomerAddresses",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId" },
                values: new object[] { 2, new DateTime(2022, 9, 1, 0, 10, 27, 124, DateTimeKind.Local).AddTicks(6554), "", null, "", null, "", 2 });

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 1, 0, 10, 27, 124, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.InsertData(
                table: "CustomerDetails",
                columns: new[] { "Id", "Created", "CreatedBy", "CustomerAddressTypeId", "CustomerDetailTypeId", "CustomerId", "DetailContact", "FirstName", "Inactivated", "InactivatedBy", "LastName", "Modified", "ModifiedBy", "StatusId", "ApartmentNumber", "City", "Country", "HouseNumber", "Street", "ZipCode" },
                values: new object[] { 2, new DateTime(2022, 9, 1, 0, 10, 27, 124, DateTimeKind.Local).AddTicks(6414), "", 2, 2, 2, "olaSa@example.com", "Ola", null, "", "Sa", null, "", 1, 10, "Cracow", "Poland", 10, "Krakowska", "01-001" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 34, 12, 501, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 34, 12, 501, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 34, 12, 501, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 34, 12, 501, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 34, 12, 501, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 34, 12, 501, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 34, 12, 501, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 34, 12, 501, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 34, 12, 501, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 34, 12, 501, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 34, 12, 501, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 34, 12, 501, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 34, 12, 501, DateTimeKind.Local).AddTicks(5206));
        }
    }
}
