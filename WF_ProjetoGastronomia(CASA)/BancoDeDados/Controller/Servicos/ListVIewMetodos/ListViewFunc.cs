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

        public void DesSelecionionaListView(ListView listView)
        {
            if (listView.SelectedIndices.Count > 0)
                for (int i = 0; i < listView.SelectedIndices.Count; i++)
                {
                    listView.Items[listView.SelectedIndices[i]].Selected = false;
                }
        }
        public bool ConfirmaDeletarItemDoList(ListView listview)
        {
            var quer = MessageBox.Show("Tem certeza que deseja deletar o item?", "Deletar!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
        public string[] RetornaPropriedadesEmStringArray<T>(T item,params string [] propriedadesSelecionadas) 
            where T : TEntity
        {
            var propriedades = item.GetType().GetProperties();
            List<String> colunasStrings = new List<String>();
           
            foreach (var lin in propriedades)
            {
                var nome = lin.Name;
                if (!propriedadesSelecionadas.Contains(nome))
                    continue;
                if (nome == "Id")
                    continue;
                var valor = lin.GetValue(item);
                var Tipo = lin.PropertyType;

                if (nome == "ClienteId")
                {
                    var teste = lin.GetValue(item);
                    int idCliente = int.Parse(teste.ToString());
                    var clienteNome = _banco.RetornarLista<Cliente>(idCliente).First().NomeCompleto;
                    valor = clienteNome;
                }
                else
                if (Tipo == typeof(decimal))
                    valor = decimal.Parse(lin.GetValue(item).ToString()).ToString("F2");
                else
                if (Tipo == typeof(UnidadeMedida))
                    valor = (lin.GetValue(item) as UnidadeMedida).Descricao;
                
                if (valor != null)
                    colunasStrings.Add(valor.ToString());
                else
                    colunasStrings.Add("");
            }

            return colunasStrings.ToArray();
        }
        public void PreencheListView<T, R>(ListView listView, params string[] propriedadesSelecionadas) 
            where T : TEntity 
            where R : TEntity
        {
            var lista = new List<T>();
            lista = _banco.RetornarLista<T>();
            listView.Items.Clear();
            
            foreach (var item in lista)
            {
                var colunasValues = RetornaPropriedadesEmStringArray<T>(item, propriedadesSelecionadas);
                var listItem = new ListViewItem(
                    colunasValues
                );

                listItem.Tag = item.Id;
                listView.Items.Add(listItem);
            }
        }

        public void PreencheListView<T, R>(ListView listView,List<T> lista, params string[] propriedadesSelecionadas)
           where T : TEntity
           where R : TEntity
        {
            listView.Items.Clear();

            foreach (var item in lista)
            {
                var colunasValues = RetornaPropriedadesEmStringArray<T>(item, propriedadesSelecionadas);
                var listItem = new ListViewItem(
                    colunasValues
                );

                listItem.Tag = item.Id;
                listView.Items.Add(listItem);
            }
        }
        public void PreencheListViewProduto(ListView listView,List<Produto> lista = null)
        {
            if(lista == null)
               lista = _banco.RetornarLista<Produto>();

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
                        item.PrecoVenda.ToString("F2"),
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
