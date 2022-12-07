using BancoDeDados.Contexto;
using BancoDeDados.Controller.Model;
using BancoDeDados.Models;
using BancoDeDados.Servicos;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace BancoDeDados.Controller.Telas
{
    public partial class GerenciarProdutos : FormBase
    {
        private List<UnidadeMedida> unidadeMedidas = new List<UnidadeMedida>();
        public GerenciarProdutos()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_servico.ExisteLinhaSelecionada(listView1))
            {
                var produtoSelecionado = _servico.RetornaItemLinhaSelecionada<Produto>(listView1);
                textBoxNomeProduto.Text = produtoSelecionado.Nome;
                textBoxPreco.Text = _servico.FormataValor(produtoSelecionado.PrecoPorQuantidade);
                comboBoxUnidadesMedida.SelectedIndex = comboBoxUnidadesMedida.FindStringExact(produtoSelecionado.UnidadeMedida.Descricao);
                btnDeletar.Enabled = true;
            }
            else
                btnDeletar.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool ExisteNomeProduto(string nomeProduto)
        {
            return _contexto.Produtos.Where(p => p.Nome == nomeProduto).Any();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var nomeProduto = textBoxNomeProduto.Text;
            var preco = _servico.FormataDinheiro(textBoxPreco.Text);
            var indiceCombo = comboBoxUnidadesMedida.SelectedIndex;
            var existeLinhaSelecionada = _servico.ExisteLinhaSelecionada(listView1);
            if (string.IsNullOrWhiteSpace(nomeProduto))
                MessageBox.Show("Digite o nome do produto!");
            else
            if (ExisteNomeProduto(nomeProduto) && !existeLinhaSelecionada)
            {
                MessageBox.Show("Nome do produto já existe!");
                return;
            }else if(indiceCombo == -1)
            {
                MessageBox.Show("Selecione uma unidade de medida!");
                return;
            }else if (existeLinhaSelecionada)
            {//Atualizar
                var produtoSelecionado = _servico.RetornaItemLinhaSelecionada<Produto>(listView1);
                produtoSelecionado.Nome = nomeProduto;
                produtoSelecionado.PrecoPorQuantidade = preco;
                produtoSelecionado.UnidadeMedida = RetornaUnidadeMedidaSelecionado(indiceCombo);
                _banco.Atualizar<Produto>(produtoSelecionado);
                CarregarLista();
            }
            else // Cadastrar
            {
                var unidadeMedidaEntity = RetornaUnidadeMedidaSelecionado(indiceCombo);
                _banco.Cadastrar<Produto>(
                    new Produto()
                    {
                        Nome = nomeProduto,
                        PrecoPorQuantidade = preco,
                        UnidadeMedida = unidadeMedidaEntity
                    }
                );
                CarregarLista();
            }

        }
        private UnidadeMedida RetornaUnidadeMedidaSelecionado(int indiceComboBox)
        {
            var idUnidadeMedidas = (from u in unidadeMedidas select new { u.Id}).ToList();
            var idSelecionado = idUnidadeMedidas[indiceComboBox].Id;
            var unidadeMedidaEntity = _banco.RetornarLista<UnidadeMedida>(idSelecionado).First();
            return unidadeMedidaEntity;
        }
        private void PreencheComboBox()
        {
            unidadeMedidas = _banco.RetornarLista<UnidadeMedida>();

            var _unidades = (from u in unidadeMedidas select new { Id = u.Id, Descricao = u.Descricao}).ToList();
            comboBoxUnidadesMedida.Items.Clear();
            comboBoxUnidadesMedida.SelectedIndex = -1;
            comboBoxUnidadesMedida.DataSource = _unidades;
            comboBoxUnidadesMedida.DisplayMember = "Descricao";
            comboBoxUnidadesMedida.ValueMember = "Id";
        }

        private void Limpar()
        {
            textBoxNomeProduto.Text = "";
            textBoxPreco.Text = "0.0";
            btnDeletar.Enabled = false;
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void CarregarLista()
        {
            var lista = _banco.RetornarLista<Produto>();
            listView1.Items.Clear();
            foreach (var linha in lista)
            {
                var listItem = new ListViewItem(
                        new String[]
                        {
                            linha.Nome,
                            linha.PrecoPorQuantidade.ToString("F2"),
                            linha.UnidadeMedida.Descricao
                        }

                );
                listItem.Tag = linha.Id;
                listView1.Items.Add(listItem);
            }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (_servico.ConfirmaDeletarItemDoList(listView1))
            {
                var produtoSelecionado = _servico.RetornaItemLinhaSelecionada<Produto>(listView1);
                _banco.Deletar(produtoSelecionado);
                CarregarLista();
                Limpar();
            }
            
        }

        private void GerenciarProdutos_Load(object sender, EventArgs e)
        {
            PreencheComboBox();
            CarregarLista();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                    !char.IsControl(e.KeyChar) && 
                    !char.IsDigit(e.KeyChar)   &&
                    (e.KeyChar != '.')
                )
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
