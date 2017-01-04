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
    public class UsuarioManager : IUsuarioManager
    {
        UsuarioRepository usuarioRepository;
        ConsultaRepository consultaRepository;
        public UsuarioManager()
        {
            usuarioRepository = new UsuarioRepository();
            consultaRepository = new ConsultaRepository();
        }

        public IQueryable<UsuarioDTO> Usuarios
        {
            get { return usuarioRepository.Elementos; }
        }

        public UsuarioDTO BuscarUsuarioPorId(int idUsuario)
        {
            return usuarioRepository.Elementos.FirstOrDefault(u => u.idUsuario == idUsuario);
        }

        public bool EliminarUsuario(UsuarioDTO usuario)
        {
            return usuarioRepository.Eliminar(usuario);
        }

        public bool InsertarUsuario(UsuarioDTO usuario)
        {
            return usuarioRepository.Insertar(usuario);
        }

        public bool ModificarUsuario(UsuarioDTO usuario)
        {
            return usuarioRepository.Modificar(usuario);
        }

        public bool Login(string nombreUsuario, string password)
        {
            return consultaRepository.Login(nombreUsuario, password);
        }

		public UsuarioDTO BuscarUsuarioPorNombre(string nombre)
		{
			return usuarioRepository.Elementos.FirstOrDefault(u => u.nombreUsuario == nombre);
		}
	}
}