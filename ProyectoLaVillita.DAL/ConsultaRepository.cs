using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoLaVillita.COMMON.Entidades;
using ProyectoLaVillita.COMMON.Interfaces;
using MySql.Data.MySqlClient;
using System.Data;
using MySql.Data;

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

        public bool Login(string nombreUsuario, string contraseña)
        {
            try
            {
                conexion.Open();
                da.SelectCommand = new MySqlCommand("Select * from usuario where nombreUsuario='" + nombreUsuario + "' and contraseña='" + contraseña + "'", conexion);
                MySqlDataReader leer = da.SelectCommand.ExecuteReader();
                if (leer.Read())
                {
                    return true;
                }
                else
                {
                    conexion.Close();
                    return false;
                }
            }
            catch (Exception)
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                return false;
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
