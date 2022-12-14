using BancoDeDados.Contexto;
using BancoDeDados.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Servicos.ComboBoxMetodos
{
    public class ComboBoxFunc : TEntity
    {
        protected BDContexto _contexto;
        protected OperacoesBanco _banco;
        public ComboBoxFunc()
        {
            if (_contexto == null)
                _contexto = new BDContexto().getInstancia();
            if (_banco == null)
                _banco = new OperacoesBanco();
        }
        public virtual string Descricao { get; set; }
        public virtual string Sigla { get; set; }

        private bool ExisteItemSelecionado(ComboBox combo)
        {
            if( combo.SelectedIndex == -1)
            {
                MessageBox.Show("Primeiro você deve selecionar um produto!");
                return false;
            }
            return true;
        }
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
        public interface NameAndId
        {
            string Name { get; set; }
            string Id { get; set; }
        }

        public void PreencheComboBox<Entrada>(ComboBox combo,string ValueProperyName) 
            where Entrada : TEntity 
        {
            if (combo is null)
            {
                throw new ArgumentNullException(nameof(combo));
            }

            List<Entrada> lista = _banco.RetornarLista<Entrada>();

            //var _lista = (from u in lista select new { Id = u.Id, Descricao = u.Sigla }).ToList();
            //var _lista = (from u in lista select idEDescricao).ToList();
            combo.DataSource = null;
            combo.Items.Clear();
            combo.SelectedIndex = -1;
            combo.DataSource = lista;

            combo.DisplayMember = ValueProperyName;
            combo.ValueMember = "Id";
        }
        public T RetornaItemComboSelecionado<T>(ComboBox combo) where T : TEntity , new()
        {
            var existe = ExisteItemSelecionado(combo);
            if (existe)
            {
                //var indiceComboBox = combo.SelectedIndex;
                var idSelecionado = int.Parse( combo.SelectedValue.ToString());
                //List<T> lista = _banco.RetornarLista<T>();
                //var idsLista = (from u in lista select new { u.Id }).ToList();
                //var idSelecionado = idsLista[indiceComboBox].Id;
                var Entity = _banco.RetornarLista<T>(idSelecionado).First();
                return Entity;
            }

            return new T();
        }

    }
}
