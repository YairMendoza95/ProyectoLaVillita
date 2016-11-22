using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaVillita.COMMON.Interfaces
{
    public interface IRepositorioGenerico<T> where T : class
    {
        IQueryable<T> Elementos { get; }
        bool Insertar(T entidad);
        bool Modificar(T entidad);
        bool Eliminar(T entidad);
    }
}
