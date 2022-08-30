using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class changeAdresColumnTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Adres_ZipCode",
                table: "CustomerDetails",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "Adres_Street",
                table: "CustomerDetails",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "Adres_HouseNumber",
                table: "CustomerDetails",
                newName: "HouseNumber");

            migrationBuilder.RenameColumn(
                name: "Adres_Country",
                table: "CustomerDetails",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "Adres_City",
                table: "CustomerDetails",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "Adres_ApartmentNumber",
                table: "CustomerDetails",
                newName: "ApartmentNumber");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "CustomerDetails",
                newName: "Adres_ZipCode");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "CustomerDetails",
                newName: "Adres_Street");

            migrationBuilder.RenameColumn(
                name: "HouseNumber",
                table: "CustomerDetails",
                newName: "Adres_HouseNumber");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "CustomerDetails",
                newName: "Adres_Country");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "CustomerDetails",
                newName: "Adres_City");

            migrationBuilder.RenameColumn(
                name: "ApartmentNumber",
                table: "CustomerDetails",
                newName: "Adres_ApartmentNumber");

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
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 13, 23, 43, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 3, 13, 23, 42, DateTimeKind.Local).AddTicks(4077));

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
        }
    }
}
