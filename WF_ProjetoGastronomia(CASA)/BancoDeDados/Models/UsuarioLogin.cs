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
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public NivelAcesso PermissaoAcesso { get; set; }
        public bool ManterLogin { get; set; }
        public bool UsuarioAtivo { get; set; }
        public byte[] Imagem { get; set; }
        public static bool ValidaUsuario(BDContexto contexto, string usuario, string senha)
        {
            var entidade = contexto.Usuarios.Where(e => e.Nome == usuario);
            var existe = entidade.Count() > 0;

            var ativo = entidade.FirstOrDefault().UsuarioAtivo;
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
            else if (ativo)
            {
                MessageBox.Show("Usuário inativo, peça a um administrador ativá-lo");
            }

            return true;
        }
    }
}
