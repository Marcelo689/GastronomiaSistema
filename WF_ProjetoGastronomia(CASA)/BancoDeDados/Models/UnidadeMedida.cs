using BancoDeDados.Contexto;
using BancoDeDados.Servicos.ComboBoxMetodos;

namespace BancoDeDados.Models
{
    public class UnidadeMedida : ComboBoxFunc
    {
        //public int Id { get; set; }
        public override string Descricao { get; set; }
        public override string Sigla { get; set; }
        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }
    }
}
