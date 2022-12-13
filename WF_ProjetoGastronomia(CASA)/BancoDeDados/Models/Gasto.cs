using BancoDeDados.Contexto;
using BancoDeDados.Servicos.ComboBoxMetodos;
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