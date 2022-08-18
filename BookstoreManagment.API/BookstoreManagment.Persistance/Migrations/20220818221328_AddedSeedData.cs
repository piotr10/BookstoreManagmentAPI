using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreManagement.Persistance.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookDetailGenre");

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "BookDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_GenreId",
                table: "BookDetails",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookDetails_Genres_GenreId",
                table: "BookDetails",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookDetails_Genres_GenreId",
                table: "BookDetails");

            migrationBuilder.DropIndex(
                name: "IX_BookDetails_GenreId",
                table: "BookDetails");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "BookDetails");

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
                name: "IX_BookDetailGenre_GenresId",
                table: "BookDetailGenre",
                column: "GenresId");
        }
    }
}
