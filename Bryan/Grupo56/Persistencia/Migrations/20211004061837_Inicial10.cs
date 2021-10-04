using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class Inicial10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tipo_documento",
                table: "Clientes",
                newName: "Telefono");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Clientes",
                newName: "Direccion_Oficina");

            migrationBuilder.RenameColumn(
                name: "Edad",
                table: "Clientes",
                newName: "Nombre_Cliente");

            migrationBuilder.RenameColumn(
                name: "Documento",
                table: "Clientes",
                newName: "Celular");

            migrationBuilder.AddColumn<string>(
                name: "Cargo",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ciudad",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contacto_Autorizado",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Correo_Electronico",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Correo_Electronico2",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Ciudad",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Contacto_Autorizado",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Correo_Electronico",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Correo_Electronico2",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "Clientes",
                newName: "Tipo_documento");

            migrationBuilder.RenameColumn(
                name: "Nombre_Cliente",
                table: "Clientes",
                newName: "Edad");

            migrationBuilder.RenameColumn(
                name: "Direccion_Oficina",
                table: "Clientes",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Celular",
                table: "Clientes",
                newName: "Documento");
        }
    }
}
