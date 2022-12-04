using BancoDeDados.Contexto;
using BancoDeDados.Controller;
using BancoDeDados.Models;
using BancoDeDados.Servicos;
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
    public partial class FormularioPrincipal : Form
    {
        private Servico _servico;
        private BDContexto _contexto;
        private OperacoesBanco _banco;
        public FormularioPrincipal()
        {
            InitializeComponent();
            _servico = new Servico();
            _contexto = new BDContexto().getInstancia();
        }

        private void menuItemCadastrarUsuario_Click(object sender, EventArgs e)
        {
            if (
                 _contexto.ExisteAdmin() && 
                !(UsuarioLogin.NivelAcesso.Administrador == _contexto.Login.PermissaoAcesso)
                )
            {
                MessageBox.Show("Existe um Administrador, peça permissão á ele para abrir está tela!");
                return;
            }
            var telaCadastrarUsuario = new CadastroUsuario();
            telaCadastrarUsuario.ShowDialog();
        }

        private void FormularioPrincipal_Shown(object sender, EventArgs e)
        {
            _servico.AbrirTela(new Login());      
        }

        private void deslogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _contexto.Login = null;
            _servico.AbrirTela(new Login());
        }
    }
}
