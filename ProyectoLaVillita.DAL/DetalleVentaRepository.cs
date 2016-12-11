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
    public class DetalleVentaRepository : IRepositorioGenerico<DetalleVentaDTO>
    {
        MySqlConnection conexion;
        MySqlDataAdapter da;
        public DetalleVentaRepository()
        {
            conexion = new MySqlConnection(Properties.Settings.Default.CadenaDeConexion);
            da = new MySqlDataAdapter();
        }

        public IQueryable<DetalleVentaDTO> Elementos
        {
            get
            {
                try
                {
                    conexion.Open();
                    da.SelectCommand = new MySqlCommand("Select * from detallevente", conexion);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    conexion.Close();
                    List<DetalleVentaDTO> detallesVentas = new List<DetalleVentaDTO>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        DetalleVentaDTO dv = new DetalleVentaDTO()
                        {
                            idDetalleVenta = Convert.ToInt32(ds.Tables[0].Rows[i]["idDetalleVenta"]),
                            idVenta = Convert.ToInt32(ds.Tables[0].Rows[i]["IdVenta"]),
                            idProducto = Convert.ToInt32(ds.Tables[0].Rows[i]["idProducto"]),
                            idProveedor = Convert.ToInt32(ds.Tables[0].Rows[i]["idProveedor"]),
                            cantidad = Convert.ToInt32(ds.Tables[0].Rows[i]["cantidad"]),
                            total = Convert.ToInt32(ds.Tables[0].Rows[i]["total"])
                        };
                        detallesVentas.Add(dv);
                    }
                    return detallesVentas.AsQueryable();
                }
                catch (Exception)
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                    return null;
                }
            }
        }

        public bool Eliminar(DetalleVentaDTO entidad)
        {
            try
            {
                conexion.Open();
                da.SelectCommand = new MySqlCommand("Delete from detalleventa where idDetalleVenta = " + entidad.idDetalleVenta, conexion);
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

        public bool Insertar(DetalleVentaDTO entidad)
        {
            try
            {
                conexion.Open();
                da.InsertCommand = new MySqlCommand("Insert into detalleventa (idVenta, idProducto, idProveedor, cantidad, total) values (" + entidad.idVenta + ", " + entidad.idProducto + ", " + entidad.idProveedor + ", " + entidad.cantidad + ", " + entidad.total + ")", conexion);
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

        public bool Modificar(DetalleVentaDTO entidad)
        {
            try
            {
                conexion.Open();
                da.UpdateCommand = new MySqlCommand("Update detalleventa set idVenta = " + entidad.idVenta + ", idProducto = " + entidad.idProducto + ", idProveedor = " + entidad.idProveedor + ", cantidad = " + entidad.cantidad + ", total = " + entidad.total + " where idDetalleVenta =" + entidad.idDetalleVenta, conexion);
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
