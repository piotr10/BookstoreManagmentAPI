using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class ChangedEntitiesAndProperties_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorContactDetailTypes_AuthorContactDetails_AuthorContactDetailId",
                table: "AuthorContactDetailTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Customers_CustomerId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddressTypes_CustomerAddresses_CustomerAddressId",
                table: "CustomerAddressTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerDetailTypes_CustomerDetails_CustomerDetailId",
                table: "CustomerDetailTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderTransportTypes_Orders_OrderId",
                table: "OrderTransportTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_Orders_OrderId",
                table: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "BookGenre");

            migrationBuilder.DropIndex(
                name: "IX_PaymentMethods_OrderId",
                table: "PaymentMethods");

            migrationBuilder.DropIndex(
                name: "IX_OrderTransportTypes_OrderId",
                table: "OrderTransportTypes");

            migrationBuilder.DropIndex(
                name: "IX_CustomerDetailTypes_CustomerDetailId",
                table: "CustomerDetailTypes");

            migrationBuilder.DropIndex(
                name: "IX_CustomerDetails_CustomerId",
                table: "CustomerDetails");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAddressTypes_CustomerAddressId",
                table: "CustomerAddressTypes");

            migrationBuilder.DropIndex(
                name: "IX_Books_CustomerId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_AuthorContactDetailTypes_AuthorContactDetailId",
                table: "AuthorContactDetailTypes");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PaymentMethods");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PaymentMethods");

            migrationBuilder.DropColumn(
                name: "Inactivated",
                table: "PaymentMethods");

            migrationBuilder.DropColumn(
                name: "InactivatedBy",
                table: "PaymentMethods");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "PaymentMethods");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PaymentMethods");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "PaymentMethods");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "PaymentMethods");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "OrderTransportTypes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OrderTransportTypes");

            migrationBuilder.DropColumn(
                name: "Inactivated",
                table: "OrderTransportTypes");

            migrationBuilder.DropColumn(
                name: "InactivatedBy",
                table: "OrderTransportTypes");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "OrderTransportTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "OrderTransportTypes");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "OrderTransportTypes");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "OrderTransportTypes");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "Inactivated",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "InactivatedBy",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "CustomerDetailTypes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CustomerDetailTypes");

            migrationBuilder.DropColumn(
                name: "CustomerDetailId",
                table: "CustomerDetailTypes");

            migrationBuilder.DropColumn(
                name: "Inactivated",
                table: "CustomerDetailTypes");

            migrationBuilder.DropColumn(
                name: "InactivatedBy",
                table: "CustomerDetailTypes");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "CustomerDetailTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "CustomerDetailTypes");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "CustomerDetailTypes");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "CustomerAddressTypes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CustomerAddressTypes");

            migrationBuilder.DropColumn(
                name: "CustomerAddressId",
                table: "CustomerAddressTypes");

            migrationBuilder.DropColumn(
                name: "Inactivated",
                table: "CustomerAddressTypes");

            migrationBuilder.DropColumn(
                name: "InactivatedBy",
                table: "CustomerAddressTypes");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "CustomerAddressTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "CustomerAddressTypes");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "CustomerAddressTypes");

            migrationBuilder.DropColumn(
                name: "CustomerId",
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

            migrationBuilder.DropColumn(
                name: "AuthorContactDetailId",
                table: "AuthorContactDetailTypes");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "AuthorContactDetailTypes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AuthorContactDetailTypes");

            migrationBuilder.DropColumn(
                name: "Inactivated",
                table: "AuthorContactDetailTypes");

            migrationBuilder.DropColumn(
                name: "InactivatedBy",
                table: "AuthorContactDetailTypes");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "AuthorContactDetailTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "AuthorContactDetailTypes");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "AuthorContactDetailTypes");

            migrationBuilder.AlterColumn<decimal>(
                name: "OrderPrice",
                table: "Orders",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderTransportTypeId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentMethodId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerDetailTypeId",
                table: "CustomerDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerAddressTypeId",
                table: "CustomerAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AuthorContactDetailTypeId",
                table: "AuthorContactDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BookDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishedBookDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "BookDetailGenre",
                columns: table => new
                {
                    BookDetailsId = table.Column<int>(type: "int", nullable: false),
                    GenresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookDetailGenre", x => new { x.BookDetailsId, x.GenresId });
                    table.ForeignKey(
                        name: "FK_BookDetailGenre_BookDetails_BookDetailsId",
                        column: x => x.BookDetailsId,
                        principalTable: "BookDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookDetailGenre_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BookId",
                table: "Orders",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderTransportTypeId",
                table: "Orders",
                column: "OrderTransportTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentMethodId",
                table: "Orders",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDetails_CustomerDetailTypeId",
                table: "CustomerDetails",
                column: "CustomerDetailTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDetails_CustomerId",
                table: "CustomerDetails",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddresses_CustomerAddressTypeId",
                table: "CustomerAddresses",
                column: "CustomerAddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorContactDetails_AuthorContactDetailTypeId",
                table: "AuthorContactDetails",
                column: "AuthorContactDetailTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BookDetailGenre_GenresId",
                table: "BookDetailGenre",
                column: "GenresId");

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_BookId",
                table: "BookDetails",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorContactDetails_AuthorContactDetailTypes_AuthorContactDetailTypeId",
                table: "AuthorContactDetails",
                column: "AuthorContactDetailTypeId",
                principalTable: "AuthorContactDetailTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddresses_CustomerAddressTypes_CustomerAddressTypeId",
                table: "CustomerAddresses",
                column: "CustomerAddressTypeId",
                principalTable: "CustomerAddressTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerDetails_CustomerDetailTypes_CustomerDetailTypeId",
                table: "CustomerDetails",
                column: "CustomerDetailTypeId",
                principalTable: "CustomerDetailTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Books_BookId",
                table: "Orders",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderTransportTypes_OrderTransportTypeId",
                table: "Orders",
                column: "OrderTransportTypeId",
                principalTable: "OrderTransportTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PaymentMethods_PaymentMethodId",
                table: "Orders",
                column: "PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorContactDetails_AuthorContactDetailTypes_AuthorContactDetailTypeId",
                table: "AuthorContactDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddresses_CustomerAddressTypes_CustomerAddressTypeId",
                table: "CustomerAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerDetails_CustomerDetailTypes_CustomerDetailTypeId",
                table: "CustomerDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Books_BookId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderTransportTypes_OrderTransportTypeId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PaymentMethods_PaymentMethodId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "BookDetailGenre");

            migrationBuilder.DropTable(
                name: "BookDetails");

            migrationBuilder.DropIndex(
                name: "IX_Orders_BookId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderTransportTypeId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PaymentMethodId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_CustomerDetails_CustomerDetailTypeId",
                table: "CustomerDetails");

            migrationBuilder.DropIndex(
                name: "IX_CustomerDetails_CustomerId",
                table: "CustomerDetails");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAddresses_CustomerAddressTypeId",
                table: "CustomerAddresses");

            migrationBuilder.DropIndex(
                name: "IX_AuthorContactDetails_AuthorContactDetailTypeId",
                table: "AuthorContactDetails");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderTransportTypeId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PaymentMethodId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustomerDetailTypeId",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "CustomerAddressTypeId",
                table: "CustomerAddresses");

            migrationBuilder.DropColumn(
                name: "AuthorContactDetailTypeId",
                table: "AuthorContactDetails");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PaymentMethods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Inactivated",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InactivatedBy",
                table: "PaymentMethods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "PaymentMethods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "PaymentMethods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "PaymentMethods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "OrderTransportTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OrderTransportTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Inactivated",
                table: "OrderTransportTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InactivatedBy",
                table: "OrderTransportTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "OrderTransportTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "OrderTransportTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "OrderTransportTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "OrderTransportTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "OrderPrice",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Genres",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Inactivated",
                table: "Genres",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InactivatedBy",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "Genres",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Genres",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "CustomerDetailTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CustomerDetailTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CustomerDetailId",
                table: "CustomerDetailTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Inactivated",
                table: "CustomerDetailTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InactivatedBy",
                table: "CustomerDetailTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "CustomerDetailTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "CustomerDetailTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "CustomerDetailTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "CustomerAddressTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CustomerAddressTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CustomerAddressId",
                table: "CustomerAddressTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Inactivated",
                table: "CustomerAddressTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InactivatedBy",
                table: "CustomerAddressTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "CustomerAddressTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "CustomerAddressTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "CustomerAddressTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
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
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishedBookDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "AuthorContactDetailId",
                table: "AuthorContactDetailTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "AuthorContactDetailTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AuthorContactDetailTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Inactivated",
                table: "AuthorContactDetailTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InactivatedBy",
                table: "AuthorContactDetailTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "AuthorContactDetailTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "AuthorContactDetailTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "AuthorContactDetailTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BookGenre",
                columns: table => new
                {
                    BooksId = table.Column<int>(type: "int", nullable: false),
                    GenresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenre", x => new { x.BooksId, x.GenresId });
                    table.ForeignKey(
                        name: "FK_BookGenre_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookGenre_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_OrderId",
                table: "PaymentMethods",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTransportTypes_OrderId",
                table: "OrderTransportTypes",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDetailTypes_CustomerDetailId",
                table: "CustomerDetailTypes",
                column: "CustomerDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDetails_CustomerId",
                table: "CustomerDetails",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddressTypes_CustomerAddressId",
                table: "CustomerAddressTypes",
                column: "CustomerAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CustomerId",
                table: "Books",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorContactDetailTypes_AuthorContactDetailId",
                table: "AuthorContactDetailTypes",
                column: "AuthorContactDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_BookGenre_GenresId",
                table: "BookGenre",
                column: "GenresId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorContactDetailTypes_AuthorContactDetails_AuthorContactDetailId",
                table: "AuthorContactDetailTypes",
                column: "AuthorContactDetailId",
                principalTable: "AuthorContactDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Customers_CustomerId",
                table: "Books",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddressTypes_CustomerAddresses_CustomerAddressId",
                table: "CustomerAddressTypes",
                column: "CustomerAddressId",
                principalTable: "CustomerAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerDetailTypes_CustomerDetails_CustomerDetailId",
                table: "CustomerDetailTypes",
                column: "CustomerDetailId",
                principalTable: "CustomerDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderTransportTypes_Orders_OrderId",
                table: "OrderTransportTypes",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_Orders_OrderId",
                table: "PaymentMethods",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
