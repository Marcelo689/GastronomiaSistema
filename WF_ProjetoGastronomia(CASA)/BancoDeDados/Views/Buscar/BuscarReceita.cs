using BancoDeDados.Contexto;
using BancoDeDados.Contexto.ClassesRelacionadas;
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
        public List<Receita> receitasAdicionados;
        public int _pedidoId;
        public Pedido _pedido;
        public BuscarReceita()
        {
            InitializeComponent();
        }

        public BuscarReceita(ListView listview, int pedidoId)
        {
            InitializeComponent();
            _pedidoId = pedidoId;
            _pedido = _banco.RetornarLista<Pedido>(_pedidoId).First();
            _listViewReceita = listview;
        }
        private void PreencheListReceita()
        {
            PreencheListaReceitasAdicionadosAoPedido();
            var pesquisa = textBoxPesquisa.Text;
            if (!string.IsNullOrWhiteSpace(pesquisa))
                PreencheListReceitasPeloFiltro(pesquisa);
            else
                TodasReceitas();
        }

        private void PreencheListReceitasPeloFiltro(string pesquisa)
        {
            var retonaLista = _banco.RetornarLista<Receita>().Where(e => e.NomeReceita.ToLower().Contains(pesquisa.ToLower().Trim())).ToList();

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
            var receitasDoPedido = receitasAdicionados = _banco.RetornaReceitasDoPedido(_pedidoId);
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

        private void TodasReceitas()
        {
            listViewFunc.PreencheListView<Receita, ReceitaListView>(listViewReceitas,
               new string[]
                   {
                            "Id","NomeReceita","PrecoVenda","Lucro"
                   }
            );
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
                if (receitasAdicionados.Contains(receitaSelecionada))
                {
                    receitasAdicionados.Where(rec => rec.Id == receitaSelecionada.Id).First().QuantidadeReceita = quantidade;
                    var receitaDoPedido = _banco.RetornarLista<ReceitaDoPedido>().Where(rp => rp.PedidoId == _pedidoId && rp.ReceitaId == receitaSelecionada.Id).First();
                    receitaDoPedido.QuantidadeReceita = quantidade;
                    _banco.Atualizar<ReceitaDoPedido>(receitaDoPedido);
                }
                else
                {
                    receitasAdicionados.Add(receitaSelecionada);
                    var receitaPedido = new ReceitaDoPedido()
                    {
                        Pedido = _pedido,
                        PedidoId = _pedidoId,
                        QuantidadeReceita = quantidade,
                        ReceitaId = receitaSelecionada.Id,
                        Receita = receitaSelecionada,
                    };

                    _banco.Cadastrar<ReceitaDoPedido>(receitaPedido);
                    
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
            listViewFunc.PreencheListView<Receita, ReceitaListView>(listViewAdicionados,
               receitasAdicionados,
               new string[]
                   {
                        "Id","NomeReceita","PrecoVenda","Lucro"
                   }
            );

            listViewFunc.PreencheListView<Receita, ReceitaListView>(_listViewReceita,
               receitasAdicionados,
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

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {
            PreencheListReceita();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (listViewFunc.ExisteLinhaSelecionada(listViewAdicionados))
            {
                var receitaSelecionada = listViewFunc.RetornaItemLinhaSelecionada<Receita>(listViewAdicionados);

                if (listViewFunc.ConfirmaDeletarItemDoList(listViewAdicionados))
                {
                    var receitaDoPedido = _banco.RetornarLista<ReceitaDoPedido>().Where(rp =>
                        rp.PedidoId == _pedidoId &&
                        rp.ReceitaId == receitaSelecionada.Id
                    ).First();
                    _banco.Deletar<ReceitaDoPedido>(receitaDoPedido);
                    receitasAdicionados.Remove(receitaSelecionada);
                    PreencheListReceitaAdicionado();
                }

            }
        }
    }
}
