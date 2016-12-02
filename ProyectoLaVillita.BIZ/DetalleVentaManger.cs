using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoLaVillita.DAL;
using ProyectoLaVillita.COMMON.Entidades;
using ProyectoLaVillita.COMMON.Interfaces;

namespace ProyectoLaVillita.BIZ
{
    public class DetalleVentaManger : IDetalleVentaManager
    {
        DetalleVentaRepository detalleRepository;
        public DetalleVentaManger()
        {
            detalleRepository = new DetalleVentaRepository();
        }
        public IQueryable<DetalleVentaDTO> DetalleVenta
        {
            get { return detalleRepository.Elementos; }
        }

        public bool EliminarDetalleVenta(DetalleVentaDTO detalle)
        {
            return detalleRepository.Eliminar(detalle);
        }

        public bool InsertarDetalleVenta(DetalleVentaDTO detalle)
        {
            return detalleRepository.Insertar(detalle);
        }

        public bool ModificarDetalleVenta(DetalleVentaDTO detalle)
        {
            return detalleRepository.Modificar(detalle);
        }
    }
}
