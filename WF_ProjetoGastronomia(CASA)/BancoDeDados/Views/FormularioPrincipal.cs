using BancoDeDados.Contexto;
using BancoDeDados.Controller;
using BancoDeDados.Controller.Model;
using BancoDeDados.Controller.Telas;
using BancoDeDados.Models;
using BancoDeDados.Servicos;
using BancoDeDados.Views.Telas;
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
    public partial class FormularioPrincipal : FormBase
    {
        public FormularioPrincipal() : base()
        {
            InitializeComponent();
        }

        private void menuItemCadastrarUsuario_Click(object sender, EventArgs e)
        {
            if (
                 _contexto.ExisteAdmin() && 
                !(_contexto.UsuarioLogadoIsAdmin())
                )
            {
                MessageBox.Show("Existe um Administrador, peça permissão á ele para abrir está tela!");
                return;
            }
            _servico.AbrirTela(new CadastroUsuario());
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

        private void gerenciarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _servico.AbrirTela(new GerenciarProdutos());
        }

        private void gerenciarUnidadesDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _servico.AbrirTela(new GerenciarUnidadeMedida());
        }

        private void gerenciarReceitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _servico.AbrirTela(new GerenciarReceitas());
        }

        private void tipoReceitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _servico.AbrirTela(new GerenciarTipoReceita());
        }

        private void gerenciarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _servico.AbrirTela(new GerenciarEmpresas());
        }

        private void gerenciarGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _servico.AbrirTela(new GerenciarGastos());
        }
    }
}
