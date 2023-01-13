using BancoDeDados.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Models
{
    public class ReceitaDto : TEntity
    {
        public override int Id { get; set; }
        public string NomeReceita { get; set; }
        public double PerdaPorReceita { get; set; }
        public int ProdutoId { get; set; }
        public List<Produto> Produto { get; set; }
        public int QuantidadeProduto { get; set; }
        // hh:mm:ss
        [NotMapped]
        public decimal QuantidadeReceita { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal ValorLuz { get; set; }
        public string TempoDePreparo { get; set; }
        public decimal PotenciaKwh { get; set; }
        public decimal PrecoVenda { get; set; }
        public TipoReceita TipoReceita { get; set; }
        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }
        public decimal Lucro
        {
            get
            {
                return PrecoVenda - (PrecoCusto + ValorLuz);
            }
            set { }
        }
    }
}
