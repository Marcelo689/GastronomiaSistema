using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoDeDados.Migrations
{
    public partial class Adicionaprecovenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PrecoVenda",
                table: "Receitas",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecoVenda",
                table: "Receitas");
        }
    }
}
