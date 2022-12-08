using BancoDeDados.Contexto;
using BancoDeDados.Controller.Model;
using BancoDeDados.Models;
using BancoDeDados.Servicos.ComboBoxMetodos;
using BancoDeDados.Servicos.ListVIewMetodos;
using BancoDeDados.Servicos.TextBoxMetodos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BancoDeDados.Controller.Telas
{
    public partial class GerenciarProdutos : FormBase
    {
        private ListViewFunc listViewFunc = new ListViewFunc();
        private ComboBoxFunc comboBoxFunc = new ComboBoxFunc();
        private TextBoxFunc textBoxFunc = new TextBoxFunc();
        public GerenciarProdutos()
        {
            InitializeComponent();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFunc.ExisteLinhaSelecionada(listView1))
            {
                var produtoSelecionado = listViewFunc.RetornaItemLinhaSelecionada<Produto>(listView1);
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
            var existeLinhaSelecionada = listViewFunc.ExisteLinhaSelecionada(listView1);
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
                var produtoSelecionado = listViewFunc.RetornaItemLinhaSelecionada<Produto>(listView1);
                produtoSelecionado.Nome = nomeProduto;
                produtoSelecionado.PrecoPorQuantidade = preco;
                produtoSelecionado.UnidadeMedida = RetornaUnidadeMedidaSelecionado(indiceCombo);
                _banco.Atualizar<Produto>(produtoSelecionado);
                listViewFunc.PreencheListViewProduto(listView1);
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
                listViewFunc.PreencheListViewProduto(listView1);
            }

        }
        private UnidadeMedida RetornaUnidadeMedidaSelecionado(int indiceComboBox)
        {
            return comboBoxFunc.RetornaItemComboSelecionado<UnidadeMedida>(indiceComboBox);
        }
        private void PreencheComboBox()
        {
            comboBoxFunc.PreencheComboBox<UnidadeMedida>(comboBoxUnidadesMedida);
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
        
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (listViewFunc.ConfirmaDeletarItemDoList(listView1))
            {
                var produtoSelecionado = listViewFunc.RetornaItemLinhaSelecionada<Produto>(listView1);
                _banco.Deletar(produtoSelecionado);
                listViewFunc.PreencheListViewProduto(listView1);
                Limpar();
            }
            
        }
        private void GerenciarProdutos_Load(object sender, EventArgs e)
        {
            PreencheComboBox();
            listViewFunc.PreencheListViewProduto(listView1);
        }
        private void textBoxPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxFunc.FormatoTextBoxDinheiro(sender, e);
        }
    }
}
