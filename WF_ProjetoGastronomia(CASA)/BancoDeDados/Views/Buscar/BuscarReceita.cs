using BancoDeDados.Contexto;
using BancoDeDados.Controller.Model;
using BancoDeDados.Servicos.ListVIewMetodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BancoDeDados.Views.Buscar
{
    public partial class BuscarReceita : FormBase
    {
        public ListView _listViewReceita;
        public List<Receita> receitasSaidas;
        public int _pedidoId;
        public BuscarReceita()
        {
            InitializeComponent();
        }

        public BuscarReceita(ListView listview, int pedidoId)
        {
            _pedidoId = pedidoId;
            _listViewReceita = listview;
        }
        private void PreencheListReceita()
        {
            PreencheListaReceitasAdicionadosAoPedido();
            var pesquisa = textBoxPesquisa.Text;
            if (!string.IsNullOrWhiteSpace(pesquisa))
            {
                PreencheListReceitasPeloFiltro(pesquisa);
            }
        }

        private void PreencheListReceitasPeloFiltro(string pesquisa)
        {
            var retonaLista = _banco.RetornarLista<Receita>().Where(e => e.NomeReceita.Contains(pesquisa.Trim())).ToList();

            listViewFunc.PreencheListView<Receita, ReceitaListView>(listViewReceitas,
               retonaLista,
               new string[]
                   {
                            "Id","NomeReceita","PrecoVenda","Lucro"
                   }
            );
        }

        private void PreencheListaReceitasAdicionadosAoPedido()
        {
            var receitasDoPedido = _banco.RetornaReceitasDoPedido(_pedidoId);
            listViewFunc.PreencheListView<Receita, ReceitaListView>(listViewAdicionados,
               receitasDoPedido,
               new string[]
                   {
                            "Id","NomeReceita","PrecoVenda","Lucro"
                   }
            );
        }

        private void BuscarReceita_Load(object sender, System.EventArgs e)
        {

           PreencheListReceita();
        }

        private void textBoxPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
           PreencheListReceita();
        }

        private void btnAdicionar_Click(object sender, System.EventArgs e)
        {
            if (listViewFunc.ExisteLinhaSelecionada(listViewReceitas))
            {
                btnAdicionar.Enabled = true;
                var quantidade = _servico.FormataDinheiro(textBoxQuantidadeReceita.Text);

                var receitaSelecionada = listViewFunc.RetornaItemLinhaSelecionada<Receita>(listViewReceitas);
                if (receitasSaidas.Contains(receitaSelecionada))
                {
                    receitasSaidas.Where(rec => rec.Id == receitaSelecionada.Id).First().QuantidadeReceita = quantidade;
                }
                else
                {
                    receitasSaidas.Add(receitaSelecionada);
                }
                PreencheListReceitaAdicionado();
            }
            else
            {
                btnAdicionar.Enabled = false;
            }
        }

        private void PreencheListReceitaAdicionado()
        {
            listViewFunc.PreencheListView<Receita, ReceitaListView>(listViewReceitas,
               receitasSaidas,
               new string[]
                   {
                            "Id","NomeReceita","PrecoVenda","Lucro"
                   }
            );
        }

        private void textBoxQuantidadeReceita_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxFunc.FormatoTextBoxDinheiro(sender, e);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
