using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wilson.Compras.Api.Migrations
{
    public partial class rename_items_language : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Items",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Marca",
                table: "Items",
                newName: "Brand");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Items",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Brand",
                table: "Items",
                newName: "Marca");
        }
    }
}
