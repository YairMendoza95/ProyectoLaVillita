using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaVillita.COMMON.Entidades
{
    public class UsuarioDTO : BaseDTO
    {
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }
    }
}
