using BancoDeDados.Contexto.ClassesRelacionadas;
using BancoDeDados.Models;
using Microsoft.EntityFrameworkCore;

namespace BancoDeDados.Contexto
{
    public class BDContexto : DbContext
    {
        public DbSet<UsuarioLogin> Usuarios { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<PedidoConcluido> PedidosConcluidos { get; set; }
        public DbSet<PedidoPendente> PedidosPendentes { get; set; }
        public DbSet<ReceitaDoPedido> ReceitasDoPedido { get; set; }
        public DbSet<ProdutoReceita> ProdutosReceita{ get; set; }
        public static BDContexto _contexto { get; set; }
        public UsuarioLogin Login { get; set; }

        public BDContexto getInstancia()
        {
            if (_contexto == null)
                _contexto = new BDContexto();
            return _contexto;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"server=localhost;database=Gastronomia;uid=root;password=root";
            optionsBuilder.UseMySql(connectionString);

        }

    }
}
