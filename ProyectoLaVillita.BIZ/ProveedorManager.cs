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
    public class ProveedorManager : IProveedorManager
    {
        ProveedorRepository proveedorRepository;
        public ProveedorManager()
        {
            proveedorRepository = new ProveedorRepository();
        }

        public IQueryable<ProveedorDTO> Nombre
        {
            get { return proveedorRepository.Nombre; }
        }

        public IQueryable<ProveedorDTO> Proveedores
        {
            get { return proveedorRepository.Elementos; }
        }

        public ProveedorDTO BuscarProveedorPorId(int idProveedor)
        {
            return proveedorRepository.Elementos.FirstOrDefault(p => p.idProveedor == idProveedor);
        }

        public ProveedorDTO BuscarProveedorPorNombre(string nombre)
        {
            return proveedorRepository.Elementos.FirstOrDefault(p => p.nombreProveedor == nombre);
        }

        public bool EliminarProveedor(ProveedorDTO proveedor)
        {
            return proveedorRepository.Eliminar(proveedor);
        }

        public bool InsertarProveedor(ProveedorDTO proveedor)
        {
            return proveedorRepository.Insertar(proveedor);
        }

        public bool ModificarProveedor(ProveedorDTO proveedor)
        {
            return proveedorRepository.Modificar(proveedor);
        }
    }
}
