namespace BancoDeDados.Contexto
{
    public class Empresa
    {
        //CNPJ obrigatório , tem lugar para logo, e Nome da empresa, endereço, contato(email, celular)
        public int Id { get; set; } 
        public long CNPJ { get; set; }
        public byte[] Logo { get; set; }
        public string NomeEmpresa { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string EnderecoNumero { get; set; }
        public string Complemento { get; set; }
        public string Email { get; set; }
        public long Celular { get; set; }
    }
}