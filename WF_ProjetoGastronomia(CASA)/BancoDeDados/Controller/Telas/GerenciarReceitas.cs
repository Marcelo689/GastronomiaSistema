using BancoDeDados.Controller.Model;
using BancoDeDados.Servicos.ComboBoxMetodos;
using BancoDeDados.Servicos.ListVIewMetodos;
using BancoDeDados.Servicos.TextBoxMetodos;
using System.Windows.Forms;

namespace BancoDeDados.Controller.Telas
{
    public partial class GerenciarReceitas : FormBase
    {
        private ListViewFunc listViewFunc = new ListViewFunc();
        private ComboBoxFunc comboBoxFunc = new ComboBoxFunc();
        private TextBoxFunc textBoxFunc = new TextBoxFunc();
        public GerenciarReceitas()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxFunc.FormatoTextBoxDinheiro(sender, e);
        }

        private void btnAdicionarProduto_Click(object sender, System.EventArgs e)
        {
            
        }
    }
}
