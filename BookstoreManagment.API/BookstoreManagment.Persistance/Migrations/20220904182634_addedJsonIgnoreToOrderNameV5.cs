using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class addedJsonIgnoreToOrderNameV5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 26, 33, 684, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 26, 33, 684, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 26, 33, 684, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 26, 33, 684, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 26, 33, 684, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 26, 33, 684, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 26, 33, 684, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 26, 33, 684, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 26, 33, 684, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 26, 33, 684, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 26, 33, 684, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 26, 33, 684, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 26, 33, 684, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 26, 33, 684, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 20, 26, 33, 684, DateTimeKind.Local).AddTicks(8178), "Ogniem i Mieczem" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 20, 26, 33, 684, DateTimeKind.Local).AddTicks(8182), "Potop" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 24, 36, 608, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 24, 36, 608, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 24, 36, 608, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 24, 36, 608, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 24, 36, 608, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 24, 36, 608, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 24, 36, 608, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 24, 36, 608, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 24, 36, 608, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 24, 36, 608, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 24, 36, 608, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 24, 36, 608, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 24, 36, 608, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 24, 36, 608, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 24, 36, 608, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 20, 24, 36, 608, DateTimeKind.Local).AddTicks(4806));
        }
    }
}
