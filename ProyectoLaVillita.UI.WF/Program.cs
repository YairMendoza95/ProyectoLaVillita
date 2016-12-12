using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoLaVillita.BIZ;

namespace ProyectoLaVillita.UI.WF
{
    static class Program
    {
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		///
		public static int idTipoUsuario = 0;
		public static int usuario = 0;
		private  static UsuarioManager _userManager = new UsuarioManager();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			if (_userManager.Usuarios.ToList().Count > 0)
			{
				Application.Run(new Inicio());
			}
			else
			{
				Application.Run(new Usuarios.AgregarUsuario());
			}
            
        }
    }
}
