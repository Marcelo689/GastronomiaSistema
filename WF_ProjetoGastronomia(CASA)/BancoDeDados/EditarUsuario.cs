using BancoDeDados.Contexto;
using BancoDeDados.Models;
using System;
using System.Windows.Forms;
using static BancoDeDados.Login;

namespace BancoDeDados
{
    public partial class EditarUsuario : Form 
    {
        private string usuario = null;
        private string senha = null;
        private BDContexto _contexto = null;
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            _contexto = new BDContexto().getInstancia();

            usuario = _contexto.Login.Nome;
            senha = _contexto.Login.Senha;
            textBoxUsuario.Text = usuario;
            textBoxSenha.Text = senha;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var usuarioTextBox = textBoxUsuario.Text;
            var senhaTextBox = textBoxSenha.Text;
            var isAdmin = checkBoxIsAdministrador.Checked;
            var valido = UsuarioLogin.ValidaUsuario(_contexto, usuarioTextBox, senhaTextBox);
            if (valido == false)
                return;
            var acesso = UsuarioLogin.NivelAcesso.Operador;
            if (isAdmin)
                acesso = UsuarioLogin.NivelAcesso.Administrador;

            _contexto.Login.Nome  =  usuarioTextBox ?? _contexto.Login.Nome;
            _contexto.Login.Senha =  senhaTextBox ?? _contexto.Login.Senha;
            _contexto.Login.Nome  =  usuarioTextBox ?? _contexto.Login.Nome;
            _contexto.Login.Acesso  = acesso;
           
            _contexto.Usuarios.Update(_contexto.Login);
            var retorno = _contexto.SaveChanges();

            if (retorno > 0)
                MessageBox.Show("Usuário Atualizado com sucesso!");
            else
                MessageBox.Show("Falha ao atualizar");
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var usuarioLogado = _contexto.Login;
            if (usuarioLogado.Acesso == UsuarioLogin.NivelAcesso.Administrador)
            {
                _contexto.Usuarios.Remove(_contexto.Login);
                _contexto.SaveChanges();
            }
            else
                MessageBox.Show("Você não tem permissão de Administrador para realizar está ação!");
        }
    }
}
