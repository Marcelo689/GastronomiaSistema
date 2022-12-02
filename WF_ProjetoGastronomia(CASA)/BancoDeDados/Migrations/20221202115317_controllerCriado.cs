using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoDeDados.Migrations
{
    public partial class controllerCriado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Pedidos_PedidoId",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Receitas_ReceitaId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_PedidoId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Acesso",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "CategoriaTipoReceita",
                table: "Receitas");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "ProdutoTipoUnidade",
                table: "Produtos");

            migrationBuilder.AddColumn<byte[]>(
                name: "Imagem",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PermissaoAcesso",
                table: "Usuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "UsuarioAtivo",
                table: "Usuarios",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TipoReceitaId",
                table: "Receitas",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReceitaId",
                table: "Produtos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "PrecoPorQuantidade",
                table: "Produtos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "UnidadeMedidaId",
                table: "Produtos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeReceita",
                table: "Pedidos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReceitaId",
                table: "Pedidos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Empresas",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Telefone",
                table: "Empresas",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "TipoReceita",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoReceita", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnidadeMedida",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadeMedida", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Receitas_TipoReceitaId",
                table: "Receitas",
                column: "TipoReceitaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_UnidadeMedidaId",
                table: "Produtos",
                column: "UnidadeMedidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Receitas_ReceitaId",
                table: "Produtos",
                column: "ReceitaId",
                principalTable: "Receitas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_UnidadeMedida_UnidadeMedidaId",
                table: "Produtos",
                column: "UnidadeMedidaId",
                principalTable: "UnidadeMedida",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Receitas_TipoReceita_TipoReceitaId",
                table: "Receitas",
                column: "TipoReceitaId",
                principalTable: "TipoReceita",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Receitas_ReceitaId",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_UnidadeMedida_UnidadeMedidaId",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Receitas_TipoReceita_TipoReceitaId",
                table: "Receitas");

            migrationBuilder.DropTable(
                name: "TipoReceita");

            migrationBuilder.DropTable(
                name: "UnidadeMedida");

            migrationBuilder.DropIndex(
                name: "IX_Receitas_TipoReceitaId",
                table: "Receitas");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_UnidadeMedidaId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "PermissaoAcesso",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "UsuarioAtivo",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "TipoReceitaId",
                table: "Receitas");

            migrationBuilder.DropColumn(
                name: "PrecoPorQuantidade",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "UnidadeMedidaId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "QuantidadeReceita",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "ReceitaId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Empresas");

            migrationBuilder.AddColumn<int>(
                name: "Acesso",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaTipoReceita",
                table: "Receitas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ReceitaId",
                table: "Produtos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Preco",
                table: "Produtos",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoTipoUnidade",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_PedidoId",
                table: "Produtos",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Pedidos_PedidoId",
                table: "Produtos",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Receitas_ReceitaId",
                table: "Produtos",
                column: "ReceitaId",
                principalTable: "Receitas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
