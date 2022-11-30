using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados.Contexto.ClassesRelacionadas
{
    public class PedidoPendente
    {
        public int Id { get; set; }
        public Pedido PedidoId { get; set; }
        public Cliente ClientePedido { get; set; }
        public DateTime? DataParaEntrega { get; set; }
    }
}
