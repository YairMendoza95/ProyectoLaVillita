using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaVillita.COMMON.Entidades
{
    public class RentaDTO : BaseDTO
    {
        public int idRenta { get; set; }
        public int idCliente { get; set; }
		public string fechaInicio { get; set; }
		public string fechaVencimiento { get; set; }
        public double total { get; set; }
        public string notas { get; set; }
	}
}
