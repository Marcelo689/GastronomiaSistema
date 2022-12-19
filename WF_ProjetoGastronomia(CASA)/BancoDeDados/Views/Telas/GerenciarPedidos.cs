using BancoDeDados.Contexto;
using BancoDeDados.Controller.Model;
using BancoDeDados.Servicos.ListVIewMetodos;
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
        //Criar pedido proximo passo!
        private void btnAdicionarReceita_Click(object sender, EventArgs e)
        {
            
            if (listViewFunc.ExisteLinhaSelecionada(listViewPedidos))
            {

                var pedidoSelecionado = listViewFunc.RetornaItemLinhaSelecionada<Pedido>(listViewPedidos);
                _servico.AbrirTela(new BuscarReceita(listViewReceitas, pedidoSelecionado.Id));

                PreencheReceitasDoPedido(pedidoSelecionado);
            }
            else
            {
                var clienteSelecionado = comboBoxFunc.RetornaItemComboSelecionado<Cliente>(comboBoxCliente);
                var dataEntrega = Convert.ToDateTime(dataParaEntrega.Text);
                var novoPedido = new Pedido()
                {
                    DataCadastroPedido = DateTime.Now,
                    Empresa = _contexto.Login.Empresa,
                    EmpresaId = _contexto.Login.EmpresaId,
                    FoiEntregue = false,
                    DataParaEntrega = dataEntrega,
                    UsuarioLogin = _contexto.Login,
                    UsuarioLoginId = _contexto.Login.Id,
                    Cliente =  clienteSelecionado,
                    
                };

                _banco.Cadastrar<Pedido>(novoPedido);
                PreencherListViewPedidos();
            }
        }

        private void PreencheReceitasDoPedido(Pedido pedidoSelecionado)
        {
            var receitasDoPedido = _banco.RetornaReceitasDoPedido(pedidoSelecionado.Id);
            listViewFunc.PreencheListView<Receita, ReceitaListView>(listViewReceitas,
               receitasDoPedido,
               new string[]
                   {
                            "Id","NomeReceita","PrecoVenda","Lucro"
                   }
            );
        }

        private void PreencherListViewPedidos()
        {
            listViewFunc.PreencheListView<Pedido, Pedido>(listViewPedidos,
                new string[]
                {
                    "Id","ChavePedido","ClienteId","PrecoVenda"
                });
        }

        private void GerenciarPedidos_Load(object sender, EventArgs e)
        {
            PreencherListViewPedidos();
            comboBoxFunc.PreencheComboBox<Cliente>(comboBoxCliente, "NomeCompleto");
        }

        private void listViewPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFunc.ExisteLinhaSelecionada(listViewPedidos))
            {
                var pedidoSelecionado = listViewFunc.RetornaItemLinhaSelecionada<Pedido>(listViewPedidos);
                PreencheReceitasDoPedido(pedidoSelecionado);
            }
        }
    }
}
