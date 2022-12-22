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
        public Receita _receitaSelecionada;
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
            if (_receitaSelecionada != null)
            {
                var produtoSelecionado = comboBoxFunc.RetornaItemComboSelecionado<Produto>(comboBoxProdutos);
                var quantidade         = _servico.FormataDinheiro(textBoxQuantidadeProduto.Text);
                
                if (produtoSelecionado.Id > 0)
                {
                    var ProdutoReceitaList = _banco.RetornarLista<ProdutoReceita>().Where(
                        pr => pr.ProdutoId == produtoSelecionado.Id && pr.ReceitaId == _receitaSelecionada.Id
                    );

                    var existeProdutoReceitaList = ProdutoReceitaList.Any();

                    if (existeProdutoReceitaList)
                    {
                        var produtoReceitaAtualizar = ProdutoReceitaList.First();
                        if(produtoReceitaAtualizar.QuantidadeProduto != quantidade)
                        {
                            produtoReceitaAtualizar.QuantidadeProduto = quantidade;
                            _banco.Atualizar<ProdutoReceita>(produtoReceitaAtualizar);

                            PreencheListViewsDaReceita(_receitaSelecionada.Id);
                            PreencheListReceita();
                        }
                    }
                    else
                    {
                        var produtoReceita = new ProdutoReceita()
                        {
                            Produto = produtoSelecionado,
                            ProdutoId = produtoSelecionado.Id,
                            Receita = _receitaSelecionada,
                            ReceitaId = _receitaSelecionada.Id,
                            QuantidadeProduto = quantidade
                        };
                        _banco.Cadastrar<ProdutoReceita>(produtoReceita);
                        PreencheListViewsDaReceita(_receitaSelecionada.Id);
                        PreencheListReceita();
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
            textBoxTempoPreparo.Text = "";
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
           if(_receitaSelecionada != null && listViewFunc.ConfirmaDeletarItemDoList(listViewReceitas))
            {
                _banco.Deletar<Receita>(_receitaSelecionada);
                Limpar();
                _receitaSelecionada = null;
                PreencheListReceita();
            }
        }

        private void btnDeletarLinha_Click(object sender, System.EventArgs e)
        {

            //deletar click funciona como esperado mas adicionar subitems nao
            if (listViewFunc.ExisteLinhaSelecionada(listViewProdutos))
                if (listViewFunc.ExisteLinhaSelecionada(listViewProdutos) &&
                    listViewFunc.ConfirmaDeletarItemDoList(listViewProdutos) &&
                    _receitaSelecionada != null
                ) 
            {//PRODUTOS
                var produtoSelecionado = listViewFunc.RetornaItemLinhaSelecionada<Produto>(listViewProdutos);
                var produtoReceitaSelecionado = _contexto.ProdutosReceita.Where(pr => pr.ReceitaId == _receitaSelecionada.Id && pr.ProdutoId == produtoSelecionado.Id);

                if (produtoReceitaSelecionado.Any())
                {
                    _banco.Deletar<ProdutoReceita>(produtoReceitaSelecionado.First().Id);
                    PreencheListViewsDaReceita(_receitaSelecionada.Id);
                    PreencheListReceita();
                }
            }


            if (listViewFunc.ExisteLinhaSelecionada(listViewGastos))
                if (listViewFunc.ExisteLinhaSelecionada(listViewGastos) &&
                    listViewFunc.ConfirmaDeletarItemDoList(listViewGastos)
                    )
                {// Gastos
                    var gastoSelecionado = listViewFunc.RetornaItemLinhaSelecionada<Gasto>(listViewGastos);
                
                    if(_receitaSelecionada != null && gastoSelecionado != null)
                    {
                        var gastoReceitaSelecionado = _contexto.GastosReceita.Where(pr => pr.ReceitaId == _receitaSelecionada.Id && pr.GastoId == gastoSelecionado.Id);

                        if (_receitaSelecionada != null)
                        {
                            var gasto = gastoReceitaSelecionado.First();
                            _banco.Deletar<GastoReceita>(gasto.Id);
                            PreencheListViewsDaReceita(_receitaSelecionada.Id);
                            PreencheListReceita();
                        }
                    }
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
            labelCustoLuz.Text = "";

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
            _receitaSelecionada = listViewFunc.RetornaItemLinhaSelecionada<Receita>(listViewReceitas);
            if (_receitaSelecionada != null)
            {
                PreencheListViewsDaReceita(_receitaSelecionada.Id);
                PreencheCamposReceita(_receitaSelecionada);
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
            labelCustoLuz.Text = _servico.FormataValor(receita.ValorLuz);
            textBoxTempoPreparo.Text = receita.TempoDePreparo;  
            comboBoxTipoReceita.SelectedIndex = comboBoxTipoReceita.FindStringExact( receita.TipoReceita.Descricao);
            labelCustoLuz.Text = _servico.FormataValor(receita.ValorLuz);
            PreencheTotal();
        }

        private void PreencheListViewsDaReceita(int id)
        {
            // Atualizar listas correntamente, atualmente não faz muito sentido
            PreencheListProdutos(id);
            PreencheListGastos(id);
            PreencheTotal();
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

            if(_receitaSelecionada != null)
            {
                _receitaSelecionada.PrecoCusto = total;
                _banco.Atualizar<Receita>(_receitaSelecionada);
            }
            total += _servico.FormataDinheiro(labelCustoLuz.Text);
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

        private bool ValidarAdicionarGasto(Gasto gastoSelecionado)
        {
            if (_receitaSelecionada != null)
            {
                if (gastoSelecionado.Id > 0)
                {
                    var GastoNaReceita = _banco.RetornarLista<GastoReceita>().Where(gr => gr.ReceitaId == _receitaSelecionada.Id && gr.GastoId == gastoSelecionado.Id);

                    if (GastoNaReceita.Any() && GastoNaReceita.First().GastoId == gastoSelecionado.Id)
                        MessageBox.Show("O item selecionado já foi adicionado!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        return true;
                }
            }
            else
                MessageBox.Show("Primeiro Selecione a receita que deseja adicionar");
            return false;
        }
        /// Adicionar gasto
        private void btnAdicionarGasto_Click(object sender, System.EventArgs e)
        {
            var gastoSelecionado = comboBoxFunc.RetornaItemComboSelecionado<Gasto>(comboBoxGastos);

            if (ValidarAdicionarGasto(gastoSelecionado))
            {
                AdicionarGastoReceita(gastoSelecionado);
            }
        }

        private void AdicionarGastoReceita(Gasto gastoSelecionado)
        {
            var gastoReceita = new GastoReceita()
            {
                Gasto = gastoSelecionado,
                GastoId = gastoSelecionado.Id,
                Receita = _receitaSelecionada,
                ReceitaId = _receitaSelecionada.Id,
            };
            _banco.Cadastrar<GastoReceita>(gastoReceita);
            PreencheListViewsDaReceita(_receitaSelecionada.Id);
            PreencheListReceita();
        }

        private decimal HorasDeConsumo(string tempoDePreparo)
        {
            var tempoPreparo = DateTime.Parse(tempoDePreparo).TimeOfDay.TotalHours;
            var horasConsumo = _servico.FormataDinheiro(tempoPreparo.ToString("F2", CultureInfo.InvariantCulture));
            return horasConsumo;    
        }
        private void btnCadastrar_Click(object sender, System.EventArgs e)
        {
            var nomeReceita = textBoxNomeReceita.Text;
            var precoVenda  = textBoxPrecoReceita.Text;
            var tipoReceita = comboBoxFunc.RetornaItemComboSelecionado<TipoReceita>(comboBoxTipoReceita);

            // proximo passo calcular valor da luz
            var potenciaKwh =  _servico.FormataDinheiro(textBoxPotenciaKwh.Text);
            var horasConsumo = HorasDeConsumo(textBoxTempoPreparo.Text);
            var consumoEletrico = (potenciaKwh/ 1000.0m) * horasConsumo;
            var custoPorKlw = _contexto.Login.Empresa.CustoKwh;
            var custoLuz = consumoEletrico * custoPorKlw;
            
            if (!ValidaReceita(nomeReceita, tipoReceita))
                return;
            if(_receitaSelecionada != null)
            {
                _receitaSelecionada.PotenciaKwh = potenciaKwh;
                _receitaSelecionada.TempoDePreparo = textBoxTempoPreparo.Text;
                _receitaSelecionada.ValorLuz       = custoLuz;

                _receitaSelecionada.TipoReceita    = tipoReceita;
                _receitaSelecionada.Empresa        = _contexto.Login.Empresa;
                _receitaSelecionada.EmpresaId      = _contexto.Login.EmpresaId;
                _receitaSelecionada.PrecoVenda     = _servico.FormataDinheiro(precoVenda);
                _banco.Atualizar<Receita>(_receitaSelecionada);
                PreencheListViewsDaReceita(_receitaSelecionada.Id);
                Limpar();
            }
            else
            {
                var receita = new Receita()
                {
                    NomeReceita = nomeReceita,
                    PrecoVenda  = _servico.FormataDinheiro(precoVenda),
                    ValorLuz = custoLuz,
                    PotenciaKwh = potenciaKwh,
                    TempoDePreparo = textBoxTempoPreparo.Text,
                    TipoReceita = tipoReceita,
                    Empresa     = _contexto.Login.Empresa,
                    EmpresaId   = _contexto.Login.EmpresaId,
                };
                _banco.Cadastrar<Receita>(receita);
                PreencheListReceita();
                Limpar();
            }

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
