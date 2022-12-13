using BancoDeDados.Models;
using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Servicos.ListVIewMetodos
{
    public class ProdutoListView : TEntity
    {
        //public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual decimal Preco { get; set; }
        public virtual string UnidadeMedida { get; set; }
    }

}
