using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Contexto.ClassesRelacionadas
{
    public class ProdutoReceita : TEntity
    {
        //[Key]
        //public int Id { get; set; }
        public int ReceitaId { get; set; }
        public Receita Receita { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public decimal QuantidadeProduto { get; set; }
    }
}
