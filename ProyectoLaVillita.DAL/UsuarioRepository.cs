﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using ProyectoLaVillita.COMMON.Entidades;
using ProyectoLaVillita.COMMON.Interfaces;

namespace ProyectoLaVillita.DAL
{
    public class UsuarioRepository : IRepositorioGenerico<UsuarioDTO>
    {
        MySqlConnection conexion;
        MySqlDataAdapter da;
        public UsuarioRepository()
        {
            conexion = new MySqlConnection(Properties.Settings.Default.CadenaDeConexion);
            da = new MySqlDataAdapter();
        }

        public IQueryable<UsuarioDTO> Elementos
        {
            get
            {
                try
                {
                    conexion.Open();
                    da.SelectCommand = new MySqlCommand("Select * from usuario", conexion);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    conexion.Close();
                    List<UsuarioDTO> usuarios = new List<UsuarioDTO>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
						UsuarioDTO usua = new UsuarioDTO()
						{
							idUsuario = Convert.ToInt32(ds.Tables[0].Rows[i]["idUsuario"]),
							nombreUsuario = ds.Tables[0].Rows[i]["nombreUsuario"].ToString(),
							password = ds.Tables[0].Rows[i]["password"].ToString(),
							idTipoUsuario = Convert.ToInt32(ds.Tables[0].Rows[i]["idTipoUsuario"])
						};
						usuarios.Add(usua);
                    }
                    return usuarios.AsQueryable();
                }
                catch (Exception)
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                    return null;
                }
            }
        }

        public bool Eliminar(UsuarioDTO entidad)
        {
            try
            {
                conexion.Open();
                da.DeleteCommand = new MySqlCommand("Delete from usuario where idUsuario = " + entidad.idUsuario, conexion);
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

        public bool Insertar(UsuarioDTO entidad)
        {
            try
            {
                conexion.Open();
				da.InsertCommand = new MySqlCommand("Insert into usuario (nombreUsuario, password, idTipoUsuario) values ('" + entidad.nombreUsuario + "', '" + entidad.password + "', " + entidad.idTipoUsuario + ")", conexion);
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

        public bool Modificar(UsuarioDTO entidad)
        {
            try
            {
                conexion.Open();
				da.UpdateCommand = new MySqlCommand("Update usuario set nombreUsuario = '" + entidad.nombreUsuario + "', password = '" + entidad.password + "', idTipoUsuario = " + entidad.idTipoUsuario + " where idUsuario = " + entidad.idUsuario, conexion);
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
