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
    }
}