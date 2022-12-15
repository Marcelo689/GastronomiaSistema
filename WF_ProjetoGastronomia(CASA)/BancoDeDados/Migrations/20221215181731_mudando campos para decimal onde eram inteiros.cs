using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoDeDados.Migrations
{
    public partial class mudandocamposparadecimalondeeraminteiros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PotenciaKwh",
                table: "Receitas",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PotenciaKwh",
                table: "Receitas",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
