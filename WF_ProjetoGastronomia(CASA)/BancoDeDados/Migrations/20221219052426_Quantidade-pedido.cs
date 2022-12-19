using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoDeDados.Migrations
{
    public partial class Quantidadepedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "QuantidadeReceita",
                table: "ReceitasDoPedido",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantidadeReceita",
                table: "ReceitasDoPedido");
        }
    }
}
