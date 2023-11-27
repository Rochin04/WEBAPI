using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class BookAuthorColumnRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Autor",
                table: "Libros");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Authors",
                newName: "fullName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Authors",
                newName: "iD");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fullName",
                table: "Authors",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "iD",
                table: "Authors",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Autor",
                table: "Libros",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
