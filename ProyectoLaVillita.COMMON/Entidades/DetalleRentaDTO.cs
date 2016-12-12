using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaVillita.COMMON.Entidades
{
    public class DetalleRentaDTO : BaseDTO
    {
        public int idDetalleRenta { get; set; }
        public int idRenta { get; set; }
        public int idProducto { get; set; }
        public int idProveedor { get; set; }
        public int cantidad { get; set; }
        public double total { get; set; }
    }
}
