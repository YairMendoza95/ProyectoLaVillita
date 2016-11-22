using System;
using System.Collections.Generic;
using ProyectoLaVillita.COMMON.Entidades;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaVillita.COMMON.Interfaces
{
    public interface IProductoManager
    {
        IQueryable<ProductoDTO> Productos { get; }
        ProductoDTO BuscarProductosPorId(int idProducto);
        bool AgregarProducto(ProductoDTO producto);
        bool ModificarProducto(ProductoDTO producto);
        bool EliminarProducto(ProductoDTO producto);
        IEnumerable<ProductoDTO> ProductosDeUnProveedor(int idProveedor);
        IEnumerable<ProductoDTO> ProductosPorTipo(int idTipoProducto);
        IEnumerable<ProductoDTO> ProductosDeUnaVenta(int idVenta);
    }
}
