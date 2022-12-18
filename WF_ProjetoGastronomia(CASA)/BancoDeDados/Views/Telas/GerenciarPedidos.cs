using BancoDeDados.Contexto;
using BancoDeDados.Controller.Model;
using BancoDeDados.Views.Buscar;
using System;

namespace BancoDeDados.Views.Telas
{
    public partial class GerenciarPedidos : FormBase
    {
        public GerenciarPedidos()
        {
            InitializeComponent();
        }

        private void btnAdicionarReceita_Click(object sender, EventArgs e)
        {
            if (listViewFunc.ExisteLinhaSelecionada(listViewPedidos))
            {
                var pedidoSelecionado = listViewFunc.RetornaItemLinhaSelecionada<Pedido>(listViewPedidos);
                _servico.AbrirTela(new BuscarReceita(listViewReceitas, pedidoSelecionado.Id));
            }
        }
    }
}
