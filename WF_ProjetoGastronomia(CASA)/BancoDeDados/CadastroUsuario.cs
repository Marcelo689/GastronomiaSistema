using BancoDeDados.Contexto;
using BancoDeDados.Controller;
using BancoDeDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BancoDeDados
{
    public partial class CadastroUsuario : Form
    {
        private static BDContexto _contexto;
        private static OperacoesBanco _banco;
        public CadastroUsuario()
        {
            InitializeComponent();
            _contexto = new BDContexto().getInstancia();
            if(_banco == null)
            _banco = new OperacoesBanco();
        }
        private bool ValidaECasoNaoExisteCadastraUsuario()
        {
            if (ExisteLinhaSelecionada()) // é um update
                return true;
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
                UsuarioAtivo = ativo
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
            else if(ExisteLinhaSelecionada())
            {
                var usuarioExistente = new UsuarioLogin(); 
                var indice = listView1.SelectedIndices[0];
                int? id = int.Parse(listView1.Items[indice].Tag.ToString());
                usuarioExistente = _banco.RetornarLista<UsuarioLogin>(id).First();
                usuarioExistente.Nome = textBoxUser.Text;
                usuarioExistente.Senha = mTextBoxSenha.Text;
                usuarioExistente.UsuarioAtivo = checkBoxUsuarioAtivo.Checked;
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

            CarregarLista();
        }
        private bool ExisteLinhaSelecionada()
        {
            var linhasSelecionadas = listView1.SelectedItems;

            if (linhasSelecionadas.Count > 0)
                return true;
            return false;
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
        private UsuarioLogin RetornaUsuarioLinhaSelecionada()
        {
            if (!ExisteLinhaSelecionada())
                return null;
            var indice = listView1.SelectedIndices[0];

            int? id =  int.Parse(listView1.Items[indice].Tag.ToString());
            var nome = listView1.Items[indice].Text.ToString();
            var ativo = listView1.Items[indice].SubItems[1].Text.ToString();
            var permissaoAcesso = listView1.Items[indice].SubItems[2].Text.ToString();
            
            var usuario = _banco.RetornarLista<UsuarioLogin>(id).FirstOrDefault();
            PreencheTelaCadastro(usuario.Nome, usuario.Senha, usuario.PermissaoAcesso, usuario.UsuarioAtivo);

            return usuario;
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
            var existeSelecionado = RetornaUsuarioLinhaSelecionada();
            DesabilitaCheckBoxesCasoNecessario();
            if (existeSelecionado != null)
            {
                btnDeletar.Enabled = true;
            }
            else
                btnDeletar.Enabled = false;
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var quer = MessageBox.Show("Tem certeza que deseja deletar o usuário?","Deletar!!!" ,MessageBoxButtons.YesNo );
            if(quer == DialogResult.Yes)
            {
                var usuarioSelecionado = RetornaUsuarioLinhaSelecionada();
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
