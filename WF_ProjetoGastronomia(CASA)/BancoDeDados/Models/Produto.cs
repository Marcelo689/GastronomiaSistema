using BancoDeDados.Models;
using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Contexto
{
    public class Produto : TEntity
    {
        //Campo para nome, tipo de unidade, preço, Id, OrcamentoId, idReceita

        //public enum TipoUnidade
        //{
        //    Unidade = 0,
        //    Quilograma = 1,
        //    Grama = 2,
        //    Litro = 3,
        //}
        public int Id { get; set; } 
        public string Nome { get; set; }
        public decimal PrecoPorQuantidade { get; set; }
        //public TipoUnidade ProdutoTipoUnidade { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
    }
}