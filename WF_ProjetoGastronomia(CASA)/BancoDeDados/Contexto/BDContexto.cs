using BancoDeDados.Contexto.ClassesRelacionadas;
using BancoDeDados.Controller.Telas;
using BancoDeDados.Models;
using BancoDeDados.ModelTeste;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows.Forms;

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
        public DbSet<Gasto> Gastos { get; set; }
        public DbSet<UnidadeMedida> UnidadesMedida { get; set; }
        public DbSet<PedidoConcluido> PedidosConcluidos { get; set; }
        public DbSet<PedidoPendente> PedidosPendentes { get; set; }
        public DbSet<ReceitaDoPedido> ReceitasDoPedido { get; set; }
        public DbSet<ProdutoReceita> ProdutosReceita { get; set; }
        //public DbSet<Blog> Blog { get; set; }
        //public DbSet<Post> Post { get; set; }
        public static BDContexto _contexto { get; set; }
        public UsuarioLogin Login { get; set; }

        public BDContexto getInstancia()
        {
            if (_contexto == null)
                _contexto = new BDContexto();
            return _contexto;
        }
        public void Logar(UsuarioLogin usuario)
        {
            if (usuario.UsuarioAtivo)
                Login = usuario;
            else
                MessageBox.Show("Usuário inativo, um administrador deve ativá-lo");

        }
        public bool ExisteAdmin()
        {
            return _contexto.Usuarios.Where(e => e.PermissaoAcesso == UsuarioLogin.NivelAcesso.Administrador && e.UsuarioAtivo).Any();
        }
        public bool UsuarioLogadoIsAdmin()
        {
            if(Login == null)
                return false;
            if (Login.PermissaoAcesso == UsuarioLogin.NivelAcesso.Administrador)
                return true;
            return false;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"server=localhost;database=Gastronomia;uid=root;password=root;";
            optionsBuilder.UseMySql(connectionString);

        }

    }
}
