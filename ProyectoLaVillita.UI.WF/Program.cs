using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLaVillita.UI.WF
{
    static class Program
    {
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		///
		public static int idUsuario = 0;
		public static string nombreUsuario = "";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio());
        }
    }
}
