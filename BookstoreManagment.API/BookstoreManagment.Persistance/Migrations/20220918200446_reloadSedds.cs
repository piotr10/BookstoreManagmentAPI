using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class reloadSedds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 18, 22, 4, 45, 236, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 18, 22, 4, 45, 236, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 18, 22, 4, 45, 236, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 18, 22, 4, 45, 236, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 18, 22, 4, 45, 236, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 18, 22, 4, 45, 236, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 18, 22, 4, 45, 236, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 18, 22, 4, 45, 236, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 9, 18, 22, 4, 45, 236, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 9, 18, 22, 4, 45, 236, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 9, 18, 22, 4, 45, 236, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 9, 18, 22, 4, 45, 236, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 9, 18, 22, 4, 45, 236, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2022, 9, 18, 22, 4, 45, 236, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "CustomerContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 18, 22, 4, 45, 236, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "CustomerContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 18, 22, 4, 45, 236, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 18, 22, 4, 45, 236, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 18, 22, 4, 45, 236, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 18, 22, 4, 45, 236, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 18, 22, 4, 45, 236, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 18, 22, 4, 45, 236, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 18, 22, 4, 45, 236, DateTimeKind.Local).AddTicks(9202));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 17, 16, 0, 48, 568, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 17, 16, 0, 48, 568, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 17, 16, 0, 48, 568, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 17, 16, 0, 48, 568, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 17, 16, 0, 48, 568, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 17, 16, 0, 48, 568, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 17, 16, 0, 48, 568, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 17, 16, 0, 48, 568, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 9, 17, 16, 0, 48, 568, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 9, 17, 16, 0, 48, 568, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 9, 17, 16, 0, 48, 568, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 9, 17, 16, 0, 48, 568, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 9, 17, 16, 0, 48, 568, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2022, 9, 17, 16, 0, 48, 568, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "CustomerContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 17, 16, 0, 48, 568, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "CustomerContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 17, 16, 0, 48, 568, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 17, 16, 0, 48, 568, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 17, 16, 0, 48, 568, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 17, 16, 0, 48, 568, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 17, 16, 0, 48, 568, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 17, 16, 0, 48, 568, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 17, 16, 0, 48, 568, DateTimeKind.Local).AddTicks(6495));
        }
    }
}
