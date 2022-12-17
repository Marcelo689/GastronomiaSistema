using BancoDeDados.Contexto;
using BancoDeDados.Servicos.ComboBoxMetodos;
using System.ComponentModel.DataAnnotations.Schema;
using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Controller.Telas
{
    public class Gasto : TEntity
    {
        //public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }

        [NotMapped]
        public string QuantidadeGasto { get; set; }
        [NotMapped]
        public string TotalGasto { get; set; }
    }

    public class GastoComboBox : ComboBoxFunc
    {
        //public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }
    }

}