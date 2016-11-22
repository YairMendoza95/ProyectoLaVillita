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
    public class RentaManager : IRentaManager
    {
        RentaRepository rentaRepository;
        ConsultaRepository consultaRepository;

        public IQueryable<RentaDTO> Rentas
        {
            get { return rentaRepository.Elementos; }
        }

        public RentaManager()
        {
            rentaRepository = new RentaRepository();
            consultaRepository = new ConsultaRepository();
        }

        public bool InsertarRenta(RentaDTO renta)
        {
            return rentaRepository.Insertar(renta);
        }

        public bool ModificarRenta(RentaDTO renta)
        {
            return rentaRepository.Modificar(renta);
        }

        public bool EliminarRenta(RentaDTO renta)
        {
            return rentaRepository.Eliminar(renta);
        }

        public IEnumerable<RentaDTO> RentasPorPersona(int idCliente)
        {
            throw new NotImplementedException();
        }
    }
}
