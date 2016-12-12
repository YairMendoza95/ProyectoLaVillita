using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoLaVillita.COMMON.Entidades;

namespace ProyectoLaVillita.COMMON.Interfaces
{
	public interface ITipoUsuarioManager
	{
		IQueryable<TipoUsuarioDTO> TiposUsuario { get; }
		TipoUsuarioDTO BuscarTipoPorId(int idTipoUsuario);
		bool InsertarTipo(TipoUsuarioDTO tipo);
		bool EliminarTipo(TipoUsuarioDTO tipo);
		bool ModificarTipo(TipoUsuarioDTO tipo);
	}
}
