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
    public class TipoProductoManager : ITipoProductoManager
    {
        TipoProductoRepository tipoProductoRepository;
        ConsultaRepository consultaRepository;

        public IQueryable<TipoProductoDTO> TiposDeProductos
        {
            get { return tipoProductoRepository.Elementos; }
        }

        public TipoProductoManager()
        {
            tipoProductoRepository = new TipoProductoRepository();
            consultaRepository = new ConsultaRepository();
        }

        public bool InsertarTipoDeProducto(TipoProductoDTO tipo)
        {
            return tipoProductoRepository.Insertar(tipo);
        }

        public bool ModificarTipoDeProducto(TipoProductoDTO tipo)
        {
            return tipoProductoRepository.Modificar(tipo);
        }

        public bool EliminarTipoDeProducto(TipoProductoDTO tipo)
        {
            return tipoProductoRepository.Eliminar(tipo);
        }

        public IEnumerable<ProductoDTO> ProductosPorTipo(int tipoProducto)
        {
            throw new NotImplementedException();
        }
    }
}
