using BancoDeDados.Contexto;
using BancoDeDados.Contexto.ClassesRelacionadas;
using BancoDeDados.Controller.Model;
using BancoDeDados.Models;
using BancoDeDados.Servicos.ComboBoxMetodos;
using BancoDeDados.Servicos.ListVIewMetodos;
using BancoDeDados.Servicos.TextBoxMetodos;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BancoDeDados.Controller.Telas
{
    public partial class GerenciarReceitas : FormBase
    {
        public GerenciarReceitas()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxFunc.FormatoTextBoxDinheiro(sender, e);
        }

        private void btnAdicionarProduto_Click(object sender, System.EventArgs e)
        {
            var receitaJaFoiCriada = listViewFunc.ExisteLinhaSelecionada(listViewReceitas);
            if (receitaJaFoiCriada)
            {
                var receitaSelecionada = listViewFunc.RetornaItemLinhaSelecionada<Receita>(listViewReceitas);
                var produtoSelecionado = comboBoxFunc.RetornaItemComboSelecionado<Produto>(comboBoxProdutos);
                var quantidade = decimal.Parse(textBoxQuantidadeProduto.Text);
                for(var i = 0; i < quantidade; i++)
                {
                    if (produtoSelecionado != null)
                    {
                        var produtoReceita = new ProdutoReceita()
                        {
                            Produto = produtoSelecionado,
                            ProdutoId = produtoSelecionado.Id,
                            Receita = receitaSelecionada,
                            ReceitaId = receitaSelecionada.Id,
                        };
                        _banco.Cadastrar<ProdutoReceita>(produtoReceita);
                        var lista = _banco.RetornaProdutosDaReceita(receitaSelecionada.Id);
                        listViewFunc.PreencheListView<Produto, Produto>(listViewProdutos,
                        lista,
                        new string[]
                        {
                            "Id","Nome","PrecoPorQuantidade"
                        });
                    }
                }
            }
        }
        private void PreencheListViews(int id = 0)
        {
            listViewFunc.PreencheListView<Receita, ReceitaListView>(listViewReceitas,
               new string[]
               {
                    "Id","NomeReceita","PrecoCusto"
               }
            );
            var listaProdutos = _banco.RetornaProdutosDaReceita(id);
            listViewFunc.PreencheListView<Produto, Produto>(listViewProdutos,
                listaProdutos,
                new string[]
                {
                    "Id","Nome","PrecoPorQuantidade"
                });
            var listaGastos = _banco.RetornaGastosDaReceita(id);
            listViewFunc.PreencheListView<GastoReceitaListView, GastoReceitaListView>(listViewGastos,
                listaGastos,
                new string[]
                {
                    "Id","Nome","Valor"
                }      
            );
        }
        private void GerenciarReceitas_Load(object sender, System.EventArgs e)
        {
            PreencheListViews();
            PreencheComboBoxes();
            btnDeletarLinha.Enabled = false;
            btnDeletar.Enabled = false;
            listViewGastos.Enabled = false;
            listViewProdutos.Enabled = false;
        }

        private void PreencheComboBoxes()
        {
            comboBoxFunc.PreencheComboBox<Produto>(comboBoxProdutos, "Nome");
            comboBoxFunc.PreencheComboBox<Gasto>(comboBoxGastos, "Nome");
            comboBoxFunc.PreencheComboBox<TipoReceita>(comboBoxTipoReceita, "Descricao");
        }

        private void textBoxPrecoReceita_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxFunc.FormatoTextBoxDinheiro(sender, e);
        }

        private void textBoxPotenciaKwh_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxFunc.FormatoTextBoxDinheiro(sender, e);
        }

        private void btnDeletar_Click(object sender, System.EventArgs e)
        {
            if (listViewFunc.ConfirmaDeletarItemDoList(listViewReceitas))
            {
                var receitaSelecionada = listViewFunc.RetornaItemLinhaSelecionada<Receita>(listViewReceitas);
                _banco.Deletar<Receita>(receitaSelecionada);
            }
        }

        private void btnDeletarLinha_Click(object sender, System.EventArgs e)
        {
            if (listViewFunc.ConfirmaDeletarItemDoList(listViewProdutos))
            {//PRODUTOS
                var produtoSelecionado = listViewFunc.RetornaItemLinhaSelecionada<Produto>(listViewProdutos);
                _banco.Deletar(produtoSelecionado);
            }
            else if (listViewFunc.ConfirmaDeletarItemDoList(listViewGastos))
            {// Gastos
                var gastoSelecionado = listViewFunc.RetornaItemLinhaSelecionada<Gasto>(listViewGastos);
                _banco.Deletar(gastoSelecionado);
            }
        }
        private void Limpar()
        {
            listViewGastos.SelectedIndices.Clear();
            listViewProdutos.SelectedIndices.Clear();

            textBoxNomeReceita.Text = "";
            textBoxPotenciaKwh.Text = "";
            textBoxPrecoReceita.Text = "";
            textBoxQuantidadeProduto.Text = "";
            comboBoxProdutos.SelectedIndex = -1;
            comboBoxTipoReceita.SelectedIndex = -1;
            tempoDePreparo.Text = "";

        }
        private void listViewProdutos_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listViewFunc.ExisteLinhaSelecionada(listViewProdutos))
            {
                btnDeletarLinha.Enabled = true;
            }
            else
            if (listViewFunc.ExisteLinhaSelecionada(listViewGastos))
            {
                btnDeletarLinha.Enabled = true;
            }
        }

        private void btnLimpar_Click(object sender, System.EventArgs e)
        {
            Limpar();
        }
        private void listViewReceitas_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listViewFunc.ExisteLinhaSelecionada(listViewReceitas))
            {
                var receita = listViewFunc.RetornaItemLinhaSelecionada<Receita>(listViewReceitas);
                PreencheListViewsDaReceita(receita.Id);
                btnDeletar.Enabled = true;
                listViewGastos.Enabled = true;
                listViewProdutos.Enabled = true;
                btnDeletarLinha.Enabled = true;
            }
            else
            {
                btnDeletar.Enabled = false;
                listViewGastos.Enabled = false;
                listViewProdutos.Enabled = false;
                btnDeletarLinha.Enabled = false;
            }
        }

        private void PreencheListViewsDaReceita(int id)
        {
            var listaProdutos = _banco.RetornaProdutosDaReceita(id);
            listViewFunc.PreencheListView<Produto, Produto>(listViewProdutos,
                listaProdutos,
                new string[]
                {
                    "Id","Nome","PrecoPorQuantidade"
                });
            var listaGastos = _banco.RetornaGastosDaReceita(id);
            listViewFunc.PreencheListView<GastoReceitaListView, GastoReceitaListView>(listViewGastos,
                listaGastos,
                new string[]
                {
                    "Id","Nome","Valor"
                }
            );
        }

        private void btnAdicionarGasto_Click(object sender, System.EventArgs e)
        {
            var receitaJaFoiCriada = listViewFunc.ExisteLinhaSelecionada(listViewReceitas);
            if (receitaJaFoiCriada)
            {
                var receitaSelecionada = listViewFunc.RetornaItemLinhaSelecionada<Receita>(listViewReceitas);
                var gastoSelecionado = comboBoxFunc.RetornaItemComboSelecionado<Gasto>(comboBoxProdutos);

                if (gastoSelecionado != null)
                {
                    var gastoReceita = new GastoReceita()
                    {
                        Gasto = gastoSelecionado,
                        GastoId = gastoSelecionado.Id,
                        Receita = receitaSelecionada,
                        ReceitaId = receitaSelecionada.Id,
                    };
                    _banco.Cadastrar<GastoReceita>(gastoReceita);
                    listViewFunc.PreencheListViewGastos(listViewGastos);
                }
            }
        }

        private void btnCadastrar_Click(object sender, System.EventArgs e)
        {
            var nomeReceita = textBoxNomeReceita.Text;
            var precoVenda = 0m;
            decimal.TryParse(textBoxPrecoReceita.Text, out precoVenda);
            var potenciaKwh = 0;
            int.TryParse(textBoxPotenciaKwh.Text, out potenciaKwh);
            var tipoReceita = comboBoxFunc.RetornaItemComboSelecionado<TipoReceita>(comboBoxTipoReceita);

            var receita = new Receita()
            {
                NomeReceita = nomeReceita,
                PrecoCusto = precoVenda,
                PotenciaKwh = potenciaKwh,
                TipoReceita = tipoReceita,

            };
            _banco.Cadastrar<Receita>(receita);
            PreencheListViews();

        }
    }
}
