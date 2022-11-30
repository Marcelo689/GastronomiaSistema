using BancoDeDados.Contexto;
using BancoDeDados.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BancoDeDados.Contexto.Usuario;

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

            var existe = contexto.Usuarios.Any(u => u.Nome == usuario);
            if(string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha) )
            {
                MessageBox.Show("Você digitou caracteres inválidos!");
                return;
            }else if (existe)
            {
                MessageBox.Show("Usuário já existe, tente um nome diferente!");
                return;
            }
            UsuarioLogin.NivelAcesso acesso = UsuarioLogin.NivelAcesso.Operador;
            if (checkBoxIsAdministrador.Checked)
                acesso = UsuarioLogin.NivelAcesso.Administrador;
            var login = new UsuarioLogin()
            {
                Nome = usuario,
                Senha = senha,
                Acesso = acesso
            };


            var retorno = contexto.Usuarios.Add(login);
            contexto.SaveChanges();
            if(retorno.Entity.Id > 0)
                MessageBox.Show("Usuário salvo com sucesso!");
        }
    }
}
