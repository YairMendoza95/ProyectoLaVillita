using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaVillita.COMMON.Entidades
{
    public class VentaDTO : BaseDTO
    {
        public int idVenta { get; set; }
		public int idUsuario { get; set; }
		public int idTipoUsuario { get; set; }
		public string fechaVenta { get; set; }
        public double total { get; set; }
        public string notas { get; set; }
    }
}
