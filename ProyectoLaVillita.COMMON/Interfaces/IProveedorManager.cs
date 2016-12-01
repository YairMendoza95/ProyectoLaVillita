using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoLaVillita.COMMON.Entidades;

namespace ProyectoLaVillita.COMMON.Interfaces
{
    public interface IProveedorManager
    {
        List<ProveedorDTO> Proveedores { get; }
        List<ProveedorDTO> Nombre { get; }
        ProveedorDTO BuscarProveedorPorId(int idProveedor);
        ProveedorDTO BuscarProveedorPorNombre(string nombre);
        bool InsertarProveedor(ProveedorDTO proveedor);
        bool ModificarProveedor(ProveedorDTO proveedor);
        bool EliminarProveedor(ProveedorDTO proveedor);
    }
}
