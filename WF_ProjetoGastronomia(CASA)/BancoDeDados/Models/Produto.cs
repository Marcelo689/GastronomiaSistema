using BancoDeDados.Models;
using BancoDeDados.Servicos.ComboBoxMetodos;
using System.Collections;
using System.Linq;
using System.Text;
using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Contexto
{
    public class Produto : TEntity, IEnumerable
    {
        //Campo para nome, tipo de unidade, preço, Id, OrcamentoId, idReceita

        //public enum TipoUnidade
        //{
        //    Unidade = 0,
        //    Quilograma = 1,
        //    Grama = 2,
        //    Litro = 3,
        //}
        //public int Id { get; set; }
        public string Nome { get; set; }
        public decimal PrecoPorQuantidade { get; set; }
        //public TipoUnidade ProdutoTipoUnidade { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            return this.GetType().GetProperties()
                .Select(info => (info.Name, Value: info.GetValue(this, null) ?? "(null)"))
                .Aggregate(
                    new StringBuilder(),
                    (sb, pair) => sb.AppendLine($"{pair.Name}: {pair.Value}"),
                    sb => sb.ToString());
        }
    }

    public class ProdutoComboBox : ComboBoxFunc, IEnumerable
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


        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            return this.GetType().GetProperties()
                .Select(info => (info.Name, Value: info.GetValue(this, null) ?? "(null)"))
                .Aggregate(
                    new StringBuilder(),
                    (sb, pair) => sb.AppendLine($"{pair.Name}: {pair.Value}"),
                    sb => sb.ToString());
        }
    }
}