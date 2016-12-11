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
		TipoProductoRepository tipopRepository;
		public TipoProductoManager()
		{
			tipopRepository = new TipoProductoRepository();
		}
		public IQueryable<TipoProductoDTO> Tipos
		{
			get
			{
				return tipopRepository.Elementos;
			}
		}

		public bool AgregarTipo(TipoProductoDTO tipo)
		{
			return tipopRepository.Insertar(tipo);
		}

		public TipoProductoDTO BuscarTipoPorId(int idTipoProducto)
		{
			return tipopRepository.Elementos.FirstOrDefault(tp => tp.idTIpoProducto == idTipoProducto);
		}

		public bool EliminarTipo(TipoProductoDTO tipo)
		{
			return tipopRepository.Eliminar(tipo);
		}

		public bool ModificarTipo(TipoProductoDTO tipo)
		{
			return tipopRepository.Modificar(tipo);
		}
	}
}
