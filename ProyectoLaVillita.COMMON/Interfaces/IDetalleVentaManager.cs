using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoLaVillita.COMMON.Entidades;

namespace ProyectoLaVillita.COMMON.Interfaces
{
    public interface IDetalleVentaManager
    {
        List<DetalleVentaDTO> DetalleVenta { get; }
        bool InsertarDetalleVenta(DetalleVentaDTO detalle);
        bool ModificarDetalleVenta(DetalleVentaDTO detalle);
        bool EliminarDetalleVenta(DetalleVentaDTO detalle);
    }
}
