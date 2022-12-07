using BancoDeDados.Models;
using BancoDeDados.Servicos.ComboBoxMetodos;
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
