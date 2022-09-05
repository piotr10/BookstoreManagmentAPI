using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class addedCustomerContactDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetailContact",
                table: "CustomerDetails");

            migrationBuilder.CreateTable(
                name: "CustomerContactDetailTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerContactDetailTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerContactDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomerContactDetailTypeId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerContactDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerContactDetails_CustomerContactDetailTypes_CustomerContactDetailTypeId",
                        column: x => x.CustomerContactDetailTypeId,
                        principalTable: "CustomerContactDetailTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerContactDetails_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "CustomerContactDetailTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "Email" },
                    { 3, "Phone" }
                });

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

            migrationBuilder.InsertData(
                table: "CustomerContactDetails",
                columns: new[] { "Id", "ContactName", "Created", "CreatedBy", "CustomerContactDetailTypeId", "CustomerId", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId" },
                values: new object[] { 1, "piotrCz@example.com", new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9798), "", 2, 1, null, "", null, "", 1 });

            migrationBuilder.InsertData(
                table: "CustomerContactDetails",
                columns: new[] { "Id", "ContactName", "Created", "CreatedBy", "CustomerContactDetailTypeId", "CustomerId", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId" },
                values: new object[] { 2, "olaSa@example.coms", new DateTime(2022, 9, 6, 0, 1, 16, 410, DateTimeKind.Local).AddTicks(9854), "", 2, 2, null, "", null, "", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerContactDetails_CustomerContactDetailTypeId",
                table: "CustomerContactDetails",
                column: "CustomerContactDetailTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerContactDetails_CustomerId",
                table: "CustomerContactDetails",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerContactDetails");

            migrationBuilder.DropTable(
                name: "CustomerContactDetailTypes");

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
                columns: new[] { "Created", "DetailContact" },
                values: new object[] { new DateTime(2022, 9, 5, 22, 50, 3, 477, DateTimeKind.Local).AddTicks(7011), "piotrCz@example.com" });

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "DetailContact" },
                values: new object[] { new DateTime(2022, 9, 5, 22, 50, 3, 477, DateTimeKind.Local).AddTicks(7114), "olaSa@example.com" });

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
    }
}
