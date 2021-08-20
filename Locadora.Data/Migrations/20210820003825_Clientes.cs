using Microsoft.EntityFrameworkCore.Migrations;

namespace Locadora.Data.Migrations
{
    public partial class Clientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Locacoes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeDiasLocacao",
                table: "Locacoes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Locacoes");

            migrationBuilder.DropColumn(
                name: "QuantidadeDiasLocacao",
                table: "Locacoes");
        }
    }
}
