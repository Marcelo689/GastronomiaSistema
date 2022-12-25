using BancoDeDados.Contexto;
using BancoDeDados.Controller.Model;
using System;

namespace BancoDeDados.Views.Telas
{
    public partial class GerenciarClientes : FormBase
    {
        public Cliente clienteSelecionado { get; set; }
        public GerenciarClientes()
        {
            InitializeComponent();
        }

        private void GerenciarClientes_Load(object sender, System.EventArgs e)
        {
            PreencherCamposCliente(null);
            PreencherListCliente();
        }
        private void PreencherCamposCliente(Cliente cliente)
        {
            if(cliente == null)
                Limpar();
            else
            {
                textBoxNomeCliente.Text = cliente.NomeCompleto;
                textBoxCPF.Text         = cliente.CPF;
                textBoxBairro.Text      = cliente.Bairro;
                textBoxCelular.Text     = cliente.Celular;
                textBoxRua.Text         = cliente.Rua;
                textBoxCidade.Text      = cliente.Cidade;
                textBoxComplemento.Text = cliente.Complemento;
                textBoxNumero.Text      = cliente.EnderecoNumero;
                textBoxEmail.Text       = cliente.Email;
                if(cliente.Foto != null)
                   pictureBoxFunc.RetornaImagemParaPictureBox(cliente.Foto, pictureBoxFoto);
            }
        }

        private void Limpar()
        {
            textBoxNomeCliente.Text = "";
            textBoxCPF.Text = "";
            textBoxBairro.Text = "";
            textBoxCelular.Text = "";
            textBoxCidade.Text = "";
            textBoxComplemento.Text = "";
            textBoxEmail.Text = "";
            pictureBoxFoto.Image = null;
            listViewFunc.DesSelecionionaListView(listViemCliente);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(listViewFunc.ExisteLinhaSelecionada(listViemCliente))
            {    //atualizar
                AtualizarCliente();
            }
            else //cadastrar
            {
                CadastrarCliente();
            }

        }

        private void CadastrarCliente()
        {
            var novoCliente = new Cliente();
            novoCliente.NomeCompleto = textBoxNomeCliente.Text;
            novoCliente.CPF          = textBoxCPF.Text;
            novoCliente.Empresa      = _contexto.Login.Empresa;
            novoCliente.EmpresaId    = _contexto.Login.EmpresaId;
            novoCliente.Celular      = textBoxCelular.Text;
            novoCliente.Email        = textBoxEmail.Text;

            novoCliente.EnderecoNumero  = textBoxNumero.Text;
            novoCliente.Bairro          = textBoxBairro.Text;
            novoCliente.Complemento     = textBoxComplemento.Text;
            novoCliente.Cidade          = textBoxCidade.Text;
            novoCliente.Foto            = pictureBoxFunc.ImageToByte(pictureBoxFoto.Image);

            _banco.Cadastrar<Cliente>(novoCliente);
            Limpar();
            PreencherListCliente();
        }

        private void AtualizarCliente()
        {
            clienteSelecionado.NomeCompleto   = textBoxNomeCliente.Text;
            clienteSelecionado.CPF            = textBoxCPF.Text;
            clienteSelecionado.Empresa        = _contexto.Login.Empresa;
            clienteSelecionado.EmpresaId      = _contexto.Login.EmpresaId;
            clienteSelecionado.Celular        = textBoxCelular.Text;
            clienteSelecionado.Email          = textBoxEmail.Text;

            clienteSelecionado.EnderecoNumero = textBoxNumero.Text;
            clienteSelecionado.Bairro         = textBoxBairro.Text;
            clienteSelecionado.Complemento    = textBoxComplemento.Text;
            clienteSelecionado.Cidade         = textBoxCidade.Text;
            clienteSelecionado.Foto           = pictureBoxFunc.ImageToByte(pictureBoxFoto.Image);

            _banco.Atualizar<Cliente>(clienteSelecionado);
            Limpar();
            PreencherListCliente();
        }

        private void PreencherListCliente()
        {
            listViewFunc.PreencheListView<Cliente, Cliente>(listViemCliente,
                "Id", "NomeCompleto", "CPF"
            );
        }

        private void listViemCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewFunc.ExisteLinhaSelecionada(listViemCliente))
            {
                btnDeletar.Enabled = true;
                clienteSelecionado = listViewFunc.RetornaItemLinhaSelecionada<Cliente>(listViemCliente);
                if(clienteSelecionado != null)  
                    PreencherCamposCliente(clienteSelecionado);
            }
            else
            {
                btnDeletar.Enabled = false;
                clienteSelecionado = null;
                Limpar();
            }
        }

        private void btnAnexarFoto_Click(object sender, EventArgs e)
        {
              pictureBoxFunc.PreenchePictureBox(pictureBoxFoto);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if(clienteSelecionado != null && listViewFunc.ConfirmaDeletarItemDoList(listViemCliente))
            {
                _banco.Deletar<Cliente>(clienteSelecionado);
                Limpar();
                PreencherListCliente();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
