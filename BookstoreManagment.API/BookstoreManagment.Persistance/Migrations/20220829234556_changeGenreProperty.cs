using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class changeGenreProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 1, 45, 56, 16, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 1, 45, 56, 16, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 1, 45, 56, 16, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "GenreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "GenreId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "GenreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "GenreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 1, 45, 56, 16, DateTimeKind.Local).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 1, 45, 56, 16, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 1, 45, 56, 16, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 1, 45, 56, 16, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 8, 30, 1, 45, 56, 16, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 1, 45, 56, 16, DateTimeKind.Local).AddTicks(6010));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "Created",
                value: new DateTime(2022, 8, 29, 1, 26, 23, 498, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 29, 1, 26, 23, 498, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "GenreId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "GenreId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "GenreId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "GenreId",
                value: 3);

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
                column: "Created",
                value: new DateTime(2022, 8, 29, 1, 26, 23, 498, DateTimeKind.Local).AddTicks(8465));

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
    }
}
