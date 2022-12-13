using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoDeDados.Migrations
{
    public partial class empresaId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Usuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "UnidadesMedida",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "TipoReceita",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Receitas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Produtos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Pedidos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Gastos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Clientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EmpresaId",
                table: "Usuarios",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_UnidadesMedida_EmpresaId",
                table: "UnidadesMedida",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoReceita_EmpresaId",
                table: "TipoReceita",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Receitas_EmpresaId",
                table: "Receitas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_EmpresaId",
                table: "Produtos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_EmpresaId",
                table: "Pedidos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_EmpresaId",
                table: "Gastos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_EmpresaId",
                table: "Clientes",
                column: "EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Empresas_EmpresaId",
                table: "Clientes",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_Empresas_EmpresaId",
                table: "Gastos",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Empresas_EmpresaId",
                table: "Pedidos",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Empresas_EmpresaId",
                table: "Produtos",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receitas_Empresas_EmpresaId",
                table: "Receitas",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TipoReceita_Empresas_EmpresaId",
                table: "TipoReceita",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnidadesMedida_Empresas_EmpresaId",
                table: "UnidadesMedida",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Empresas_EmpresaId",
                table: "Usuarios",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Empresas_EmpresaId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Empresas_EmpresaId",
                table: "Gastos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Empresas_EmpresaId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Empresas_EmpresaId",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Receitas_Empresas_EmpresaId",
                table: "Receitas");

            migrationBuilder.DropForeignKey(
                name: "FK_TipoReceita_Empresas_EmpresaId",
                table: "TipoReceita");

            migrationBuilder.DropForeignKey(
                name: "FK_UnidadesMedida_Empresas_EmpresaId",
                table: "UnidadesMedida");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Empresas_EmpresaId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_EmpresaId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_UnidadesMedida_EmpresaId",
                table: "UnidadesMedida");

            migrationBuilder.DropIndex(
                name: "IX_TipoReceita_EmpresaId",
                table: "TipoReceita");

            migrationBuilder.DropIndex(
                name: "IX_Receitas_EmpresaId",
                table: "Receitas");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_EmpresaId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_EmpresaId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Gastos_EmpresaId",
                table: "Gastos");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_EmpresaId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "UnidadesMedida");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "TipoReceita");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Receitas");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Gastos");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Clientes");
        }
    }
}
