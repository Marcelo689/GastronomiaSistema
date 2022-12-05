using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace BancoDeDados
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var service = new ServiceCollection();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormularioPrincipal());
        }
        


    }
}
