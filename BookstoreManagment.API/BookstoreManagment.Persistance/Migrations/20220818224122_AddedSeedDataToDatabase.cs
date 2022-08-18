using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class AddedSeedDataToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AuthorContactDetailTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "Phone" },
                    { 3, "Email" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId", "AuthorName_FirstName", "AuthorName_LastName" },
                values: new object[] { 1, new DateTime(2022, 8, 19, 0, 41, 22, 98, DateTimeKind.Local).AddTicks(622), "", null, "", null, "", 1, "Henryk", "Sienkiewicz" });

            migrationBuilder.InsertData(
                table: "CustomerAddressTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Address of residence" },
                    { 2, "Residences" }
                });

            migrationBuilder.InsertData(
                table: "CustomerDetailTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Private person" },
                    { 2, "Entrepreneur" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 19, 0, 41, 22, 98, DateTimeKind.Local).AddTicks(1067), "", null, "", null, "", 1 },
                    { 2, new DateTime(2022, 8, 19, 0, 41, 22, 98, DateTimeKind.Local).AddTicks(1069), "", null, "", null, "", 1 }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Biography" },
                    { 2, "Drama" },
                    { 3, "Historical Novel" }
                });

            migrationBuilder.InsertData(
                table: "OrderTransportTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Paczkomat" },
                    { 2, "Kurier" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mobile payments" },
                    { 2, "Electronic bank transfers" }
                });

            migrationBuilder.InsertData(
                table: "AuthorBiographies",
                columns: new[] { "Id", "AuthorId", "Country", "Created", "CreatedBy", "DateOfBirth", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "PlaceOfBirth", "StatusId" },
                values: new object[] { 1, 1, "Poland", new DateTime(2022, 8, 19, 0, 41, 22, 98, DateTimeKind.Local).AddTicks(926), "", new DateTime(1846, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", null, "", "Wola Okrzejska", 1 });

            migrationBuilder.InsertData(
                table: "AuthorContactDetails",
                columns: new[] { "Id", "AuthorContactDetailTypeId", "AuthorId", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "StatusId" },
                values: new object[] { 1, 1, 1, new DateTime(2022, 8, 19, 0, 41, 22, 98, DateTimeKind.Local).AddTicks(962), "", null, "", null, "", "No contacts", 1 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId" },
                values: new object[] { 1, 1, new DateTime(2022, 8, 19, 0, 41, 22, 98, DateTimeKind.Local).AddTicks(974), "", null, "", null, "", 1 });

            migrationBuilder.InsertData(
                table: "CustomerDetails",
                columns: new[] { "Id", "Created", "CreatedBy", "CustomerDetailTypeId", "CustomerId", "FirstName", "Inactivated", "InactivatedBy", "LastName", "Modified", "ModifiedBy", "StatusId" },
                values: new object[] { 1, new DateTime(2022, 8, 19, 0, 41, 22, 98, DateTimeKind.Local).AddTicks(1097), "", 1, 1, "Piotr", null, "", "Cz", null, "", 1 });

            migrationBuilder.InsertData(
                table: "BookDetails",
                columns: new[] { "Id", "BookId", "GenreId", "Name", "Price", "PublishedBookDate" },
                values: new object[,]
                {
                    { 1, 1, 3, "Ogniem i Mieczem", 10m, new DateTime(1884, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 3, "Potop", 15m, new DateTime(1886, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, 3, "Pan Wołodyjowski", 11m, new DateTime(1888, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, 3, "Quo Vadis", 12m, new DateTime(1896, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, 3, "Krzyżacy", 14m, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CustomerAddresses",
                columns: new[] { "Id", "ApartmentNumber", "City", "Country", "Created", "CreatedBy", "CustomerAddressTypeId", "CustomerDetailId", "HouseNumber", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId", "Street", "ZipCode" },
                values: new object[] { 1, 12, "Warsaw", "Poland", new DateTime(2022, 8, 19, 0, 41, 22, 98, DateTimeKind.Local).AddTicks(1126), "", 1, 1, 12, null, "", null, "", 1, "Warszawska", "01-001" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BookId", "Created", "CreatedBy", "CustomerId", "DeliveryDate", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "OrderDate", "OrderPrice", "OrderTransportTypeId", "PaymentMethodId", "Quantity", "StatusId" },
                values: new object[] { 1, 1, new DateTime(2022, 8, 19, 0, 41, 22, 98, DateTimeKind.Local).AddTicks(1162), "", 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", null, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22m, 1, 1, 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AuthorContactDetailTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AuthorContactDetailTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CustomerAddressTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CustomerDetailTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderTransportTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AuthorContactDetailTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CustomerAddressTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderTransportTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CustomerDetailTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
