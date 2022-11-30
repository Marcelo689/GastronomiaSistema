using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados.Contexto
{
    public class Contexto : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connectionString = "server=localhost;uid=root;pwd=root;database=Gastronomia";
            optionsBuilder.UseMySql(connectionString);
        }
    }
}
