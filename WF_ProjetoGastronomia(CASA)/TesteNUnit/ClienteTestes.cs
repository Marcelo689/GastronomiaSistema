using BancoDeDados.Contexto;

namespace TesteNUnit
{
    public class ClienteTestes 
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void ClienteIsValido()
        {
            var cliente = new Cliente()
            {
                Bairro = "",
                Celular = "a",
                Cidade = "",
                Complemento = "",
                CPF = "a",
                Email = "",
                EnderecoNumero = "",
                NomeCompleto = "a",
                Rua = ""
            };

            var valido = cliente.IsValido();

            Assert.IsTrue(valido);  

        }

        
    }
}