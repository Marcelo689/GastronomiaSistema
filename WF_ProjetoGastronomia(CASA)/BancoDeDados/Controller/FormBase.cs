using BancoDeDados.Contexto;
using BancoDeDados.Servicos;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace BancoDeDados.Controller.Model
{
    public class FormBase: Form
    {
        protected BDContexto _contexto { get; set; }
        protected OperacoesBanco _banco { get; set; }
        protected Servico _servico { get; set; }

        public FormBase() 
        {
            bool isInFormsDesignerMode = (System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv");
            if (isInFormsDesignerMode)
                return;// permite enxergar a tela no modo design
            if (_contexto == null)
                _contexto = new BDContexto().getInstancia();
            if (_banco == null)
                _banco = new OperacoesBanco();
            if (_servico == null)
                _servico = new Servico();
            
        }
    }
}
