using BancoDeDados.Contexto.ClassesRelacionadas;
using BancoDeDados.Models;
using System.Collections.Generic;
using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Contexto
{
    public class Receita : TEntity
    {
        public string NomeReceita { get; set; }
        public double PerdaPorReceita { get; set; }
        public int ProdutoId { get; set; }
        public List<Produto> Produto { get; set; }
        public int QuantidadeProduto { get; set; }
        // hh:mm:ss
        public string TempoDePreparo { get; set; }
        public decimal PotenciaKwh { get; set; }
        public double PercentualGastoGas { get; set; }  
        public decimal PrecoCusto { get; set; }
        public TipoReceita TipoReceita { get; set; }
        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }
    }

}