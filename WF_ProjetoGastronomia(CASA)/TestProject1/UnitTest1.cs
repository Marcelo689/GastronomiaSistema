using AutoMapper;
using BancoDeDados.Contexto;
using BancoDeDados.Models;
using TestProject1.AutoMapperFolder;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Receita, ReceitaDto>();
            });
            IMapper mapper = config.CreateMapper();
            var receita    = new Receita();
            var receitaDto = new ReceitaDto();
            
            var receitaDtoSaida = mapper.Map<Receita, ReceitaDto>(receita);
            Console.WriteLine(receitaDtoSaida);
        }
    }
}