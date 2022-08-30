using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class changeCustomerAddressTypeRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddresses_CustomerAddressTypes_CustomerAddressTypeId",
                table: "CustomerAddresses");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAddresses_CustomerAddressTypeId",
                table: "CustomerAddresses");

            migrationBuilder.DropColumn(
                name: "CustomerAddressTypeId",
                table: "CustomerAddresses");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerAddressTypeId",
                table: "CustomerAddresses",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 28, 59, 187, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 28, 59, 187, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 28, 59, 187, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 28, 59, 187, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 28, 59, 187, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 28, 59, 187, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 28, 59, 187, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 28, 59, 187, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 28, 59, 187, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 28, 59, 187, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 28, 59, 187, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 28, 59, 187, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 28, 59, 187, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddresses_CustomerAddressTypeId",
                table: "CustomerAddresses",
                column: "CustomerAddressTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddresses_CustomerAddressTypes_CustomerAddressTypeId",
                table: "CustomerAddresses",
                column: "CustomerAddressTypeId",
                principalTable: "CustomerAddressTypes",
                principalColumn: "Id");
        }
    }
}
