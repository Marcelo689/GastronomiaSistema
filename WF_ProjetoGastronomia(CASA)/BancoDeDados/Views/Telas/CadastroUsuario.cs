using BancoDeDados.Contexto;
using BancoDeDados.Controller.Model;
using BancoDeDados.Models;
using BancoDeDados.Servicos.ListVIewMetodos;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BancoDeDados
{
    public partial class CadastroUsuario : FormBase
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }
        private bool ValidaECasoNaoExisteCadastraUsuario()
        {
            if (listViewFunc.ExisteLinhaSelecionada(listView1)) // é um update
                return true;

            var empresaSelecionada = comboBoxFunc.RetornaItemComboSelecionado<Empresa>(comboBoxEmpresas);
            var usuario = textBoxUser.Text.ToString();
            var senha = mTextBoxSenha.Text.ToString();
            
            var usuarioJaExiste = _contexto.Usuarios.Where(e => 
                e.Nome == usuario && 
                e.Senha == senha  &&
                e.UsuarioAtivo == checkBoxUsuarioAtivo.Checked &&
                e.PermissaoAcesso == UsuarioLogin.NivelAcesso.Administrador
            ).Any();

            var valido = UsuarioLogin.ValidaUsuario(usuario, senha, usuarioJaExiste);
            if (valido == false)
                return false;
            var acesso = UsuarioLogin.NivelAcesso.Operador;

            if (checkBoxIsAdministrador.Checked)
                acesso = UsuarioLogin.NivelAcesso.Administrador;

            var ativo = false;
            if (checkBoxUsuarioAtivo.Checked)
                ativo = true;

            var login = new UsuarioLogin()
            {
                Nome = usuario,
                Senha = senha,
                PermissaoAcesso = acesso,
                UsuarioAtivo = ativo,
                Empresa = empresaSelecionada,
                EmpresaId = empresaSelecionada.Id
            };

            var retorno  = _banco.Cadastrar<UsuarioLogin>(login);
            CarregarLista();
            LimparTela();
            return retorno;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool retorno = ValidaECasoNaoExisteCadastraUsuario();
            if (retorno == false)
                return;
            else if(listViewFunc.ExisteLinhaSelecionada(listView1))
            {
                var usuarioExistente = new UsuarioLogin(); 
                var indice = listView1.SelectedIndices[0];
                int? id = int.Parse(listView1.Items[indice].Tag.ToString());
                usuarioExistente = _banco.RetornarLista<UsuarioLogin>(id).First();
                usuarioExistente.Nome = textBoxUser.Text;
                usuarioExistente.Senha = mTextBoxSenha.Text;
                usuarioExistente.UsuarioAtivo = checkBoxUsuarioAtivo.Checked;
                usuarioExistente.Empresa = _contexto.Login.Empresa;
                usuarioExistente.EmpresaId = _contexto.Login.EmpresaId;
                usuarioExistente.PermissaoAcesso = checkBoxIsAdministrador.Checked ? UsuarioLogin.NivelAcesso.Administrador : UsuarioLogin.NivelAcesso.Operador;

                var atualizou = _banco.Atualizar<UsuarioLogin>(usuarioExistente);
                if (atualizou)
                {
                    CarregarLista();
                    LimparTela();
                    MessageBox.Show("Usuário salvo com sucesso!");
                }
                else
                    MessageBox.Show("Erro ao salvar!");
            }

            DesabilitaCheckBoxesCasoNecessario();

        }
        private void checkBoxIsAdministrador_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void DesabilitaCheckBoxesCasoNecessario()
        {
            if (!_contexto.UsuarioLogadoIsAdmin())
            {
                btnDeletar.Enabled = false;
                checkBoxIsAdministrador.Enabled = false;
            }
            if (!_contexto.ExisteAdmin())
            {
                checkBoxIsAdministrador.Enabled = true;
            }
        }
        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            DesabilitaCheckBoxesCasoNecessario();
            comboBoxFunc.PreencheComboBox<Empresa>(comboBoxEmpresas, "NomeEmpresa");
            CarregarLista();
        }
        private void PreencheTelaCadastro(string nome, string senha,UsuarioLogin.NivelAcesso acesso,bool ativo)
        {
            textBoxUser.Text = nome;
            mTextBoxSenha.Text = senha;
            if (acesso == UsuarioLogin.NivelAcesso.Administrador)
                checkBoxIsAdministrador.Checked = true;
            else
                checkBoxIsAdministrador.Checked = false;

            if (ativo)
                checkBoxUsuarioAtivo.Checked = true;
            else
                checkBoxUsuarioAtivo.Checked = false;
        }        
        private void CarregarLista()
        {
            var lista = _banco.RetornarLista<UsuarioLogin>();
            listView1.Items.Clear();    
            foreach (var linha in lista)
            {
                var listItem = new ListViewItem(
                        new String[]
                        {
                            linha.Nome,
                            linha.UsuarioAtivo ? "Ativo" : "Inativo",
                            linha.PermissaoAcesso == UsuarioLogin.NivelAcesso.Administrador ?
                            "Administrador" : "Operador"
                        }

                );
                listItem.Tag = linha.Id;
                listView1.Items.Add(listItem);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var existeSelecionado = false;
                
            var usuarioSelecionado  = listViewFunc.RetornaItemLinhaSelecionada<UsuarioLogin>(listView1);
            if (usuarioSelecionado != null)
            {
                existeSelecionado = true;
                PreencheTelaCadastro(usuarioSelecionado.Nome,usuarioSelecionado.Senha,usuarioSelecionado.PermissaoAcesso,usuarioSelecionado.UsuarioAtivo);
            }
            DesabilitaCheckBoxesCasoNecessario();
            if (existeSelecionado)
            {
                btnDeletar.Enabled = true;
            }
            else
                btnDeletar.Enabled = false;
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if(listViewFunc.ConfirmaDeletarItemDoList(listView1))
            {
                var usuarioSelecionado = listViewFunc.RetornaItemLinhaSelecionada<UsuarioLogin>(listView1);
                _banco.Deletar<UsuarioLogin>(usuarioSelecionado);
                CarregarLista();
                LimparTela();
                DesabilitaCheckBoxesCasoNecessario();
            }
        }
        private void LimparTela()
        {
            textBoxUser.Text = "";
            mTextBoxSenha.Text = "";
            checkBoxIsAdministrador.Checked = false;
            checkBoxUsuarioAtivo.Checked = false;
            listView1.SelectedItems.Clear();
            btnDeletar.Enabled = false;
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }
    }
}
