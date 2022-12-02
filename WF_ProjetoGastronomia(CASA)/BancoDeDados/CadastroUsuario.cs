using BancoDeDados.Contexto;
using BancoDeDados.Controller;
using BancoDeDados.Models;
using System;
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var usuario = textBoxUser.Text.ToString();
            var senha = mTextBoxSenha.Text.ToString();

            var valido = UsuarioLogin.ValidaUsuario(_contexto, usuario, senha);
            if (valido == false)
                return;
            UsuarioLogin.NivelAcesso acesso = UsuarioLogin.NivelAcesso.Operador;
            if (checkBoxIsAdministrador.Checked)
                acesso = UsuarioLogin.NivelAcesso.Administrador;
            var login = new UsuarioLogin()
            {
                Nome = usuario,
                Senha = senha,
                PermissaoAcesso = acesso
            };

            var retorno = _banco.Cadastrar<UsuarioLogin>(login);
            if (retorno)
                MessageBox.Show("Usuário salvo com sucesso!");
            else
                MessageBox.Show("Erro ao salvar!");
        }

        private void checkBoxIsAdministrador_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            if(_contexto.Login)
            btnDeletar.Enabled = false;
        }
    }
}
