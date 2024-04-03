using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var login = new frmLogin();
            login.ShowDialog();
            
            if (login.DialogResult == DialogResult.OK)
            {
                Application.Run(new frmInicial(login.IdUsuario));
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
