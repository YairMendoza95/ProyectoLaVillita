using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoLaVillita.COMMON.Entidades;
using ProyectoLaVillita.COMMON.Interfaces;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProyectoLaVillita.DAL
{
    public class ClienteRepository : IRepositorioGenerico<ClienteDTO>
    {
        MySqlConnection conexion;
        MySqlDataAdapter da;
        public ClienteRepository()
        {
            conexion = new MySqlConnection(Properties.Settings.Default.CadenaDeConexion);
            da = new MySqlDataAdapter();
        }
        public IQueryable<ClienteDTO> Elementos
        {
            get
            {
                try
                {
                    conexion.Open();
                    da.SelectCommand = new MySqlCommand("Select * from cliente", conexion);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    conexion.Close();
                    List<ClienteDTO> clientes = new List<ClienteDTO>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        ClienteDTO cli = new ClienteDTO()
                        {
                            idCliente = Convert.ToInt32(ds.Tables[0].Rows[i]["idCliente"]),
                            nombre = ds.Tables[0].Rows[i]["nombre"].ToString(),
                            apPaterno = ds.Tables[0].Rows[i]["apPaterno"].ToString(),
                            apMaterno = ds.Tables[0].Rows[i]["apMaterno"].ToString(),
                            telefono = ds.Tables[0].Rows[i]["telefono"].ToString()
                        };
                        clientes.Add(cli);
                    }
                    return clientes.AsQueryable();
                }
                catch (Exception)
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                    return null;
                }
            }
        }

        public IQueryable<ClienteDTO> Nombre
        {
            get
            {
                try
                {
                    conexion.Open();
                    da.SelectCommand = new MySqlCommand("Select nombre, apPaterno, apMaterno from cliente", conexion);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    conexion.Close();
                    List<ClienteDTO> cliente = new List<ClienteDTO>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        ClienteDTO cli = new ClienteDTO()
                        {
                            nombre = ds.Tables[0].Rows[i]["nombre"].ToString(),
                            apPaterno = ds.Tables[0].Rows[i]["apPaterno"].ToString(),
                            apMaterno = ds.Tables[0].Rows[i]["apMaterno"].ToString()
                        };
                        cliente.Add(cli);
                    }
                    return cliente.AsQueryable();
                }
                catch (Exception)
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                    return null;
                }
            }
        }

        public bool Eliminar(ClienteDTO entidad)
        {
            try
            {
                conexion.Open();
                da.DeleteCommand = new MySqlCommand("Delete from cliente where idCliente = " + entidad.idCliente, conexion);
                int afectados = da.DeleteCommand.ExecuteNonQuery();
                conexion.Close();
                if (afectados > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                return false;
            }
        }

        public bool Insertar(ClienteDTO entidad)
        {
            try
            {
                conexion.Open();
                da.InsertCommand = new MySqlCommand("Insert into cliente (nombre, apPaterno, apMaterno, telefono) values ('" + entidad.nombre + "', '" + entidad.apPaterno + "', '" + entidad.apMaterno + "', '" + entidad.telefono + "')", conexion);
                int afectados = da.InsertCommand.ExecuteNonQuery();
                conexion.Close();
                if (afectados > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                return false;
            }
        }

        public bool Modificar(ClienteDTO entidad)
        {
            try
            {
                conexion.Open();
                da.UpdateCommand = new MySqlCommand("Update cliente set nombre = '" + entidad.nombre + ", apPaterno = '" + entidad.apPaterno + "', apMaterno = '" + entidad.apMaterno + "', telefono = '" + entidad.telefono + "'where idCliente = " + entidad.idCliente, conexion);
                int afectados = da.UpdateCommand.ExecuteNonQuery();
                conexion.Close();
                if (afectados > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                return false;
            }
        }
    }
}
