using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoLaVillita.COMMON.Entidades;

namespace ProyectoLaVillita.COMMON.Interfaces
{
    public interface IVentaManager
    {
        IQueryable<VentaDTO> Ventas { get; }
        bool InsertarVenta(VentaDTO venta);
        bool ModificarVenta(VentaDTO venta);
        bool EliminarVenta(VentaDTO venta);
    }
}
