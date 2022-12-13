using BancoDeDados.Contexto;
using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Models
{
    public class TipoReceita : TEntity
    {
        public override int Id { get; set; }
        public string Descricao { get; set; }
        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }
    }
}
