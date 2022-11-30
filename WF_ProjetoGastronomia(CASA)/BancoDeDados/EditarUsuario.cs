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
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            var contexto = new BDContexto().getInstancia();
            textBoxUsuario.Text = contexto.Login.Nome;
            textBoxSenha.Text = contexto.Login.Senha;
        }
    }
}
