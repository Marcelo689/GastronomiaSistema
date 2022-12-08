using BancoDeDados.Models;
using BancoDeDados.Servicos.ComboBoxMetodos;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Servicos
{
    public class Servico : BaseServico
    {
        public Servico()
        {

        }
        private List<T> RetornaTodosComponentesDoForm<T>(Control control,Type type) where T : Control
        {
            //EXAMPLE HOW TO USE
            //     var c = RetornaTodosComponentesDoForm(this,typeof(TextBox));
            var controls = control.Controls.Cast<Control>();
            
            var lista =  controls.Where(c => c.GetType() == type).ToList();
            var listaConvertidaControl = lista as List<T>;
            return listaConvertidaControl;
        }

        public void LimparTodosComponentesDoForm(Form form)
        {
            List<TextBox>  textBoxes = RetornaTodosComponentesDoForm<TextBox>(form, typeof(TextBox));
            List<MaskedTextBox>  MtextBoxes = RetornaTodosComponentesDoForm<MaskedTextBox>(form, typeof(MaskedTextBox));
            List<ComboBox> comboBoxes = RetornaTodosComponentesDoForm<ComboBox>(form, typeof(ComboBox));
            List<ListView> listViews = RetornaTodosComponentesDoForm<ListView>(form, typeof(ListView));
            
            if(comboBoxes != null)
            foreach (var item in comboBoxes)
            {
                item.SelectedIndex = -1;    
            }

            if(listViews != null)
            foreach (var item in listViews)
            {
                item.SelectedItems.Clear();
            }
            if(textBoxes != null)
            foreach (var item in textBoxes)
            {
                item.Text = "";
            }
            if(MtextBoxes != null)
            foreach (var item in MtextBoxes)
            {
                item.Text = "";
            }
        }

        public string FormataValor(decimal valor)
        {
            return valor.ToString("F2", CultureInfo.InvariantCulture);
        }   
        public decimal FormataDinheiro(string valor)
        {
            var preco = 0m;
            decimal.TryParse(valor, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out preco);
            return preco;
        }
        public bool ExisteAdministrador()
        {
            var qtdAdmin = _contexto.Usuarios.AsQueryable().Where(u => u.PermissaoAcesso == UsuarioLogin.NivelAcesso.Administrador && u.UsuarioAtivo).Count();
            return qtdAdmin > 0;
        }
        // form
        public void AbrirTela(Form tela,bool apenasAdmin = false)
        {
            bool isAdmin = _contexto.UsuarioLogadoIsAdmin();
            if ((isAdmin && apenasAdmin) || !apenasAdmin)
                tela.ShowDialog();
            else
                MessageBox.Show("Existe um Administrador, peça permissão á ele para abrir está tela!");

        }
        
        
    }
}
