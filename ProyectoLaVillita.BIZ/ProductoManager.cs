using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoLaVillita.COMMON.Entidades;
using ProyectoLaVillita.COMMON.Interfaces;
using ProyectoLaVillita.DAL;

namespace ProyectoLaVillita.BIZ
{
    public class ProductoManager : IProductoManager
    {
        ProductoRepository productoRepository;
        ConsultaRepository consultaRepository;

        public List<ProductoDTO> Productos
        {
            get { return productoRepository.Elementos; }
        }

        public List<ProductoDTO> Nombre
        {
            get { return productoRepository.Nombre; }
        }

        public ProductoManager()
        {
            productoRepository = new ProductoRepository();
            consultaRepository = new ConsultaRepository();
        }

        public ProductoDTO BuscarProductosPorId(int idProducto)
        {
            return productoRepository.Elementos.FirstOrDefault(p => p.idProducto == idProducto);
        }

        public bool AgregarProducto(ProductoDTO producto)
        {
            return productoRepository.Insertar(producto);
        }

        public bool ModificarProducto(ProductoDTO producto)
        {
            return productoRepository.Modificar(producto);
        }

        public bool EliminarProducto(ProductoDTO producto)
        {
            return productoRepository.Eliminar(producto);
        }

        public IEnumerable<ProductoDTO> ProductosDeUnProveedor(int idProveedor)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductoDTO> ProductosDeUnaVenta(int idVenta)
        {
            throw new NotImplementedException();
        }

        public ProductoDTO BuscarProductoPorNombre(string nombre)
        {
            return productoRepository.Elementos.FirstOrDefault(p => p.nombre == nombre);
        }
    }
}
