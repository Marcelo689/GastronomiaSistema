using BancoDeDados.Models;
using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Servicos.ListVIewMetodos
{
    public class ProdutoListView : TEntity
    {
        public virtual string Nome { get; set; }
        public virtual decimal Preco { get; set; }
        public virtual UnidadeMedida UnidadeMedida { get; set; }
    }


}
