using BancoDeDados.Contexto.ClassesRelacionadas;
using BancoDeDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Contexto
{
    public class Pedido : TEntity
    {
        //id, idReceita, FoiEntrege,Data,Nome destinatario, precoVenda, precoCusto, Lucro.
        public override int Id { get; set; }
        public int QuantidadeReceita { get; set; }
        public int ReceitaId { get; set; }
        public List<Receita> ReceitasDoPedido { get; set; }
        public bool FoiEntregue { get; set; }
        public DateTime DataParaEntrega { get; set; }
        public DateTime? DataEntregaRealizada { get; set; }
        public DateTime DataCadastroPedido { get; set; }
        public UsuarioLogin UsuarioLogin { get; set; }
        public int UsuarioLoginId{ get; set; }
        public Cliente Cliente{ get; set; }
        public decimal PrecoVenda { get; set; }
        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }

        //public decimal GetPrecoVenda(BDContexto contexto)
        //{
        //    contexto.Receitas.Where( r => r.)
        //}
    }
}