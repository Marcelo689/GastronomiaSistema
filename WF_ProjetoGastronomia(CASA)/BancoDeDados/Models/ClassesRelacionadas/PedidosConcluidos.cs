using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados.Contexto.ClassesRelacionadas
{
    public class PedidoConcluido
    {
        public int Id { get; set; }
        public Pedido PedidoId { get; set; }
        public Cliente ClientePedido { get; set; }
        public DateTime? DataConcluido { get; set; }

    }
}
