using Microsoft.EntityFrameworkCore.Migrations;

namespace Consultorio.Migrations
{
    public partial class Modulo4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Paciente");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Paciente");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
