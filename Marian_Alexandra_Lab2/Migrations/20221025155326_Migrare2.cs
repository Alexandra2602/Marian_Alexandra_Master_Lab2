using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marian_Alexandra_Lab2.Migrations
{
    public partial class Migrare2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Author",
                newName: "AuthorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuthorID",
                table: "Author",
                newName: "ID");
        }
    }
}
