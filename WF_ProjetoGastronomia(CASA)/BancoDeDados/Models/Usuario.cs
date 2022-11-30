namespace BancoDeDados.Contexto
{
    public class Usuario
    {
        public enum NivelAcesso
        {
            Administrador = 1,
            Operador = 2
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public NivelAcesso Acesso { get; set; }
        public byte[] Imagem { get; set; }  

    }

    
}