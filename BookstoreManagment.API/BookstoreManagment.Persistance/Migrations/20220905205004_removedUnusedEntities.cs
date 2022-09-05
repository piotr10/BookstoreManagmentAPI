using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class removedUnusedEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerAddress");

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 50, 3, 477, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 50, 3, 477, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 50, 3, 477, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 50, 3, 477, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 50, 3, 477, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 50, 3, 477, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 50, 3, 477, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 50, 3, 477, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 50, 3, 477, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 50, 3, 477, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 50, 3, 477, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 50, 3, 477, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 50, 3, 477, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 50, 3, 477, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 50, 3, 477, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 50, 3, 477, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 50, 3, 477, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 50, 3, 477, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 50, 3, 477, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 50, 3, 477, DateTimeKind.Local).AddTicks(7296));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddress", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 171, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.InsertData(
                table: "CustomerAddress",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(8997), "", null, "", null, "", 1 },
                    { 2, new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(9011), "", null, "", null, "", 1 }
                });

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 18, 35, 172, DateTimeKind.Local).AddTicks(9142));
        }
    }
}
