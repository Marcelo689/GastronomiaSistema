using BancoDeDados.Contexto;
using BancoDeDados.Models;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeDados
{
    public partial class Login : Form
    {
        private BDContexto _contexto;
        public Login()
        {
            InitializeComponent();
            _contexto = new BDContexto().getInstancia();
        }

        public bool ExisteAdministrador()
        {
            var qtdAdmin = _contexto.Usuarios.AsQueryable().Where(u => u.Acesso == UsuarioLogin.NivelAcesso.Administrador).Count();
                return qtdAdmin > 0;
            
        }
                                // form
        public void AbrirTela(Form tela , bool isAdmin = false)
        {
            if (!isAdmin)
            {
                MessageBox.Show("Existe um Administrador, peça permissão á ele para abrir está tela!");
                return;
            }
            if (isAdmin)
            {     
                var telaCadastrarUsuario =  tela;
                telaCadastrarUsuario.ShowDialog();
            }
        }
        private void menuItemCadastrarUsuario_Click(object sender, EventArgs e)
        {
            var tela = new EditarUsuario();
            AbrirTela(tela, true);
            if (ExisteAdministrador())
            {
                MessageBox.Show("Existe um Administrador, peça permissão á ele para abrir está tela!");
                return;
            }
            var telaCadastrarUsuario = new CadastroUsuario();
            telaCadastrarUsuario.ShowDialog();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            var usuario = textBoxUser.Text.ToString();
            var senha = mTextBoxSenha.Text.ToString();
            var retorno = _contexto.Usuarios.AsQueryable().Where(u => u.Nome == usuario && u.Senha == senha).FirstOrDefault();

            if (retorno != null)
            {
                if (checkBoxManterLogin.Checked)
                {
                    _contexto.Usuarios.AsQueryable().Where(user => user.ManterLogin).ToList().ForEach(u =>
                    u.ManterLogin = false);
                    retorno.ManterLogin = true;
                }
                _contexto.Login = retorno;
                _contexto.SaveChanges();
                MessageBox.Show("Usuário logado com sucesso!");
                var telaEditarUsuario = new EditarUsuario();

                telaEditarUsuario.Show();
            }
            else
            {
                MessageBox.Show("Erro ao logar!");
            }
        }

        private void mTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void menuItemEditarUsuario_Click(object sender, EventArgs e)
        {
            var telaEditarUsuario = new EditarUsuario();
            telaEditarUsuario.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            _contexto.Login = _contexto.Usuarios.Where(u => u.ManterLogin == true).First();

            textBoxUser.Text   = _contexto.Login.Nome;
            mTextBoxSenha.Text = _contexto.Login.Senha;
            if(_contexto.Login.ManterLogin )
                checkBoxManterLogin.Checked = true;

        }
    }
}
