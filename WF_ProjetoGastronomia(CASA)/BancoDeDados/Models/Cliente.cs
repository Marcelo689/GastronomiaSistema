using BancoDeDados.Contexto.ClassesRelacionadas;
using System.Collections.Generic;
using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Contexto
{
    public class Cliente : TEntity
    {
        public override int Id { get; set; }
        public string CPF { get; set; }
        public byte[] Foto { get; set; }
        public string NomeCompleto { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string EnderecoNumero { get; set; }
        public string Complemento { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public List<PedidoConcluido> PedidosConcluidos { get; set; }
        public List<PedidoPendente> PedidosPendentes { get; set; }
        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }
    }
}