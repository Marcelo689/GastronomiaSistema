using BancoDeDados.Contexto;
using BancoDeDados.Models;
using System.Linq;
using System.Windows.Forms;

namespace BancoDeDados.Servicos
{
    public class Servico
    {
        private BDContexto _contexto;

        public Servico()
        {
           _contexto = new BDContexto().getInstancia();
        }
        public bool ExisteAdministrador()
        {
            var qtdAdmin = _contexto.Usuarios.AsQueryable().Where(u => u.PermissaoAcesso == UsuarioLogin.NivelAcesso.Administrador && u.UsuarioAtivo).Count();
            return qtdAdmin > 0;
        }
        // form
        public void AbrirTela(Form tela,bool apenasAdmin = false)
        {
            bool isAdmin = _contexto.UsuarioLogadoIsAdmin();
            if ((isAdmin && apenasAdmin) || !apenasAdmin)
                tela.ShowDialog();
            else
                MessageBox.Show("Existe um Administrador, peça permissão á ele para abrir está tela!");

        }
    }
}
