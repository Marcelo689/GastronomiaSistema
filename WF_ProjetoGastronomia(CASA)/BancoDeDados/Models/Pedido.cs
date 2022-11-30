using BancoDeDados.Contexto.ClassesRelacionadas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BancoDeDados.Contexto
{
    public class Pedido
    {
        //id, idReceita, FoiEntrege,Data,Nome destinatario, precoVenda, precoCusto, Lucro.
        public int Id { get; set; }
        public ReceitaDoPedido ReceitasDoPedido { get; set; }
        public bool FoiEntregue { get; set; }
        public DateTime DataParaEntrega { get; set; }
        public DateTime? DataEntregaRealizada { get; set; }

        public Cliente ClienteId { get; set; }
        public decimal PrecoVenda { get; set; }

        //public decimal GetPrecoVenda(BDContexto contexto)
        //{
        //    contexto.Receitas.Where( r => r.)
        //}
    }
}