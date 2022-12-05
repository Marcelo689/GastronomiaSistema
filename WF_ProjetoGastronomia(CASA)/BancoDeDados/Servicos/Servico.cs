using BancoDeDados.Models;
using System.Linq;
using System.Windows.Forms;
using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Servicos
{
    public class Servico : BaseServico
    {
        public Servico()
        {

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
        public bool ExisteLinhaSelecionada(ListView listView)
        {
            var linhasSelecionadas = listView.SelectedItems;

            if (linhasSelecionadas.Count > 0)
                return true;
            return false;
        }
        public T RetornaItemLinhaSelecionada<T>(ListView listView) where T : TEntity
        {
            if (!ExisteLinhaSelecionada(listView))
                return null;
            var indice = listView.SelectedIndices[0];

            int? id = int.Parse(listView.Items[indice].Tag.ToString());
            
            var entidade = _banco.RetornarLista<T>(id).FirstOrDefault();

            return entidade;
        }
        
    }
}
