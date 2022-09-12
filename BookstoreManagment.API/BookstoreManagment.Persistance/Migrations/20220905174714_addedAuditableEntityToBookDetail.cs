using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class addedAuditableEntityToBookDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "BookDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "BookDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Inactivated",
                table: "BookDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InactivatedBy",
                table: "BookDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "BookDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "BookDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "BookDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "InactivatedBy", "ModifiedBy", "StatusId" },
                values: new object[] { new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1766), "", "", "", 1 });

            migrationBuilder.UpdateData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "InactivatedBy", "ModifiedBy", "StatusId" },
                values: new object[] { new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1769), "", "", "", 1 });

            migrationBuilder.UpdateData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "InactivatedBy", "ModifiedBy", "StatusId" },
                values: new object[] { new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1772), "", "", "", 1 });

            migrationBuilder.UpdateData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "InactivatedBy", "ModifiedBy", "StatusId" },
                values: new object[] { new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1774), "", "", "", 1 });

            migrationBuilder.UpdateData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "InactivatedBy", "ModifiedBy", "StatusId" },
                values: new object[] { new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1777), "", "", "", 1 });

            migrationBuilder.UpdateData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "InactivatedBy", "ModifiedBy", "StatusId" },
                values: new object[] { new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1779), "", "", "", 1 });

            migrationBuilder.UpdateData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "InactivatedBy", "ModifiedBy", "StatusId" },
                values: new object[] { new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1781), "", "", "", 1 });

            migrationBuilder.UpdateData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "InactivatedBy", "ModifiedBy", "StatusId" },
                values: new object[] { new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1784), "", "", "", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(2135));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "BookDetails");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "BookDetails");

            migrationBuilder.DropColumn(
                name: "Inactivated",
                table: "BookDetails");

            migrationBuilder.DropColumn(
                name: "InactivatedBy",
                table: "BookDetails");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "BookDetails");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "BookDetails");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "BookDetails");

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 4, 21, 33, 47, 510, DateTimeKind.Local).AddTicks(8737));
        }
    }
}
