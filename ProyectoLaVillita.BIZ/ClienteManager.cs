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
    public class ClienteManager : IClienteManager
    {
        ClienteRepository clienteRepository;
        ConsultaRepository consultaRepository;
        public ClienteManager()
        {
            clienteRepository = new ClienteRepository();
            consultaRepository = new ConsultaRepository();
        }

        public IQueryable<ClienteDTO> Clientes
        {
            get { return clienteRepository.Elementos; }
        }

        public IQueryable<ClienteDTO> Nombres
        {
            get { return clienteRepository.Nombre; }
        }

        public ClienteDTO BuscarClientePorId(int idCliente)
        {
            return clienteRepository.Elementos.FirstOrDefault(c => c.idCliente == idCliente);
        }

        public ClienteDTO BuscarClientePorNombre(string nombre)
        {
            return clienteRepository.Elementos.FirstOrDefault(c => c.nombre == nombre);
        }

        public bool EliminarCliente(ClienteDTO cliente)
        {
            return clienteRepository.Eliminar(cliente);
        }

        public bool InsertarCliente(ClienteDTO cliente)
        {
            return clienteRepository.Insertar(cliente);
        }

        public bool ModificarCliente(ClienteDTO cliente)
        {
            return clienteRepository.Modificar(cliente);
        }

        public IEnumerable<RentaDTO> RentasPorCliente(int idCliente)
        {
            throw new NotImplementedException();
        }
    }
}
