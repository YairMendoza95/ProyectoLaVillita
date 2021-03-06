﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProyectoLaVillita.COMMON.Entidades;
using System.Threading.Tasks;

namespace ProyectoLaVillita.COMMON.Interfaces
{
    public interface IUsuarioManager
    {
        IQueryable<UsuarioDTO> Usuarios { get; }
        UsuarioDTO BuscarUsuarioPorId(int idUsuario);
		UsuarioDTO BuscarUsuarioPorNombre(string nombre);
        bool InsertarUsuario(UsuarioDTO usuario);
        bool ModificarUsuario(UsuarioDTO usuario);
        bool EliminarUsuario(UsuarioDTO usuario);
        bool Login(string nombreUsuario, string password);
    }
}
