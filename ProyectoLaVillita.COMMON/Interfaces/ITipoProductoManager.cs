using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoLaVillita.COMMON.Entidades;

namespace ProyectoLaVillita.COMMON.Interfaces
{
    public interface ITipoProductoManager
    {
        IQueryable<TipoProductoDTO> TiposDeProductos { get; }
        bool InsertarTipoDeProducto(TipoProductoDTO tipo);
        bool ModificarTipoDeProducto(TipoProductoDTO tipo);
        bool EliminarTipoDeProducto(TipoProductoDTO tipo);
        IEnumerable<ProductoDTO> ProductosPorTipo(int tipoProducto);
    }
}
