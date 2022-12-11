﻿// <auto-generated />
using System;
using BancoDeDados.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BancoDeDados.Migrations
{
    [DbContext(typeof(BDContexto))]
    partial class BDContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BancoDeDados.Contexto.ClassesRelacionadas.PedidoConcluido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataConcluido")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("PedidoId");

                    b.ToTable("PedidosConcluidos");
                });

            modelBuilder.Entity("BancoDeDados.Contexto.ClassesRelacionadas.PedidoPendente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataParaEntrega")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("PedidoId");

                    b.ToTable("PedidosPendentes");
                });

            modelBuilder.Entity("BancoDeDados.Contexto.ClassesRelacionadas.ProdutoReceita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("ReceitaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("ReceitaId");

                    b.ToTable("ProdutosReceita");
                });

            modelBuilder.Entity("BancoDeDados.Contexto.ClassesRelacionadas.ReceitaDoPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<int>("ReceitaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ReceitaId");

                    b.ToTable("ReceitasDoPedido");
                });

            modelBuilder.Entity("BancoDeDados.Contexto.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<long>("CPF")
                        .HasColumnType("bigint");

                    b.Property<long>("Celular")
                        .HasColumnType("bigint");

                    b.Property<string>("Complemento")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("EnderecoNumero")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("longblob");

                    b.Property<string>("NomeCompleto")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Rua")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("BancoDeDados.Contexto.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<long>("CNPJ")
                        .HasColumnType("bigint");

                    b.Property<long>("Celular")
                        .HasColumnType("bigint");

                    b.Property<string>("Cidade")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Complemento")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("EnderecoNumero")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("longblob");

                    b.Property<string>("NomeEmpresa")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Rua")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<long>("Telefone")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("BancoDeDados.Contexto.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataEntregaRealizada")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataParaEntrega")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("FoiEntregue")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("PrecoVenda")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("QuantidadeReceita")
                        .HasColumnType("int");

                    b.Property<int>("ReceitaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("BancoDeDados.Contexto.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("PrecoPorQuantidade")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int?>("ReceitaId")
                        .HasColumnType("int");

                    b.Property<int?>("UnidadeMedidaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReceitaId");

                    b.HasIndex("UnidadeMedidaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("BancoDeDados.Contexto.Receita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NomeReceita")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("PedidoId")
                        .HasColumnType("int");

                    b.Property<double>("PercentualGastoGas")
                        .HasColumnType("double");

                    b.Property<double>("PerdaPorReceita")
                        .HasColumnType("double");

                    b.Property<int>("PotenciaKwh")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecoCusto")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeProduto")
                        .HasColumnType("int");

                    b.Property<string>("TempoDePreparo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("TipoReceitaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("TipoReceitaId");

                    b.ToTable("Receitas");
                });

            modelBuilder.Entity("BancoDeDados.Controller.Telas.Gasto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Gastos");
                });

            modelBuilder.Entity("BancoDeDados.Controller.Telas.GastoReceita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GastoId")
                        .HasColumnType("int");

                    b.Property<int>("ReceitaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GastoId");

                    b.HasIndex("ReceitaId");

                    b.ToTable("GastosReceita");
                });

            modelBuilder.Entity("BancoDeDados.Models.TipoReceita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("TipoReceita");
                });

            modelBuilder.Entity("BancoDeDados.Models.UnidadeMedida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Sigla")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("UnidadesMedida");
                });

            modelBuilder.Entity("BancoDeDados.Models.UsuarioLogin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<byte[]>("Imagem")
                        .HasColumnType("longblob");

                    b.Property<bool>("ManterLogin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("PermissaoAcesso")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("UsuarioAtivo")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("BancoDeDados.Contexto.ClassesRelacionadas.PedidoConcluido", b =>
                {
                    b.HasOne("BancoDeDados.Contexto.Cliente", "Cliente")
                        .WithMany("PedidosConcluidos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BancoDeDados.Contexto.Pedido", "Pedido")
                        .WithMany()
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BancoDeDados.Contexto.ClassesRelacionadas.PedidoPendente", b =>
                {
                    b.HasOne("BancoDeDados.Contexto.Cliente", "Cliente")
                        .WithMany("PedidosPendentes")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BancoDeDados.Contexto.Pedido", "Pedido")
                        .WithMany()
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BancoDeDados.Contexto.ClassesRelacionadas.ProdutoReceita", b =>
                {
                    b.HasOne("BancoDeDados.Contexto.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BancoDeDados.Contexto.Receita", "Receita")
                        .WithMany()
                        .HasForeignKey("ReceitaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BancoDeDados.Contexto.ClassesRelacionadas.ReceitaDoPedido", b =>
                {
                    b.HasOne("BancoDeDados.Contexto.Pedido", "Pedido")
                        .WithMany()
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BancoDeDados.Contexto.Receita", "Receita")
                        .WithMany()
                        .HasForeignKey("ReceitaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BancoDeDados.Contexto.Pedido", b =>
                {
                    b.HasOne("BancoDeDados.Contexto.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("BancoDeDados.Contexto.Produto", b =>
                {
                    b.HasOne("BancoDeDados.Contexto.Receita", null)
                        .WithMany("Produto")
                        .HasForeignKey("ReceitaId");

                    b.HasOne("BancoDeDados.Models.UnidadeMedida", "UnidadeMedida")
                        .WithMany()
                        .HasForeignKey("UnidadeMedidaId");
                });

            modelBuilder.Entity("BancoDeDados.Contexto.Receita", b =>
                {
                    b.HasOne("BancoDeDados.Contexto.Pedido", null)
                        .WithMany("ReceitasDoPedido")
                        .HasForeignKey("PedidoId");

                    b.HasOne("BancoDeDados.Models.TipoReceita", "TipoReceita")
                        .WithMany()
                        .HasForeignKey("TipoReceitaId");
                });

            modelBuilder.Entity("BancoDeDados.Controller.Telas.GastoReceita", b =>
                {
                    b.HasOne("BancoDeDados.Controller.Telas.Gasto", "Gasto")
                        .WithMany()
                        .HasForeignKey("GastoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BancoDeDados.Contexto.Receita", "Receita")
                        .WithMany()
                        .HasForeignKey("ReceitaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
