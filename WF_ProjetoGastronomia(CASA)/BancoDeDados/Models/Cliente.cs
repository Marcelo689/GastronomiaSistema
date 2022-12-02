using BancoDeDados.Contexto.ClassesRelacionadas;
using System.Collections.Generic;
using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Contexto
{
    public class Cliente : TEntity
    {
        public int Id { get; set; }
        public long CPF { get; set; }
        public byte[] Foto { get; set; }
        public string NomeCompleto { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string EnderecoNumero { get; set; }
        public string Complemento { get; set; }
        public string Email { get; set; }
        public long Celular { get; set; }
        public List<PedidoConcluido> PedidosConcluidos { get; set; }
        public List<PedidoPendente> PedidosPendentes { get; set; }
    }
}