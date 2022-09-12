using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class newDatabaseBookstoreDatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookDetails");

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Books",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishedBookDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "AuthorBiographies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "AuthorContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "GenreId", "Name", "Price", "PublishedBookDate" },
                values: new object[] { new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2135), 1, "Ogniem i Mieczem", 10m, new DateTime(1884, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Created", "GenreId", "Name", "Price", "PublishedBookDate" },
                values: new object[] { 1, new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2139), 2, "Potop", 15m, new DateTime(1886, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Created", "CreatedBy", "GenreId", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "Price", "PublishedBookDate", "StatusId" },
                values: new object[,]
                {
                    { 3, 1, new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2141), "", 3, null, "", null, "", "Pan Wołodyjowski", 11m, new DateTime(1888, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, 1, new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2143), "", 1, null, "", null, "", "Quo Vadis", 12m, new DateTime(1896, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, 1, new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2146), "", 1, null, "", null, "", "Krzyżacy", 14m, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, 1, new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2148), "", 1, null, "", null, "", "Wejście na orbitę", 14m, new DateTime(1962, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, 2, new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2151), "", 2, null, "", null, "", "Summa technologiae", 14m, new DateTime(1964, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, 2, new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2154), "", 3, null, "", null, "", "Filozofia przypadku", 14m, new DateTime(1968, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "CustomerAddresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 9, 5, 22, 16, 46, 86, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Genres_GenreId",
                table: "Books",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Genres_GenreId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_GenreId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PublishedBookDate",
                table: "Books");

            migrationBuilder.CreateTable(
                name: "BookDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PublishedBookDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookDetails_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookDetails_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "BookDetails",
                columns: new[] { "Id", "BookId", "Created", "CreatedBy", "GenreId", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "Price", "PublishedBookDate", "StatusId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1766), "", 1, null, "", null, "", "Ogniem i Mieczem", 10m, new DateTime(1884, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 1, new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1769), "", 2, null, "", null, "", "Potop", 15m, new DateTime(1886, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, 1, new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1772), "", 3, null, "", null, "", "Pan Wołodyjowski", 11m, new DateTime(1888, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, 1, new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1774), "", 1, null, "", null, "", "Quo Vadis", 12m, new DateTime(1896, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, 1, new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1777), "", 1, null, "", null, "", "Krzyżacy", 14m, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, 2, new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1779), "", 1, null, "", null, "", "Wejście na orbitę", 14m, new DateTime(1962, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, 2, new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1781), "", 2, null, "", null, "", "Summa technologiae", 14m, new DateTime(1964, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, 2, new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1784), "", 3, null, "", null, "", "Filozofia przypadku", 14m, new DateTime(1968, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

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
                columns: new[] { "AuthorId", "Created" },
                values: new object[] { 2, new DateTime(2022, 9, 5, 19, 47, 13, 846, DateTimeKind.Local).AddTicks(1736) });

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

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_BookId",
                table: "BookDetails",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_GenreId",
                table: "BookDetails",
                column: "GenreId");
        }
    }
}
