using BancoDeDados.Contexto;
using BancoDeDados.Controller.Telas;
using BancoDeDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public string[] RetornaPropriedadesEmStringArray<T>(T item) where T : TEntity
        {
            var propriedades = item.GetType().GetProperties();
            List<String> colunasStrings = new List<String>();
            foreach (var lin in propriedades)
            {
                var nome = lin.Name;
                if (nome == "Id")
                    continue;
                var TipoDecimal = lin.PropertyType;
                var valor = lin.GetValue(item);
                if (TipoDecimal == typeof(decimal))
                    valor = decimal.Parse(lin.GetValue(item).ToString()).ToString("F2");
                if (valor != null)
                    colunasStrings.Add(valor.ToString());
                else
                    colunasStrings.Add("");
            }

            return colunasStrings.ToArray();
        } 
        public void PreencheListView<T,R>(ListView listView, Func<T,R> filtro) 
            where T : TEntity 
            where R : TEntity
        {
            var listaFiltrada = _banco.RetornaListaComAlgumasColunas<T,R>(filtro);
            
            listView.Items.Clear();
            foreach (var item in listaFiltrada)
            {
                var colunasValues = RetornaPropriedadesEmStringArray<R>(item);
                var listItem = new ListViewItem(
                    colunasValues
                );

                listItem.Tag = item.Id;
                listView.Items.Add(listItem);
            }
        }
        public void PreencheListViewProduto(ListView listView)
        {
            var lista = _banco.RetornarLista<Produto>();

            listView.Items.Clear();
            foreach (var item in lista)
            {
                var listItem = new ListViewItem(
                    new string []{
                        item.Nome,
                        item.PrecoPorQuantidade.ToString("F2"),
                        item.UnidadeMedida.Sigla
                    }
                );

                listItem.Tag = item.Id;
                listView.Items.Add(listItem);
            }
        }

        public void PreencheListViewUnidadeMedida(ListView listView)
        {
            var lista = _banco.RetornarLista<UnidadeMedida>();

            listView.Items.Clear();
            foreach (var item in lista)
            {
                var listItem = new ListViewItem(
                    new string[]{
                        item.Descricao,
                        item.Sigla
                    }
                );

                listItem.Tag = item.Id;
                listView.Items.Add(listItem);
            }
        }

        public void PreencheListViewReceitas(ListView listView)
        {
            var lista = _banco.RetornarLista<Receita>();

            listView.Items.Clear();
            foreach (var item in lista)
            {
                var listItem = new ListViewItem(
                    new string[]{
                        item.NomeReceita,
                        item.PrecoCusto.ToString("F2"),
                        //item.TempoDePreparo.ToString()
                    }
                );

                listItem.Tag = item.Id;
                listView.Items.Add(listItem);
            }
        }

        public void PreencheListViewGastos(ListView listViewGastos)
        {
            var lista = _banco.RetornarLista<Gasto>();

            listViewGastos.Items.Clear();
            foreach (var item in lista)
            {
                var listItem = new ListViewItem(
                    new string[]{
                        item.Nome,
                        item.Valor.ToString("F2")
                    }
                );

                listItem.Tag = item.Id;
                listViewGastos.Items.Add(listItem);
            }
        }
    }
}
