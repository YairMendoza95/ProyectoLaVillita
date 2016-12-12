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
    public class RentaRepository : IRepositorioGenerico<RentaDTO>
    {
        MySqlConnection conexion;
        MySqlDataAdapter da;
        public RentaRepository()
        {
            conexion = new MySqlConnection(Properties.Settings.Default.CadenaDeConexion);
            da = new MySqlDataAdapter();
        }

        public IQueryable<RentaDTO> Elementos
        {
            get
            {
                try
                {
                    conexion.Open();
                    da.SelectCommand = new MySqlCommand("Select * from renta", conexion);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    conexion.Close();
                    List<RentaDTO> rentas = new List<RentaDTO>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
						RentaDTO ren = new RentaDTO()
						{
							idRenta = Convert.ToInt32(ds.Tables[0].Rows[i]["idRenta"]),
							idUsuario = Convert.ToInt32(ds.Tables[0].Rows[i]["idUsuario"]),
							idTipoUsuario = Convert.ToInt32(ds.Tables[0].Rows[i]["idTipoUsuario"]),
							idCliente = Convert.ToInt32(ds.Tables[0].Rows[i]["idCliente"]),
							fechaInicio = ds.Tables[0].Rows[i]["fechaInicio"].ToString(),
							fechaVencimiento = ds.Tables[0].Rows[i]["fechaVencimiento"].ToString(),
							total = Convert.ToInt32(ds.Tables[0].Rows[i]["total"]),
							notas = ds.Tables[0].Rows[i]["notas"].ToString()
						};
                    }
                    return rentas.AsQueryable();
                }
                catch (Exception)
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                    return null;
                }
            }
        }

        public bool Eliminar(RentaDTO entidad)
        {
            try
            {
                conexion.Open();
                da.DeleteCommand = new MySqlCommand("Delete from renta where idRenta = " + entidad.idRenta, conexion);
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

        public bool Insertar(RentaDTO entidad)
        {
            try
            {
                conexion.Open();
				da.InsertCommand = new MySqlCommand("Insert into renta (idUsuario, idTipoUsuario, idCliente, fechaInicio, fechaVencimiento, total, notas) values (" + entidad.idUsuario + ", " + entidad.idTipoUsuario + ", " + entidad.idCliente + ", '" + entidad.fechaInicio + "', '" + entidad.fechaVencimiento + "', " + entidad.total + ", '" + entidad.notas + "')", conexion);
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

        public bool Modificar(RentaDTO entidad)
        {
            try
            {
                conexion.Open();
				da.UpdateCommand = new MySqlCommand("Update renta set idUsuario = " + entidad.idUsuario + ", idTipoUsuario = " + entidad.idTipoUsuario + ", idCliente = " + entidad.idCliente + ", fechaInicio = '" + entidad.fechaInicio + "', fechaVencimiento = '" + entidad.fechaVencimiento + "', total = " + entidad.total + ", notas = '" + entidad.notas + "' where idRenta = " + entidad.idRenta, conexion);
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
