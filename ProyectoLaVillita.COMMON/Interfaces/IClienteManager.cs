using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoLaVillita.COMMON.Entidades;

namespace ProyectoLaVillita.COMMON.Interfaces
{
    public interface IClienteManager
    {
        IQueryable<ClienteDTO> Clientes { get; }
        ClienteDTO BuscarClientePorId(int idCliente);
        ClienteDTO BuscarClientePorNombre(string nombre);
        bool InsertarCliente(ClienteDTO cliente);
        bool ModificarCliente(ClienteDTO cliente);
        bool EliminarCliente(ClienteDTO cliente);
        IEnumerable<RentaDTO> RentasPorCliente(int idCliente);
    }
}
