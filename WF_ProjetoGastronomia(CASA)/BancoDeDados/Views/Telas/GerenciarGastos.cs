using BancoDeDados.Controller.Model;
using BancoDeDados.Controller.Telas;
using System;
using System.Windows.Forms;

namespace BancoDeDados.Views.Telas
{
    public partial class GerenciarGastos :FormBase
    {
        public GerenciarGastos()
        {
            InitializeComponent();
        }

        private void GerenciarGastos_Load(object sender, System.EventArgs e)
        {
            btnDeletar.Enabled = false;
            PreencherListGastos();
        }

        private void PreencherListGastos()
        {
            listViewFunc.PreencheListView<Gasto, Gasto>(listViewGastos,
                   new String[]
                   {
                        "Id","Nome","Valor"
                   }
               );
        }

        private void btnCadastrar_Click(object sender, System.EventArgs e)
        {
            var nomeGasto = textBoxNomeGasto.Text.ToString();
            var valorTexto = textBoxValor.Text.ToString();

            var valor = _servico.FormataDinheiro(valorTexto);


            if (!CamposGastoValido(nomeGasto))
                return;
            if (listViewFunc.ExisteLinhaSelecionada(listViewGastos))
            {//atualiza
                var itemSelecionado = listViewFunc.RetornaItemLinhaSelecionada<Gasto>(listViewGastos);
                itemSelecionado.Nome = nomeGasto;
                itemSelecionado.Valor = valor;
                _banco.Atualizar<Gasto>(itemSelecionado);
                Limpar();
                PreencherListGastos();
            }
            else
            {// cadastro
                var gasto = new Gasto()
                {
                    Nome = nomeGasto,
                    Valor = valor,
                    Empresa = _contexto.Login.Empresa,
                    EmpresaId = _contexto.Login.EmpresaId
                };

                _banco.Cadastrar<Gasto>(gasto);
                Limpar();
                PreencherListGastos();
            }
        }

        private bool CamposGastoValido(params string [] campos)
        {
            foreach (var campo in campos)
            {
                if (string.IsNullOrWhiteSpace(campo))
                {
                    MessageBox.Show("Campo não foi preenchido corretamente", "Preencha os campos!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            return true;
        }

        private void btnLimpar_Click(object sender, System.EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            textBoxNomeGasto.Text = "";
            textBoxValor.Text = "";
            btnDeletar.Enabled = false;
            listViewFunc.DesSelecionionaListView(listViewGastos);
        }

        private void btnDeletar_Click(object sender, System.EventArgs e)
        {
            if (listViewFunc.ConfirmaDeletarItemDoList(listViewGastos))
            {
                var itemSelecionado = listViewFunc.RetornaItemLinhaSelecionada<Gasto>(listViewGastos);
            
                _banco.Deletar<Gasto>(itemSelecionado);
                PreencherListGastos();
            }
        }

        private void listViewGastos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFunc.ExisteLinhaSelecionada(listViewGastos))
            {
                btnDeletar.Enabled = true;
            }
            else
            {
                btnDeletar.Enabled = false;
            }
        }

        private void textBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxFunc.FormatoTextBoxDinheiro(sender,e);
        }
    }
}
