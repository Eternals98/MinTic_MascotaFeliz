using Microsoft.EntityFrameworkCore.Migrations;

namespace MascotaFeliz.App.Persistencia.Migrations
{
    public partial class tercera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Apelllidos",
                table: "Personas",
                newName: "Apellidos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Apellidos",
                table: "Personas",
                newName: "Apelllidos");
        }
    }
}
