﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados.Contexto.ClassesRelacionadas
{
    public class ReceitaDoPedido
    {
        public int Id { get; set; }
        public Receita ReceitaId { get; set; }
        public Pedido PedidoId { get; set; }

    }
}
