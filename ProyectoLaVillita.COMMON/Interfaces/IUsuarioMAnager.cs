using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProyectoLaVillita.COMMON.Entidades;
using System.Threading.Tasks;

namespace ProyectoLaVillita.COMMON.Interfaces
{
    public interface IUsuarioManager
    {
        List<UsuarioDTO> Usuarios { get; }
        UsuarioDTO BuscarUsuarioPorId(int idUsuario);
        bool InsertarUsuario(UsuarioDTO usuario);
        bool ModificarUsuario(UsuarioDTO usuario);
        bool EliminarUsuario(UsuarioDTO usuario);
        bool Login(string nombreUsuario, string contraseña);
    }
}
