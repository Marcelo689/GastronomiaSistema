using AutoMapper;
using BancoDeDados.Contexto;
using BancoDeDados.Controller.Servicos.PictureBoxMetodos;
using BancoDeDados.Models.AutoMapperFolder;
using BancoDeDados.Servicos;
using BancoDeDados.Servicos.ComboBoxMetodos;
using BancoDeDados.Servicos.ListVIewMetodos;
using BancoDeDados.Servicos.TextBoxMetodos;
using System.Windows.Forms;

namespace BancoDeDados.Controller.Model
{
    public class FormBase: Form
    {
        protected BDContexto _contexto { get; set; }
        protected OperacoesBanco _banco { get; set; }
        protected Servico _servico { get; set; }
        protected ListViewFunc listViewFunc { get; set; }
        protected ComboBoxFunc comboBoxFunc { get; set; }
        protected TextBoxFunc textBoxFunc { get; set; }
        protected PictureBoxFunc pictureBoxFunc { get; set; } 
        protected IMapper mapper { get; set; }
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
            if(listViewFunc == null)
                listViewFunc = new ListViewFunc();
            if(comboBoxFunc == null)
                comboBoxFunc = new ComboBoxFunc();
            if(textBoxFunc == null)
                textBoxFunc = new TextBoxFunc();
            if(pictureBoxFunc == null)  
                pictureBoxFunc = new PictureBoxFunc();
            if (mapper == null)
                mapper = new ReceitaConverter().CriarMaps();

        }
    }
}
