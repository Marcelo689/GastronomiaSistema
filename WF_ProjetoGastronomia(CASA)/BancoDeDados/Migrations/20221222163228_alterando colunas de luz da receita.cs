using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoDeDados.Migrations
{
    public partial class alterandocolunasdeluzdareceita : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PercentualGastoGas",
                table: "Receitas");

            migrationBuilder.DropColumn(
                name: "PotenciaKwh",
                table: "Receitas");

            migrationBuilder.DropColumn(
                name: "TempoDePreparo",
                table: "Receitas");

            migrationBuilder.AddColumn<decimal>(
                name: "ValorLuz",
                table: "Receitas",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorLuz",
                table: "Receitas");

            migrationBuilder.AddColumn<double>(
                name: "PercentualGastoGas",
                table: "Receitas",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<decimal>(
                name: "PotenciaKwh",
                table: "Receitas",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "TempoDePreparo",
                table: "Receitas",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
