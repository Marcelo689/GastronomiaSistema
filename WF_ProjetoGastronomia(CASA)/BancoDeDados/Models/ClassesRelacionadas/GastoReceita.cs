using BancoDeDados.Contexto;
using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Controller.Telas
{
    public class GastoReceita : TEntity
    {
        public GastoReceita()
        {
        }

        public Gasto Gasto { get; set; }
        public int GastoId { get; set; }
        public Receita Receita { get; set; }
        public int ReceitaId { get; set; }
        public decimal QuantidadeGasto { get; set; }
    }

    public class GastoReceitaListView : TEntity
    {
        public int GastoId { get; set; }
        public string Nome { get; set; }
        public decimal QuantidadeGasto { get; set; }
    }

}