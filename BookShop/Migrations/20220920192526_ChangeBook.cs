using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShop.Migrations
{
    /// <inheritdoc />
    public partial class ChangeBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Books_AutorId",
                table: "Books",
                column: "AutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_EditionId",
                table: "Books",
                column: "EditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Autors_AutorId",
                table: "Books",
                column: "AutorId",
                principalTable: "Autors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Editions_EditionId",
                table: "Books",
                column: "EditionId",
                principalTable: "Editions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Genre_GenreId",
                table: "Books",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Autors_AutorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Editions_EditionId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Genre_GenreId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_AutorId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_EditionId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_GenreId",
                table: "Books");
        }
    }
}
