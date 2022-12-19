using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoDeDados.Migrations
{
    public partial class atualizandocolunaspedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receitas_Pedidos_PedidoId",
                table: "Receitas");

            migrationBuilder.DropIndex(
                name: "IX_Receitas_PedidoId",
                table: "Receitas");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Receitas");

            migrationBuilder.DropColumn(
                name: "ReceitaId",
                table: "Pedidos");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastroPedido",
                table: "Pedidos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "TotalCusto",
                table: "Pedidos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalLucro",
                table: "Pedidos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioLoginId",
                table: "Pedidos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_UsuarioLoginId",
                table: "Pedidos",
                column: "UsuarioLoginId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Usuarios_UsuarioLoginId",
                table: "Pedidos",
                column: "UsuarioLoginId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Usuarios_UsuarioLoginId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_UsuarioLoginId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "DataCadastroPedido",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "TotalCusto",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "TotalLucro",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "UsuarioLoginId",
                table: "Pedidos");

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Receitas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReceitaId",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Receitas_PedidoId",
                table: "Receitas",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Receitas_Pedidos_PedidoId",
                table: "Receitas",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
