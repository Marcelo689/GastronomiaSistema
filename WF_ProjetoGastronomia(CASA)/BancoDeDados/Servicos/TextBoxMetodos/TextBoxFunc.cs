using System.Windows.Forms;

namespace BancoDeDados.Servicos.TextBoxMetodos
{
    // caso precise das classes do banco descomentar linha 6
    public class TextBoxFunc //: BaseServico 
    {
        public string FormataCNPJ(string cnpj)
        {
            return cnpj.Replace("/", "").Replace("-", "").Replace("_", "");
        }
        internal void FormatoTextBoxDinheiro(object sender, KeyPressEventArgs e)
        {
            if (
                    !char.IsControl(e.KeyChar) &&
                    !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.')
                )
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
