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
        public void PreencheComboBox<T>(ComboBox combo) where T : ComboBoxFunc
        {
            if (combo is null)
            {
                throw new ArgumentNullException(nameof(combo));
            }

            List<T> lista = _banco.RetornarLista<T>();

            var _lista = (from u in lista select new { Id = u.Id, Descricao = u.Descricao }).ToList();
            combo.Items.Clear();
            combo.SelectedIndex = -1;
            combo.DataSource = _lista;
            combo.DisplayMember = "Descricao";
            combo.ValueMember = "Id";
        }
        public T RetornaItemComboSelecionado<T>(int indiceComboBox) where T : TEntity
        {
            List<T> lista = _banco.RetornarLista<T>();
            var idsLista = (from u in lista select new { u.Id }).ToList();
            var idSelecionado = idsLista[indiceComboBox].Id;
            var Entity = _banco.RetornarLista<T>(idSelecionado).First();
            return Entity;
        }

    }
}
