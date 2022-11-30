﻿namespace BancoDeDados.Contexto
{
    public class Produto
    {
        //Campo para nome, tipo de unidade, preço, Id, OrcamentoId, idReceita

        public enum TipoUnidade
        {
            Unidade = 0,
            Quilograma = 1,
            Grama = 2,
            Litro = 3,

        }
        public int Id { get; set; } 
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public TipoUnidade ProdutoTipoUnidade { get; set; }
        public int QuantidadeUnidade { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido{ get; set; } = null;
        public int ReceitaId { get; set; }
        public Receita Receita { get; set; } = null;

    }
}