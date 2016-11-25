using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoLaVillita.COMMON.Entidades;
using ProyectoLaVillita.COMMON.Interfaces;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProyectoLaVillita.DAL
{
    public class ConsultaRepository : IConsultaManager
    {
        MySqlConnection conexion;
        MySqlDataAdapter da;
        public ConsultaRepository()
        {
            conexion = new MySqlConnection(Properties.Settings.Default.CadenaDeConexion);
            da = new MySqlDataAdapter();
        }

        public IEnumerable<EntradaDTO> EntradasPorProducto(int idProducto)
        {
            throw new NotImplementedException();
        }

        public IQueryable<UsuarioDTO> Login(string nombreUsuario, string contraseña)
        {
            try
            {
                conexion.Open();
                da.SelectCommand = new MySqlCommand("Select * from usuario where nombreUsuario='" + nombreUsuario + "' and contraseña='" + contraseña + "'", conexion);
                DataSet ds = new DataSet();
                da.Fill(ds);
                conexion.Close();
                List<UsuarioDTO> usuario = new List<UsuarioDTO>();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    UsuarioDTO user = new UsuarioDTO()
                    {
                        nombreUsuario = ds.Tables[0].Rows[i]["nombreUsuario"].ToString(),
                        contraseña = ds.Tables[0].Rows[i]["contraseña"].ToString()
                    };
                    usuario.Add(user);
                }
                return usuario.AsQueryable();
            }
            catch (Exception)
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                return null;
            }
        }

        public IEnumerable<ProductoDTO> ProductosDeUnaVenta(int idVenta)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductoDTO> ProductosDeUnProveedor(int idProveedor)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductoDTO> ProductosPorTipo(int tipoProducto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RentaDTO> RentasPorPersona(int idCliente)
        {
            throw new NotImplementedException();
        }
    }
}
