using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Contexto
{
    public class Usuario : TEntity
    {
        public enum NivelAcesso
        {
            Administrador = 1,
            Operador = 2
        }

        public override int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public NivelAcesso Acesso { get; set; }
        public byte[] Imagem { get; set; }  

    }

    
}