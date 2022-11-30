using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados.Contexto.ClassesRelacionadas
{
    public class ProdutoReceita
    {
        [Key]
        public int Id { get; set; }
        public int ReceitaId { get; set; }
        public Receita Receita { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
