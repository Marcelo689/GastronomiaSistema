using BancoDeDados.Contexto.ClassesRelacionadas;

namespace BancoDeDados.Contexto
{
    public class Receita
    {
        //Perda por receita, Quantidade de produtos por receita, tempo de preparo, potencia em kl wats, percentual de gasto em gás, Preço de custo, tipo de receita(doce ou salgado).

        public enum TipoReceita
        {
            Doce = 0,
            Salgado = 1
        }

        public int Id { get; set; }
        public double PerdaPorReceita { get; set; }
        public ProdutoReceita ProdutosReceita { get; set; }
        public int QuantidadeProduto { get; set; }

        // hh:mm:ss
        public string TempoDePreparo { get; set; }

        public int PotenciaKwh { get; set; }
        public double PercentualGastoGas { get; set; }  
        public decimal PrecoCusto { get; set; }

        public TipoReceita CategoriaTipoReceita { get; set; }
    }
}