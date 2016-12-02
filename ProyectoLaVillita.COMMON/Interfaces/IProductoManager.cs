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
        IQueryable<ProductoDTO> Nombre { get; }
        ProductoDTO BuscarProductosPorId(int idProducto);
        ProductoDTO BuscarProductoPorNombre(string nombre);
        bool AgregarProducto(ProductoDTO producto);
        bool ModificarProducto(ProductoDTO producto);
        bool EliminarProducto(ProductoDTO producto);
        IEnumerable<ProductoDTO> ProductosDeUnProveedor(int idProveedor);
        IEnumerable<ProductoDTO> ProductosDeUnaVenta(int idVenta);
    }
}
