using BancoDeDados.Contexto;
using BancoDeDados.Contexto.ClassesRelacionadas;
using BancoDeDados.Controller.Model;
using BancoDeDados.Models;
using BancoDeDados.Servicos.ListVIewMetodos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace BancoDeDados.Controller.Telas
{
    public partial class GerenciarReceitas : FormBase
    {
        public List<Produto> _produtos = new List<Produto>();
        public List<Gasto>   _gastos   = new List<Gasto>();
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
                var quantidade = _servico.FormataDinheiro(textBoxQuantidadeProduto.Text);
                
                if (produtoSelecionado != null)
                {
                    var ProdutoReceitaList = _banco.RetornarLista<ProdutoReceita>().Where(
                        pr => pr.ProdutoId == produtoSelecionado.Id && pr.ReceitaId == receitaSelecionada.Id
                    );

                    var existeProdutoReceitaList = ProdutoReceitaList.Any();

                    if (existeProdutoReceitaList)
                    {
                        var produtoReceitaAtualizar = ProdutoReceitaList.First();
                        if(produtoReceitaAtualizar.QuantidadeProduto != quantidade)
                        {
                            produtoReceitaAtualizar.QuantidadeProduto = quantidade;
                            _banco.Atualizar<ProdutoReceita>(produtoReceitaAtualizar);

                            PreencheListViewsDaReceita(receitaSelecionada.Id);
                        }
                    }
                    else
                    {
                        var produtoReceita = new ProdutoReceita()
                        {
                            Produto = produtoSelecionado,
                            ProdutoId = produtoSelecionado.Id,
                            Receita = receitaSelecionada,
                            ReceitaId = receitaSelecionada.Id,
                            QuantidadeProduto = quantidade
                        };
                        _banco.Cadastrar<ProdutoReceita>(produtoReceita);
                        PreencheListViewsDaReceita(receitaSelecionada.Id);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Primeiro Selecione a receita que deseja adicionar");
            }
        }
        private void PreencheListReceita()
        {
            var lista = _banco.RetornarLista<Receita>();
            listViewFunc.PreencheListView<Receita, ReceitaListView>(listViewReceitas,
                lista,   
                new string[]
                    {
                        "Id","NomeReceita","PrecoVenda","Lucro"
                    }
                );
        }

        private void GerenciarReceitas_Load(object sender, System.EventArgs e)
        {
            textBoxTempoPreparo.Text = "00:00:00";
            PreencheListReceita();
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
                PreencheListReceita();
            }
        }

        private void btnDeletarLinha_Click(object sender, System.EventArgs e)
        {
            if(listViewFunc.ExisteLinhaSelecionada(listViewProdutos))
            if (listViewFunc.ExisteLinhaSelecionada(listViewProdutos) && 
                listViewFunc.ConfirmaDeletarItemDoList(listViewProdutos) &&
                listViewFunc.ExisteLinhaSelecionada(listViewReceitas)
                ) 
            {//PRODUTOS
                var receitaSelecionada = listViewFunc.RetornaItemLinhaSelecionada<Receita>(listViewReceitas);
                var produtoSelecionado = listViewFunc.RetornaItemLinhaSelecionada<Produto>(listViewProdutos);
                var produtoReceitaSelecionado = _contexto.ProdutosReceita.Where(pr => pr.ReceitaId == receitaSelecionada.Id && pr.ProdutoId == produtoSelecionado.Id);

                if (produtoReceitaSelecionado.Any())
                {
                    _banco.Deletar<ProdutoReceita>(produtoReceitaSelecionado.First().Id);
                    PreencheListViewsDaReceita(receitaSelecionada.Id);
                }
            }
            else
            {
                MessageBox.Show("Selecione a receita e em seguida o sub item(produto ou gasto) que deseja remover na lista!", "Deletar item da lista!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (listViewFunc.ExisteLinhaSelecionada(listViewGastos))
                if (listViewFunc.ExisteLinhaSelecionada(listViewGastos) &&
                    listViewFunc.ExisteLinhaSelecionada(listViewReceitas) &&
                    listViewFunc.ConfirmaDeletarItemDoList(listViewGastos)
                    )
                {// Gastos
                    var receitaSelecionada = listViewFunc.RetornaItemLinhaSelecionada<Receita>(listViewReceitas);
                    var gastoSelecionado = listViewFunc.RetornaItemLinhaSelecionada<Gasto>(listViewGastos);
                
                    if(receitaSelecionada != null && gastoSelecionado != null)
                    {
                        var gastoReceitaSelecionado = _contexto.GastosReceita.Where(pr => pr.ReceitaId == receitaSelecionada.Id && pr.GastoId == gastoSelecionado.Id);

                        if (gastoReceitaSelecionado.Any())
                        {
                            var gasto = gastoReceitaSelecionado.First();
                            _banco.Deletar<GastoReceita>(gasto.Id);
                            PreencheListViewsDaReceita(receitaSelecionada.Id);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione a receita e em seguida o sub item(produto ou gasto) que deseja remover na lista!","Deletar item da lista!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }
        private void Limpar()
        {
            listViewGastos.SelectedIndices.Clear();
            listViewProdutos.SelectedIndices.Clear();
            listViewReceitas.SelectedIndices.Clear();
            textBoxNomeReceita.Text = "";
            textBoxPotenciaKwh.Text = "";
            textBoxPrecoReceita.Text = "";
            textBoxQuantidadeProduto.Text = "";
            comboBoxProdutos.SelectedIndex = -1;
            comboBoxTipoReceita.SelectedIndex = -1;
            textBoxTempoPreparo.Text = "";
            lblPrecoCusto.Text = "";

        }
        private void listViewProdutos_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            listViewFunc.DesSelecionionaListView(listViewGastos);
            if (listViewFunc.ExisteLinhaSelecionada(listViewProdutos))
            {
                btnDeletarLinha.Enabled = true;
            }
            else
                btnDeletarLinha.Enabled = false;
            
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
                PreencheCamposReceita(receita);

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
                listViewProdutos.Items.Clear();
                listViewGastos.Items.Clear();
            }
        }

        private void PreencheCamposReceita(Receita receita)
        {
            textBoxNomeReceita.Text = receita.NomeReceita;
            textBoxPotenciaKwh.Text = _servico.FormataValor(receita.PotenciaKwh);
            textBoxPrecoReceita.Text = _servico.FormataValor(receita.PrecoVenda);

            comboBoxTipoReceita.SelectedIndex = comboBoxTipoReceita.FindStringExact( receita.TipoReceita.Descricao);
            textBoxTempoPreparo.Text = receita.TempoDePreparo;
            PreencheTotal();
        }

        private void PreencheListViewsDaReceita(int id)
        {
            PreencheListReceita();
            PreencheListProdutos(id);
            PreencheListGastos(id);
            PreencheTotal();
            //listViewFunc.SelecionaItem(listViewReceitas, id);
        }

        private void PreencheListGastos(int id)
        {
            var listaGastos = _gastos = _banco.RetornaGastosDaReceita(id);
            listViewFunc.PreencheListView<Gasto, GastoReceitaListView>(listViewGastos,
                listaGastos,
                new string[]
                {
                    "Id","Nome","Valor" //,"QuantidadeGasto","TotalGasto"
                }
            );
        }

        private void PreencheTotal()
        {
            lblPrecoCusto.Text = "";
            var total = _servico.FormataDinheiro(lblPrecoCusto.Text);
            foreach (var produto in _produtos)
            {
                total += _servico.FormataDinheiro(produto.TotalProduto);
            }
            foreach (var gasto in _gastos)
            {
                total += _servico.FormataDinheiro(gasto.Valor.ToString("F2",CultureInfo.InvariantCulture));
            }

            var receitaSelecionada = listViewFunc.RetornaItemLinhaSelecionada<Receita>(listViewReceitas);
            if(receitaSelecionada != null)
            {
                receitaSelecionada.PrecoCusto = total;
                _banco.Atualizar<Receita>(receitaSelecionada);
            }

            lblPrecoCusto.Text = _servico.FormataValor(total);
        }

        private void PreencheListProdutos(int idReceita)
        {
            var listaProdutos = _produtos = _banco.RetornaProdutosDaReceita(idReceita);
            listViewFunc.PreencheListView<Produto, Produto>(listViewProdutos,
                listaProdutos,
                new string[]
                {
                    "Id","Nome","PrecoPorQuantidade","QuantidadeProduto","TotalProduto"
                });

        }

        private void btnAdicionarGasto_Click(object sender, System.EventArgs e)
        {
            var receitaJaFoiCriada = listViewFunc.ExisteLinhaSelecionada(listViewReceitas);
            if (receitaJaFoiCriada)
            {
                var receitaSelecionada = listViewFunc.RetornaItemLinhaSelecionada<Receita>(listViewReceitas);

                var gastoSelecionado = comboBoxFunc.RetornaItemComboSelecionado<Gasto>(comboBoxGastos);

                if (gastoSelecionado.Id > 0)
                {
                    var GastoNaReceita = _banco.RetornarLista<GastoReceita>().Where( gr => gr.ReceitaId == receitaSelecionada.Id && gr.GastoId == gastoSelecionado.Id);
                    
                    if (GastoNaReceita.Any() && GastoNaReceita.First().GastoId == gastoSelecionado.Id)
                    {//atualizar
                        MessageBox.Show("O item selecionado já foi adicionado!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var gastoReceita = new GastoReceita()
                        {
                            Gasto = gastoSelecionado,
                            GastoId = gastoSelecionado.Id,
                            Receita = receitaSelecionada,
                            ReceitaId = receitaSelecionada.Id,
                        };
                        _banco.Cadastrar<GastoReceita>(gastoReceita);
                        PreencheListReceita();
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Primeiro Selecione a receita que deseja adicionar");
            }
        }

        private void btnCadastrar_Click(object sender, System.EventArgs e)
        {
            var nomeReceita = textBoxNomeReceita.Text;
            var precoVenda  = textBoxPrecoReceita.Text;
            var potenciaKwh = textBoxPotenciaKwh.Text;
            var tipoReceita = comboBoxFunc.RetornaItemComboSelecionado<TipoReceita>(comboBoxTipoReceita);

            if (!ValidaReceita(nomeReceita, tipoReceita))
                return;
            if(listViewFunc.ExisteLinhaSelecionada(listViewReceitas))
            {
                var receitaAtualizar            = listViewFunc.RetornaItemLinhaSelecionada<Receita>(listViewReceitas);
                receitaAtualizar.TipoReceita    = tipoReceita;
                receitaAtualizar.Empresa        = _contexto.Login.Empresa;
                receitaAtualizar.EmpresaId      = _contexto.Login.EmpresaId;
                receitaAtualizar.PrecoVenda     = _servico.FormataDinheiro(precoVenda);
                receitaAtualizar.PotenciaKwh    = _servico.FormataDinheiro(potenciaKwh);
                receitaAtualizar.TempoDePreparo = textBoxTempoPreparo.Text;
                _banco.Atualizar<Receita>(receitaAtualizar);
                Limpar();
            }
            else
            {
                var receita = new Receita()
                {
                    NomeReceita = nomeReceita,
                    PrecoVenda  = _servico.FormataDinheiro(precoVenda),
                    PotenciaKwh = _servico.FormataDinheiro(potenciaKwh),
                    TipoReceita = tipoReceita,
                    Empresa     = _contexto.Login.Empresa,
                    EmpresaId   = _contexto.Login.EmpresaId
                };
                _banco.Cadastrar<Receita>(receita); 
                Limpar();
            }
            PreencheListReceita();

        }

        private bool ValidaReceita(string nomeReceita, TipoReceita tipoReceita)
        {
            var valido = false;
            if (string.IsNullOrWhiteSpace(nomeReceita))
            {
                MessageBox.Show("Preencha o campo Nome da Receita!");
            }
            else if (tipoReceita.Id == 0)
            {
                //mensagem exibida no proprio retornaitemCombo
            }
            else
                valido = true;

            return valido;
        }

        private void textBoxTempoPreparo_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxFunc.FormataTempoPreparo(sender,e , textBoxTempoPreparo.Text);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void listViewGastos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFunc.ExisteLinhaSelecionada(listViewGastos))
            {
                btnDeletarLinha.Enabled = true;
                listViewFunc.DesSelecionionaListView(listViewProdutos);
            }
            else
                btnDeletarLinha.Enabled = false;
            
        }
    }
}
