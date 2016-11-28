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
    public class DetalleRentaRepository : IRepositorioGenerico<DetalleRentaDTO>
    {
        MySqlConnection conexion;
        MySqlDataAdapter da;
        public DetalleRentaRepository()
        {
            conexion = new MySqlConnection(Properties.Settings.Default.CadenaDeConexion);
            da = new MySqlDataAdapter();
        }

        public IQueryable<DetalleRentaDTO> Elementos
        {
            get
            {
                try
                {
                    conexion.Open();
                    da.SelectCommand = new MySqlCommand("Select * from datallerenta", conexion);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    conexion.Close();
                    List<DetalleRentaDTO> detallesRentas = new List<DetalleRentaDTO>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        DetalleRentaDTO dr = new DetalleRentaDTO()
                        {
                            idDetalleRenta = Convert.ToInt32(ds.Tables[0].Rows[i]["idDetalleRenta"]),
                            idRenta = Convert.ToInt32(ds.Tables[0].Rows[i]["idRenta"]),
                            idProducto = Convert.ToInt32(ds.Tables[0].Rows[i]["idProducto"]),
                            idProveedor = Convert.ToInt32(ds.Tables[0].Rows[i]["idProveedor"]),
                            cantidad = Convert.ToInt32(ds.Tables[0].Rows[i]["cantidad"]),
                            total = Convert.ToInt32(ds.Tables[0].Rows[i]["total"]),
                            fechaInicio = Convert.ToDateTime(ds.Tables[0].Rows[i]["fechaInicio"]).Date,
                            fechaVencimiento = Convert.ToDateTime(ds.Tables[0].Rows[i]["fechaVencimiento"]).Date
                        };
                        detallesRentas.Add(dr);
                    }
                    return detallesRentas.AsQueryable();
                }
                catch (Exception)
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                    return null;
                }
            }
        }

        public IQueryable<DetalleRentaDTO> Nombre
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool Eliminar(DetalleRentaDTO entidad)
        {
            try
            {
                conexion.Open();
                da.DeleteCommand = new MySqlCommand("Delete from detallerenta where idDetalleRenta = " + entidad.idDetalleRenta, conexion);
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

        public bool Insertar(DetalleRentaDTO entidad)
        {
            try
            {
                conexion.Open();
                da.InsertCommand = new MySqlCommand("Insert into detallerenta (idRenta, idProdcucto, idProveedor, cantidad, total, fechaInicio, FehcaVencimiento) values (" + entidad.idRenta + ", " + entidad.idProducto + ", " + entidad.idProveedor + ", " + entidad.cantidad + ", " + entidad.total + ", '" + entidad.fechaInicio + "', '" + entidad.fechaVencimiento + "')", conexion);
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

        public bool Modificar(DetalleRentaDTO entidad)
        {
            try
            {
                conexion.Open();
                da.UpdateCommand = new MySqlCommand("Update detallerenta set idRenta = " + entidad.idRenta + ", idProducto = " + entidad.idProducto + ", idProveedor = " + entidad.idProveedor + ", cantidad = " + entidad.cantidad + ", total = " + entidad.total + ", fechaInicio = '" + entidad.fechaInicio + "' fechaVencimiento = '" + entidad.fechaVencimiento + "' where idDetalleRenta = " + entidad.idDetalleRenta, conexion);
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
