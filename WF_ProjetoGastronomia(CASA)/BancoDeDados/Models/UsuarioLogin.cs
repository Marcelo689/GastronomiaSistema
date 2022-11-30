using BancoDeDados.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public bool ManterLogin { get; set; }
        public static bool ValidaUsuario(BDContexto contexto, string usuario, string senha)
        {
            var existe = contexto.Usuarios.Any(u => u.Nome == usuario);
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Você digitou caracteres inválidos!");
                return false;
            }
            else if (existe)
            {
                MessageBox.Show("Usuário já existe, tente um nome diferente!");
                return false;
            }

            return true;
        }
    }
}
