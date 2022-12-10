using BancoDeDados.Servicos.ComboBoxMetodos;

namespace BancoDeDados.Controller.Telas
{
    public class Gasto : ComboBoxFunc
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}