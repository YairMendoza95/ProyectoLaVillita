using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProyectoLaVillita.COMMON.Entidades;
using ProyectoLaVillita.COMMON.Interfaces;
using System.Data;

namespace ProyectoLaVillita.DAL
{
    public class VentaRepository : IRepositorioGenerico<VentaDTO>
    {
        MySqlConnection conexion;
        MySqlDataAdapter da;
        public VentaRepository()
        {
            conexion = new MySqlConnection(Properties.Settings.Default.CadenaDeConexion);
            da = new MySqlDataAdapter();
        }

        public IQueryable<VentaDTO> Elementos
        {
            get
            {
                try
                {
                    conexion.Open();
                    da.SelectCommand = new MySqlCommand("Select * from venta", conexion);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    conexion.Close();
                    List<VentaDTO> ventas = new List<VentaDTO>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
						VentaDTO ven = new VentaDTO()
						{
							idVenta = Convert.ToInt32(ds.Tables[0].Rows[i]["idVenta"]),
							idUsuario = Convert.ToInt32(ds.Tables[0].Rows[i]["idUsuario"]),
							fechaVenta = ds.Tables[0].Rows[i]["fechaVenta"].ToString(),
							total = Convert.ToInt32(ds.Tables[0].Rows[i]["total"]),
							notas = ds.Tables[0].Rows[i]["notas"].ToString()
						};
                        ventas.Add(ven);
                    }
                    return ventas.AsQueryable();
                }
                catch (Exception)
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                    return null;
                }
            }
        }

        public bool Eliminar(VentaDTO entidad)
        {
            try
            {
                conexion.Open();
                da.DeleteCommand = new MySqlCommand("Delete from venta where idVenta = " + entidad.idVenta, conexion);
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

        public bool Insertar(VentaDTO entidad)
        {
            try
            {
                conexion.Open();
				da.InsertCommand = new MySqlCommand("Insert into venta (idUsuario, fechaVenta, total, notas) values (" + entidad.idUsuario + ", '" + entidad.fechaVenta + "', " + entidad.total + ", '" + entidad.notas + "')", conexion);
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

        public bool Modificar(VentaDTO entidad)
        {
            try
            {
                conexion.Open();
				da.UpdateCommand = new MySqlCommand("Update venta set idUsuario = " + entidad.idUsuario + ", fechaVenta = '" + entidad.fechaVenta + "', total = " + entidad.total + ", notas = '" + entidad.notas + "' where idVenta = " + entidad.idVenta, conexion);
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
