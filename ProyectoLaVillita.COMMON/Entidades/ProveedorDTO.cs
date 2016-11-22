using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaVillita.COMMON.Entidades
{
    public class ProveedorDTO : BaseDTO
    {
        public int idProveedor { get; set; }
        public string nombreProveedor { get; set; }
        public string telefono { get; set; }
    }
}
