using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaixaPersonalizavel.Application.Connection;

namespace CaixaPersonalizavel
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //StartProcedures();
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new frmLogin());
            //Database.MySqlConnection().Open();
        }

        private static void StartProcedures()
        {
            
        }
    }
}
