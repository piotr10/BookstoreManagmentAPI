using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class changeSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DetailContact",
                table: "CustomerDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 29, 1, 26, 23, 498, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorContactDetailTypeId", "Created" },
                values: new object[] { 2, new DateTime(2022, 8, 29, 1, 26, 23, 498, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 29, 1, 26, 23, 498, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 29, 1, 26, 23, 498, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 29, 1, 26, 23, 498, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "DetailContact" },
                values: new object[] { new DateTime(2022, 8, 29, 1, 26, 23, 498, DateTimeKind.Local).AddTicks(8465), "piotrCz@example.com" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 29, 1, 26, 23, 498, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 29, 1, 26, 23, 498, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 29, 1, 26, 23, 498, DateTimeKind.Local).AddTicks(8557));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetailContact",
                table: "CustomerDetails");

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 20, 15, 58, 37, 250, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorContactDetailTypeId", "Created" },
                values: new object[] { 1, new DateTime(2022, 8, 20, 15, 58, 37, 250, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 20, 15, 58, 37, 250, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 20, 15, 58, 37, 250, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 20, 15, 58, 37, 250, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 20, 15, 58, 37, 250, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 20, 15, 58, 37, 250, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 20, 15, 58, 37, 250, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 20, 15, 58, 37, 250, DateTimeKind.Local).AddTicks(4843));
        }
    }
}
