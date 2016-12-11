using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaVillita.COMMON.Entidades
{
    public class DetalleVentaDTO : BaseDTO
    {
        public int idDetalleVenta { get; set; }
        public int idVenta { get; set; }
        public int idProducto { get; set; }
        public int idProveedor { get; set; }
        public double cantidad { get; set; }
        public double total { get; set; }
    }
}
