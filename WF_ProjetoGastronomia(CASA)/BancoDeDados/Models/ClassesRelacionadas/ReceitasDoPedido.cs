using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Contexto.ClassesRelacionadas
{
    public class ReceitaDoPedido : TEntity
    {
        [Key]
        public override int Id { get; set; }
        public int ReceitaId { get; set; }
        public Receita Receita { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

    }
}
