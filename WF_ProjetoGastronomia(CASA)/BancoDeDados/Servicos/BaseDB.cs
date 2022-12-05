using BancoDeDados.Contexto;
using BancoDeDados.Controller;

namespace BancoDeDados.Servicos
{
    public class BaseServico
    {
        protected BDContexto _contexto;
        protected OperacoesBanco _banco;
        public BaseServico()
        {
            if(_contexto == null)
                _contexto = new BDContexto().getInstancia();
            if (_banco == null)
                _banco = new OperacoesBanco();
        }
    }
}