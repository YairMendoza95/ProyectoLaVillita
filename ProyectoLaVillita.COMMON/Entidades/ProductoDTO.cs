using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaVillita.COMMON.Entidades
{
    public class ProductoDTO : BaseDTO
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public int idProveedor { get; set; }
        public double precioUnitario { get; set; }
        public int stockMax { get; set; }
        public int stockMin { get; set; }
        public int stockActual { get; set; }
        public int idTipoProducto { get; set; }
    }
}
