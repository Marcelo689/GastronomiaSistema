using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados.Models
{
    public class UsuarioLogin
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
    }
}
