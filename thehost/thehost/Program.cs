using System;
using System.Windows.Forms;
using thehost.Formularios;

namespace thehost
{
    static class Program
    {
        /// <summary>
        /// Inicialização do programa.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
    }
}
