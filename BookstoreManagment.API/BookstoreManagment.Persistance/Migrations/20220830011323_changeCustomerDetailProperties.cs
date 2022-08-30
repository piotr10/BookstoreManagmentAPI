using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class changeCustomerDetailProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddresses_CustomerAddressTypes_CustomerAddressTypeId",
                table: "CustomerAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddresses_CustomerDetails_CustomerDetailId",
                table: "CustomerAddresses");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAddresses_CustomerDetailId",
                table: "CustomerAddresses");

            migrationBuilder.DropColumn(
                name: "ApartmentNumber",
                table: "CustomerAddresses");

            migrationBuilder.DropColumn(
                name: "City",
                table: "CustomerAddresses");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "CustomerAddresses");

            migrationBuilder.DropColumn(
                name: "CustomerDetailId",
                table: "CustomerAddresses");

            migrationBuilder.DropColumn(
                name: "HouseNumber",
                table: "CustomerAddresses");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "CustomerAddresses");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "CustomerAddresses");

            migrationBuilder.AddColumn<int>(
                name: "Adres_ApartmentNumber",
                table: "CustomerDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Adres_City",
                table: "CustomerDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Adres_Country",
                table: "CustomerDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Adres_HouseNumber",
                table: "CustomerDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Adres_Street",
                table: "CustomerDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Adres_ZipCode",
                table: "CustomerDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CustomerAddressTypeId",
                table: "CustomerDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerAddressTypeId",
                table: "CustomerAddresses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 13, 23, 42, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 13, 23, 42, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 13, 23, 42, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 13, 23, 42, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 13, 23, 42, DateTimeKind.Local).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 13, 23, 42, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 13, 23, 42, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 13, 23, 42, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "CustomerAddressTypeId" },
                values: new object[] { new DateTime(2022, 8, 30, 3, 13, 23, 43, DateTimeKind.Local).AddTicks(8246), null });

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "CustomerAddressTypeId", "Adres_ApartmentNumber", "Adres_City", "Adres_Country", "Adres_HouseNumber", "Adres_Street", "Adres_ZipCode" },
                values: new object[] { new DateTime(2022, 8, 30, 3, 13, 23, 42, DateTimeKind.Local).AddTicks(4077), 1, 12, "Warsaw", "Poland", 12, "Warszawska", "01-001" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 13, 23, 42, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 13, 23, 42, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 13, 23, 43, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDetails_CustomerAddressTypeId",
                table: "CustomerDetails",
                column: "CustomerAddressTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddresses_CustomerAddressTypes_CustomerAddressTypeId",
                table: "CustomerAddresses",
                column: "CustomerAddressTypeId",
                principalTable: "CustomerAddressTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerDetails_CustomerAddressTypes_CustomerAddressTypeId",
                table: "CustomerDetails",
                column: "CustomerAddressTypeId",
                principalTable: "CustomerAddressTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddresses_CustomerAddressTypes_CustomerAddressTypeId",
                table: "CustomerAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerDetails_CustomerAddressTypes_CustomerAddressTypeId",
                table: "CustomerDetails");

            migrationBuilder.DropIndex(
                name: "IX_CustomerDetails_CustomerAddressTypeId",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "Adres_ApartmentNumber",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "Adres_City",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "Adres_Country",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "Adres_HouseNumber",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "Adres_Street",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "Adres_ZipCode",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "CustomerAddressTypeId",
                table: "CustomerDetails");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerAddressTypeId",
                table: "CustomerAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApartmentNumber",
                table: "CustomerAddresses",
                type: "int",
                maxLength: 15,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "CustomerAddresses",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "CustomerAddresses",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CustomerDetailId",
                table: "CustomerAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HouseNumber",
                table: "CustomerAddresses",
                type: "int",
                maxLength: 15,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "CustomerAddresses",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "CustomerAddresses",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 2, 40, 30, 687, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 30, 2, 40, 30, 687, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 2, 40, 30, 687, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 30, 2, 40, 30, 687, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 2, 40, 30, 687, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 30, 2, 40, 30, 687, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 2, 40, 30, 687, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 30, 2, 40, 30, 687, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApartmentNumber", "City", "Country", "Created", "CustomerAddressTypeId", "CustomerDetailId", "HouseNumber", "Street", "ZipCode" },
                values: new object[] { 12, "Warsaw", "Poland", new DateTime(2022, 8, 30, 2, 40, 30, 687, DateTimeKind.Local).AddTicks(5129), 1, 1, 12, "Warszawska", "01-001" });

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 2, 40, 30, 687, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 2, 40, 30, 687, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 30, 2, 40, 30, 687, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 2, 40, 30, 687, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddresses_CustomerDetailId",
                table: "CustomerAddresses",
                column: "CustomerDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddresses_CustomerAddressTypes_CustomerAddressTypeId",
                table: "CustomerAddresses",
                column: "CustomerAddressTypeId",
                principalTable: "CustomerAddressTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddresses_CustomerDetails_CustomerDetailId",
                table: "CustomerAddresses",
                column: "CustomerDetailId",
                principalTable: "CustomerDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
