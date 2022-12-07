using System.Linq;
using System.Windows.Forms;
using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Servicos.ListVIewMetodos
{
    public class ListViewFunc : BaseServico
    {
        public bool ConfirmaDeletarItemDoList(ListView listview)
        {
            var quer = MessageBox.Show("Tem certeza que deseja deletar o usuário?", "Deletar!!!", MessageBoxButtons.YesNo);
            if (quer == DialogResult.Yes)
            {
                if (ExisteLinhaSelecionada(listview))
                    return true;
                else
                    return false;
            }
            return false;
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
