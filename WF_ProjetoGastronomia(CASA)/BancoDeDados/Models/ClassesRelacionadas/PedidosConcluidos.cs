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
    public class PedidoConcluido : TEntity
    {
        [Key]
        public override int Id { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int QuantidadePedido { get; set; }
        public DateTime? DataConcluido { get; set; }

    }
}
