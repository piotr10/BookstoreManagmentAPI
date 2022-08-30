using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class addedNewSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 2, 40, 30, 687, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 2, 40, 30, 687, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 2, 40, 30, 687, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId", "FirstName", "LastName" },
                values: new object[] { 2, new DateTime(2022, 8, 30, 2, 40, 30, 687, DateTimeKind.Local).AddTicks(4773), "", null, "", null, "", 1, "Stanisław", "Lem" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 2, 40, 30, 687, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 30, 2, 40, 30, 687, DateTimeKind.Local).AddTicks(5129));

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

            migrationBuilder.InsertData(
                table: "AuthorBiographies",
                columns: new[] { "Id", "AuthorId", "Country", "Created", "CreatedBy", "DateOfBirth", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "PlaceOfBirth", "StatusId" },
                values: new object[] { 2, 2, "Poland", new DateTime(2022, 8, 30, 2, 40, 30, 687, DateTimeKind.Local).AddTicks(4966), "", new DateTime(1921, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", null, "", "Kraków", 1 });

            migrationBuilder.InsertData(
                table: "AuthorContactDetails",
                columns: new[] { "Id", "AuthorContactDetailTypeId", "AuthorId", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "StatusId" },
                values: new object[] { 2, 3, 2, new DateTime(2022, 8, 30, 2, 40, 30, 687, DateTimeKind.Local).AddTicks(5004), "", null, "", null, "", "stanislawlem@wp.pl", 1 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId" },
                values: new object[] { 2, 2, new DateTime(2022, 8, 30, 2, 40, 30, 687, DateTimeKind.Local).AddTicks(5023), "", null, "", null, "", 1 });

            migrationBuilder.InsertData(
                table: "BookDetails",
                columns: new[] { "Id", "BookId", "GenreId", "Name", "Price", "PublishedBookDate" },
                values: new object[] { 6, 2, 1, "Wejście na orbitę", 14m, new DateTime(1962, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "BookDetails",
                columns: new[] { "Id", "BookId", "GenreId", "Name", "Price", "PublishedBookDate" },
                values: new object[] { 7, 2, 2, "Summa technologiae", 14m, new DateTime(1964, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "BookDetails",
                columns: new[] { "Id", "BookId", "GenreId", "Name", "Price", "PublishedBookDate" },
                values: new object[] { 8, 2, 3, "Filozofia przypadku", 14m, new DateTime(1968, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

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
    }
}
