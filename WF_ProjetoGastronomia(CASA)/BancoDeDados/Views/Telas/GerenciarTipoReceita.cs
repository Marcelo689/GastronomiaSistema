using BancoDeDados.Controller.Model;
using BancoDeDados.Models;
using System;
using System.Windows.Forms;

namespace BancoDeDados.Controller.Telas
{
    public partial class GerenciarTipoReceita : FormBase
    {
        public GerenciarTipoReceita()
        {
            InitializeComponent();
        }

        private void GerenciarTipoReceita_Load(object sender, EventArgs e)
        {
            PreencherListView();
            btnDeletar.Enabled = false;
        }

        private void PreencherListView()
        {
            listViewFunc.PreencheListView<TipoReceita, TipoReceita>(listViewReceita,
                new string[]
                {
                    "Id",
                    "Descricao"
                }
            );
        }

        private void listViewReceita_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFunc.ExisteLinhaSelecionada(listViewReceita))
            {
                var tipoReceitaSelecionado = listViewFunc.RetornaItemLinhaSelecionada<TipoReceita>(listViewReceita);
                textBoxTipoReceita.Text = tipoReceitaSelecionado.Descricao;
                btnDeletar.Enabled = true; 
            }
            else
            {
                btnDeletar.Enabled = false;
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTipoReceita.Text))
            {
                MessageBox.Show("Preencha o campo tipo receita!");
            }
            else
            if (!listViewFunc.ExisteLinhaSelecionada(listViewReceita))
            {
                var tipoReceita = new TipoReceita()
                {
                    Descricao = textBoxTipoReceita.Text,
                    Empresa = _contexto.Login.Empresa,
                    EmpresaId = _contexto.Login.EmpresaId,  
                };

                _banco.Cadastrar<TipoReceita>(tipoReceita);
                PreencherListView();
            }
            else if (listViewFunc.ExisteLinhaSelecionada(listViewReceita))
            {
                var tipoReceitaSelecionado = listViewFunc.RetornaItemLinhaSelecionada<TipoReceita>(listViewReceita);

                tipoReceitaSelecionado.Empresa   = _contexto.Login.Empresa;
                tipoReceitaSelecionado.EmpresaId = _contexto.Login.EmpresaId; 
                tipoReceitaSelecionado.Descricao = textBoxTipoReceita.Text;
                _banco.Atualizar<TipoReceita>(tipoReceitaSelecionado);
                PreencherListView();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (listViewFunc.ExisteLinhaSelecionada(listViewReceita))
            {
                var tipoReceitaSelecionado = listViewFunc.RetornaItemLinhaSelecionada<TipoReceita>(listViewReceita);

                if (listViewFunc.ConfirmaDeletarItemDoList(listViewReceita))
                {
                    _banco.Deletar<TipoReceita>(tipoReceitaSelecionado);
                    PreencherListView();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBoxTipoReceita.Text = "";
        }
    }
}
