using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BancoDeDados.Controller.OperacoesBanco;

namespace BancoDeDados.Models
{
    public class UnidadeMedida : TEntity
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

    }
}
