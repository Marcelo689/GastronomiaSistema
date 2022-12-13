using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Servicos.ListVIewMetodos
{
    public class ReceitaListView : TEntity
    {
        //public virtual int Id { get; set; }
        public virtual string NomeReceita { get; set; }
        public virtual decimal PrecoCusto { get; set; }
        
    }
}
