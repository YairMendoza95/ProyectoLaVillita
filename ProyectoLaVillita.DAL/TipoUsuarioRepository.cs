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
	public class TipoUsuarioRepository : IRepositorioGenerico<TipoUsuarioDTO>
	{
		MySqlConnection conexion;
		MySqlDataAdapter da;
		public TipoUsuarioRepository()
		{
			conexion = new MySqlConnection(Properties.Settings.Default.CadenaDeConexion);
			da = new MySqlDataAdapter();
		}
		public IQueryable<TipoUsuarioDTO> Elementos
		{
			get
			{
				try
				{
					conexion.Open();
					da.SelectCommand = new MySqlCommand("Select * from tipousuario", conexion);
					DataSet ds = new DataSet();
					da.Fill(ds);
					conexion.Close();
					List<TipoUsuarioDTO> tipos = new List<TipoUsuarioDTO>();
					for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
					{
						TipoUsuarioDTO tu = new TipoUsuarioDTO()
						{
							idTipoUsuario = Convert.ToInt32(ds.Tables[0].Rows[i]["idTipoUsuario"]),
							nombre = ds.Tables[0].Rows[i]["nombre"].ToString()
						};
						tipos.Add(tu);
					}
					return tipos.AsQueryable();
				}
				catch (Exception)
				{
					if (conexion.State == ConnectionState.Open)
						conexion.Close();
					return null;
				}
			}
		}

		public bool Eliminar(TipoUsuarioDTO entidad)
		{
			try
			{
				conexion.Open();
				da.DeleteCommand = new MySqlCommand("Delete from tipousuario where idTipoUsuario = " + entidad.idTipoUsuario, conexion);
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

		public bool Insertar(TipoUsuarioDTO entidad)
		{
			try
			{
				conexion.Open();
				da.InsertCommand = new MySqlCommand("Insert into tipousuario (nombre) values ('" + entidad.nombre + "')", conexion);
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

		public bool Modificar(TipoUsuarioDTO entidad)
		{
			try
			{
				conexion.Open();
				da.UpdateCommand = new MySqlCommand("Update tipousuario set nombre = '" + entidad.nombre + "' where idTipoUsuario = " + entidad.idTipoUsuario, conexion);
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
