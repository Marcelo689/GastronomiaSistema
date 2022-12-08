using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
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
        public override string ToString()
        {
            return this.GetType().GetProperties()
                .Select(info => (info.Name, Value: info.GetValue(this, null) ?? "(null)"))
                .Aggregate(
                    new StringBuilder(),
                    (sb, pair) => sb.AppendLine($"{pair.Name}: {pair.Value}"),
                    sb => sb.ToString());
        }

        private string [] GetValuesFromStringArray(string [] array)
        {
            string saida = "";  
            foreach (var item in array)
            {
                if(item.Contains(":"))
                    saida += item.Split(':')[1].ToString() + ":";
            }

            return saida.Split(':');
        }
        //private string [] GetValuesFromStringArray(string[] array)
        //{
        //    string[] chaves = new string[array.Length];
        //    string[] valores = new string[array.Length];
        //    for(var i=0; i< array.Length; i++)
        //    {
        //        if(i % 2 == 0)
        //            chaves[i] = array[i].ToString();
        //        else
        //            valores[i] = array[i].ToString();
        //    }

        //    return valores;
        //} 
        public void PreencheListView<T>(ListView listView, Func<T,T> filtro) where T : TEntity
        {
            var listaFiltrada = _banco.RetornaListaComAlgumasColunas<T>(filtro);
            
            listView.Items.Clear();
            foreach (var item in listaFiltrada)
            {
                var listaPropriedades = item.ToString().Replace("\r\n", "?");

                var arrayString = listaPropriedades.Split('?');
                var colunasValues = GetValuesFromStringArray(arrayString);

                var listItem = new ListViewItem(
                    colunasValues
                //teste
                );

                listItem.Tag = item.Id;
                listView.Items.Add(listItem);
            }
        }
    }
}
