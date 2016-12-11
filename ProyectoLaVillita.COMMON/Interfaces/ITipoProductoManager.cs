using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoLaVillita.COMMON.Entidades;

namespace ProyectoLaVillita.COMMON.Interfaces
{
	public interface ITipoProductoManager
	{
		IQueryable<TipoProductoDTO> Tipos { get; }
		TipoProductoDTO BuscarTipoPorId(int idTipoProducto);
		bool AgregarTipo(TipoProductoDTO tipo);
		bool ModificarTipo(TipoProductoDTO tipo);
		bool EliminarTipo(TipoProductoDTO tipo);
	}
}
