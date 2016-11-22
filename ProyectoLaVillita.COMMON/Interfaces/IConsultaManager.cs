using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoLaVillita.COMMON.Entidades;

namespace ProyectoLaVillita.COMMON.Interfaces
{
    public interface IConsultaManager
    {
        IEnumerable<ProductoDTO> ProductosPorTipo(int tipoProducto);
        IEnumerable<RentaDTO> RentasPorPersona(int idCliente);
        IEnumerable<ProductoDTO> ProductosDeUnProveedor(int idProveedor);
        IEnumerable<EntradaDTO> EntradasPorProducto(int idProducto);
        IEnumerable<ProductoDTO> ProductosDeUnaVenta(int idVenta);
    }
}
