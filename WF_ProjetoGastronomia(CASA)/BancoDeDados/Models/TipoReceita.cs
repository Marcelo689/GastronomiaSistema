using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Models
{
    public class TipoReceita : TEntity
    {
        public override int Id { get; set; }
        public string Descricao { get; set; }
    }
}
