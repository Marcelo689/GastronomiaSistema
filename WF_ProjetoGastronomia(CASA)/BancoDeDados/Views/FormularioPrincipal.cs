using BancoDeDados.Controller.Model;
using BancoDeDados.Controller.Telas;
using BancoDeDados.Views.Telas;
using System;
using System.Drawing;
using System.IO;
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
            _servico.AbrirTela(new Login(pictureBoxLogoEmpresa, labelEmpresaNome));      
        }

        private void deslogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _contexto.Login = null;
            _servico.AbrirTela(new Login(pictureBoxLogoEmpresa, labelEmpresaNome));
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

        private void gerenciarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _servico.AbrirTela(new GerenciarPedidos());
        }
        private void RetornaImagemParaPictureBox(byte[] image, PictureBox pictureBox)
        {
            int ArraySize = image.GetUpperBound(0);

            MemoryStream ms = new MemoryStream(image, 0, ArraySize);
            pictureBox.Image = Image.FromStream(ms);
        }
        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void FormularioPrincipal_Activated(object sender, EventArgs e)
        {
            if (_contexto.Login != null)
            {
                RetornaImagemParaPictureBox(_contexto.Login.Empresa.Logo, pictureBoxLogoEmpresa);
                labelEmpresaNome.Text = _contexto.Login.Empresa.NomeEmpresa;
            }
        }

        private void gerenciarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _servico.AbrirTela(new GerenciarClientes());
        }
    }
}
