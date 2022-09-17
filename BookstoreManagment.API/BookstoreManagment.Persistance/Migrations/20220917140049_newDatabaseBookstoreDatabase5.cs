using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class newDatabaseBookstoreDatabase5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "CustomerContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "CustomerContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9924));
        }
    }
}
