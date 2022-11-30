using BancoDeDados.Contexto;
using BancoDeDados.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BancoDeDados
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            var contexto = new BDContexto().getInstancia();
            var usuario = textBoxUser.Text.ToString();
            var senha = mTextBoxSenha.Text.ToString();

            var valido = UsuarioLogin.ValidaUsuario(contexto, usuario, senha);
            if (valido == false)
                return;
            UsuarioLogin.NivelAcesso acesso = UsuarioLogin.NivelAcesso.Operador;
            if (checkBoxIsAdministrador.Checked)
                acesso = UsuarioLogin.NivelAcesso.Administrador;
            var login = new UsuarioLogin()
            {
                Nome = usuario,
                Senha = senha,
                Acesso = acesso
            };

            contexto.Usuarios.Add(login);
            var retorno = contexto.SaveChanges();
            if (retorno > 0)
                MessageBox.Show("Usuário salvo com sucesso!");
        }

        private void checkBoxIsAdministrador_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
