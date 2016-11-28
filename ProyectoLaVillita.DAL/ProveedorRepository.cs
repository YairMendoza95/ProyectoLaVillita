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
    public class ProveedorRepository : IRepositorioGenerico<ProveedorDTO>
    {
        MySqlConnection conexion;
        MySqlDataAdapter da;
        public ProveedorRepository()
        {
            conexion = new MySqlConnection(Properties.Settings.Default.CadenaDeConexion);
            da = new MySqlDataAdapter();
        }

        public IQueryable<ProveedorDTO> Elementos
        {
            get
            {
                try
                {
                    conexion.Open();
                    da.SelectCommand = new MySqlCommand("Select * from proveedor", conexion);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    conexion.Close();
                    List<ProveedorDTO> proveedores = new List<ProveedorDTO>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        ProveedorDTO prov = new ProveedorDTO()
                        {
                            idProveedor = Convert.ToInt32(ds.Tables[0].Rows[i]["idProveedor"]),
                            nombreProveedor = ds.Tables[0].Rows[i]["nombreProveedor"].ToString(),
                            telefono = ds.Tables[0].Rows[i]["telefono"].ToString()
                        };
                        proveedores.Add(prov);
                    }
                    return proveedores.AsQueryable();
                }
                catch (Exception)
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                    return null;
                }
            }
        }

        public IQueryable<ProveedorDTO> Nombre
        {
            get
            {
                try
                {
                    conexion.Open();
                    da.SelectCommand = new MySqlCommand("Select nombre from proveedor", conexion);
                    DataSet dc = new DataSet();
                    da.Fill(dc);
                    conexion.Close();
                    List<ProveedorDTO> proveedor = new List<ProveedorDTO>();
                    for (int i = 0; i < dc.Tables[0].Rows.Count; i++)
                    {
                        ProveedorDTO prov = new ProveedorDTO()
                        {
                            nombreProveedor = dc.Tables[0].Rows[i]["nombreProveedor"].ToString()
                        };
                        proveedor.Add(prov);
                    }
                    return proveedor.AsQueryable();
                }
                catch (Exception)
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                    return null;
                }
            }
        }

        public bool Eliminar(ProveedorDTO entidad)
        {
            try
            {
                conexion.Open();
                da.DeleteCommand = new MySqlCommand("Delete from proveedor where idProveedor =" + entidad.idProveedor, conexion);
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

        public bool Insertar(ProveedorDTO entidad)
        {
            try
            {
                conexion.Open();
                da.InsertCommand = new MySqlCommand("Insert into proveedor (nombre, telefono) values (nombre = '" + entidad.nombreProveedor + "', telefono = '" + entidad.telefono + "')", conexion);
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

        public bool Modificar(ProveedorDTO entidad)
        {
            try
            {
                conexion.Open();
                da.UpdateCommand = new MySqlCommand("Update proveedor set nombre = '" + entidad.nombreProveedor + "', telefono = '" + entidad.telefono + "' where idProveedor = " + entidad.idProveedor, conexion);
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
                    return false;
                return false;
            }
        }
    }
}
