using BancoDeDados.Contexto;
using BancoDeDados.Contexto.ClassesRelacionadas;
using BancoDeDados.Controller.Model;
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
        private ListViewFunc listViewFunc = new ListViewFunc();
        private ComboBoxFunc comboBoxFunc = new ComboBoxFunc();
        private TextBoxFunc textBoxFunc = new TextBoxFunc();
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

                if (produtoSelecionado != null)
                {
                    var produtoReceita = new ProdutoReceita()
                    {
                        Produto = produtoSelecionado,
                        ProdutoId = produtoSelecionado.Id,
                        Receita = receitaSelecionada,
                        ReceitaId = receitaSelecionada.Id,
                    };
                    _banco.Cadastrar<ProdutoReceita>();

                    listViewFunc.PreencheListViewProduto(listViewProdutos);
                }
            }
        }

        private void PreencheListViews()
        {
            listViewFunc.PreencheListView<Produto,Produto>(listViewProdutos,
                produto => new Produto()
                {
                    Id = produto.Id,
                    Nome = produto.Nome,
                    PrecoPorQuantidade = produto.PrecoPorQuantidade,
                });
            listViewFunc.PreencheListView<Receita,Receita>(listViewReceitas,
                receita => new Receita()
            {
                    Id= receita.Id, 
                NomeReceita = receita.NomeReceita,
                PrecoCusto = receita.PrecoCusto,
            });
            listViewFunc.PreencheListView<Gasto, Gasto>(listViewGastos,
                gasto => new Gasto()
            {
                Id = gasto.Id,
                Nome = gasto.Nome,
                Valor = gasto.Valor,
            });
        }
        private void GerenciarReceitas_Load(object sender, System.EventArgs e)
        {
            PreencheListViews();
            PreencheComboBoxes();
            btnDeletarLinha.Enabled = false;
            btnDeletar.Enabled = false;
        }

        private void PreencheComboBoxes()
        {
            comboBoxFunc.PreencheComboBox<ProdutoComboBox, ProdutoComboBox>(comboBoxProdutos,
                produto => new ProdutoComboBox()
                {
                    Id = produto.Id,
                    Descricao = produto.Nome
                }
            );
            comboBoxFunc.PreencheComboBox<Gasto,Gasto>(comboBoxGastos,
               (gasto) => new Gasto()
               {
                   Id = gasto.Id,
                   Descricao = gasto.Nome,
               }
            );
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
            // não funciona, em testes
            //_servico.LimparTodosComponentesDoForm(form);

            Limpar();
        }

        private void listViewReceitas_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listViewFunc.ExisteLinhaSelecionada(listViewReceitas))
            {
                btnDeletar.Enabled = true;
            }
            else
            {
                btnDeletar.Enabled = false;
            }
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

        }
    }
}
