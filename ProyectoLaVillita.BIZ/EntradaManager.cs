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
    public class EntradaManager : IEntradaManager
    {
        EntradaRepository entradaRepository;
        ConsultaRepository consultaRepository;

        public List<EntradaDTO> Entradas
        {
            get { return entradaRepository.Elementos; }
        }

        public EntradaManager()
        {
            entradaRepository = new EntradaRepository();
            consultaRepository = new ConsultaRepository();
        }

        public bool InsertarEntrada(EntradaDTO entrada)
        {
            return entradaRepository.Insertar(entrada);
        }

        public bool ModificarEntrada(EntradaDTO entrada)
        {
            return entradaRepository.Modificar(entrada);
        }

        public List<EntradaDTO> EntradasPorProducto(int idProducto)
        {
            throw new NotImplementedException();
        }

        public EntradaDTO BuscarEntradaPorId(int idEntrada)
        {
            return entradaRepository.Elementos.FirstOrDefault(e => e.idEntrada == idEntrada);
        }
    }
}
