using BancoDeDados.Contexto.ClassesRelacionadas;
using BancoDeDados.Models;
using System.Collections.Generic;
using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Contexto
{
    public class Receita : TEntity
    {
        //Perda por receita, Quantidade de produtos por receita, tempo de preparo, potencia em kl wats, percentual de gasto em gás, Preço de custo, tipo de receita(doce ou salgado).

        //public enum TipoReceita
        //{
        //    Doce = 0,
        //    Salgado = 1
        //}

        //public int Id { get; set; }
        public string NomeReceita { get; set; }
        public double PerdaPorReceita { get; set; }
        public int ProdutoId { get; set; }
        public List<Produto> Produto { get; set; }
        public int QuantidadeProduto { get; set; }
        // hh:mm:ss
        public string TempoDePreparo { get; set; }
        public int PotenciaKwh { get; set; }
        public double PercentualGastoGas { get; set; }  
        public decimal PrecoCusto { get; set; }
        public TipoReceita TipoReceita { get; set; }
        //public TipoReceita CategoriaTipoReceita { get; set; }
    }


}