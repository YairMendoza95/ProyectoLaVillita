using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoLaVillita.COMMON.Entidades;

namespace ProyectoLaVillita.COMMON.Interfaces
{
    public interface IRentaManager
    {
        List<RentaDTO> Rentas { get; }
        bool InsertarRenta(RentaDTO renta);
        bool ModificarRenta(RentaDTO renta);
        bool EliminarRenta(RentaDTO renta);
        IEnumerable<RentaDTO> RentasPorPersona(int idCliente);
    }
}
