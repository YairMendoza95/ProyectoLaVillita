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
    public class VentaManager : IVentaManager
    {
        VentaRepository ventaRepository;
        ConsultaRepository consultaRepository;

        public List<VentaDTO> Ventas
        {
            get { return ventaRepository.Elementos; }
        }

        public VentaManager()
        {
            ventaRepository = new VentaRepository();
            consultaRepository = new ConsultaRepository();
        }

        public bool InsertarVenta(VentaDTO venta)
        {
            return ventaRepository.Insertar(venta);
        }

        public bool ModificarVenta(VentaDTO venta)
        {
            return ventaRepository.Modificar(venta);
        }

        public bool EliminarVenta(VentaDTO venta)
        {
            return ventaRepository.Eliminar(venta);
        }
    }
}
