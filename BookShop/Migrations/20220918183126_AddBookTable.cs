using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShop.Migrations
{
    /// <inheritdoc />
    public partial class AddBookTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Autor",
                table: "Autor");

            migrationBuilder.RenameTable(
                name: "Autor",
                newName: "Autors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autors",
                table: "Autors",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GraduationYears = table.Column<int>(type: "int", nullable: false),
                    BookPrice = table.Column<int>(type: "int", nullable: false),
                    BookCost = table.Column<int>(type: "int", nullable: false),
                    BookCount = table.Column<int>(type: "int", nullable: false),
                    AutorId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    EditionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Autors",
                table: "Autors");

            migrationBuilder.RenameTable(
                name: "Autors",
                newName: "Autor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autor",
                table: "Autor",
                column: "Id");
        }
    }
}
