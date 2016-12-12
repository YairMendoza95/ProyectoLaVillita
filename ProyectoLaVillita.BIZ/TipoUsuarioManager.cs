using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoLaVillita.DAL;
using ProyectoLaVillita.COMMON.Entidades;
using ProyectoLaVillita.COMMON.Interfaces;

namespace ProyectoLaVillita.BIZ
{
	public class TipoUsuarioManager : ITipoUsuarioManager
	{
		TipoUsuarioRepository tuRepository;
		public TipoUsuarioManager()
		{
			tuRepository = new TipoUsuarioRepository();
		}
		public IQueryable<TipoUsuarioDTO> TiposUsuario
		{
			get
			{
				return tuRepository.Elementos;
			}
		}

		public TipoUsuarioDTO BuscarTipoPorId(int idTipoUsuario)
		{
			return tuRepository.Elementos.FirstOrDefault(tu => tu.idTipoUsuario == idTipoUsuario);
		}

		public bool EliminarTipo(TipoUsuarioDTO tipo)
		{
			return tuRepository.Eliminar(tipo);
		}

		public bool InsertarTipo(TipoUsuarioDTO tipo)
		{
			return tuRepository.Insertar(tipo);
		}

		public bool ModificarTipo(TipoUsuarioDTO tipo)
		{
			return tuRepository.Modificar(tipo);
		}
	}
}
