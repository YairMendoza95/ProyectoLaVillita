﻿using System;
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
    public class EntradaRepository : IRepositorioGenerico<EntradaDTO>
    {
        MySqlConnection conexion;
        MySqlDataAdapter da;
        public EntradaRepository()
        {
            conexion = new MySqlConnection(Properties.Settings.Default.CadenaDeConexion);
            da = new MySqlDataAdapter();
        }

        public IQueryable<EntradaDTO> Elementos
        {
            get
            {
                try
                {
                    conexion.Open();
                    da.SelectCommand = new MySqlCommand("Select * from entrada", conexion);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    conexion.Close();
                    List<EntradaDTO> entradas = new List<EntradaDTO>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        EntradaDTO ent = new EntradaDTO()
                        {
                            idEntrada = Convert.ToInt32(ds.Tables[0].Rows[i]["idEntrada"]),
                            idProducto = Convert.ToInt32(ds.Tables[0].Rows[i]["idProducto"]),
                            idProveedor = Convert.ToInt32(ds.Tables[0].Rows[i]["idProveedor"]),
                            fechaEntrada = Convert.ToDateTime(ds.Tables[0].Rows[i]["fechaEntrada"]).Date,
                            cantidad = Convert.ToInt32(ds.Tables[0].Rows[i]["cantidad"]),
                            montoPagar = Convert.ToInt32(ds.Tables[0].Rows[i]["montóPagar"])
                        };
                        entradas.Add(ent);
                    }
                    return entradas.AsQueryable();
                }
                catch (Exception)
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                    return null;
                }
            }
        }

        public IQueryable<EntradaDTO> Nombre
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool Eliminar(EntradaDTO entidad)
        {
            try
            {
                conexion.Open();
                da.DeleteCommand = new MySqlCommand("Delete from entrada where idEntrada = " + entidad.idEntrada, conexion);
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

        public bool Insertar(EntradaDTO entidad)
        {
            try
            {
                conexion.Open();
                da.InsertCommand = new MySqlCommand("Insert into entrada (idprodducto, idProveedor, fechaEntrada, cantidad, montoPagar) values (idProducto = " + entidad.idProducto + ", idProveedor = " + entidad.idProveedor + ", fechaEntrada = '" + entidad.fechaEntrada + "', cantidad = " + entidad.cantidad + ", montoPagar = " + entidad.montoPagar + ")", conexion);
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

        public bool Modificar(EntradaDTO entidad)
        {
            try
            {
                conexion.Open();
                da.UpdateCommand = new MySqlCommand("Update entrada set idProducto = " + entidad.idProducto + ", idProveedor = " + entidad.idProveedor + ", fechaEntrada = '" + entidad.fechaEntrada + "', cantidad = " + entidad.cantidad + ", montoPagar = " + entidad.montoPagar + " where idEntrada = " + entidad.idEntrada, conexion);
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