using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoDeDados.Migrations
{
    public partial class unidadeMedida : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_UnidadeMedida_UnidadeMedidaId",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnidadeMedida",
                table: "UnidadeMedida");

            migrationBuilder.DropColumn(
                name: "QuantidadeUnidade",
                table: "Produtos");

            migrationBuilder.RenameTable(
                name: "UnidadeMedida",
                newName: "UnidadesMedida");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnidadesMedida",
                table: "UnidadesMedida",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_UnidadesMedida_UnidadeMedidaId",
                table: "Produtos",
                column: "UnidadeMedidaId",
                principalTable: "UnidadesMedida",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_UnidadesMedida_UnidadeMedidaId",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnidadesMedida",
                table: "UnidadesMedida");

            migrationBuilder.RenameTable(
                name: "UnidadesMedida",
                newName: "UnidadeMedida");

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeUnidade",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnidadeMedida",
                table: "UnidadeMedida",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_UnidadeMedida_UnidadeMedidaId",
                table: "Produtos",
                column: "UnidadeMedidaId",
                principalTable: "UnidadeMedida",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
