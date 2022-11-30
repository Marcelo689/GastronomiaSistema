using BancoDeDados.Contexto;
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
        public Login()
        {
            InitializeComponent();
        }

        private void menuItemCadastrarUsuario_Click(object sender, EventArgs e)
        {
            var telaCadastrarUsuario = new CadastroUsuario();
            telaCadastrarUsuario.ShowDialog();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            var contexto = new BDContexto().getInstancia();
            var usuario = textBoxUser.Text.ToString();
            var senha = mTextBoxSenha.Text.ToString();
            var retorno = contexto.Usuarios.AsQueryable().Where(u => u.Nome == usuario && u.Senha == senha).FirstOrDefault();

            if (retorno != null)
            {
                contexto.Login = retorno;
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
    }
}
