using BancoDeDados.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Models
{
    public class UsuarioLogin : TEntity
    {
        public enum NivelAcesso
        {
            Administrador = 1,
            Operador = 2
        }
        public override int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public NivelAcesso PermissaoAcesso { get; set; }
        public bool ManterLogin { get; set; }
        public bool UsuarioAtivo { get; set; }
        public byte[] Imagem { get; set; }
        public static bool ValidaUsuario(string usuario, string senha, bool usuarioExiste = false)
        {   
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Você digitou caracteres inválidos!");
                return false;
            }
            else if (usuarioExiste)
            {
                MessageBox.Show("Usuário já existe, tente um nome diferente!");
                return false;
            }

            return true;
        }
    }
}
