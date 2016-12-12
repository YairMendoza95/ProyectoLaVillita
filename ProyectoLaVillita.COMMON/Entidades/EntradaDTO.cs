using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaVillita.COMMON.Entidades
{
    public class EntradaDTO : BaseDTO
    {
        public int idEntrada { get; set; }
        public int idProducto { get; set; }
        public int idProveedor { get; set; }
        public DateTime fechaEntrada { get; set; }
        public int cantidad { get; set; }
        public double montoPagar { get; set; }
    }
}
