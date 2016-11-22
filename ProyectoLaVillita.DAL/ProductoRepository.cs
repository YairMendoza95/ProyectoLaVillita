﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using ProyectoLaVillita.COMMON.Entidades;
using ProyectoLaVillita.COMMON.Interfaces;

namespace ProyectoLaVillita.DAL
{
    public class ProductoRepository : IRepositorioGenerico<ProductoDTO>
    {
        MySqlConnection conexion;
        MySqlDataAdapter da;
        public ProductoRepository()
        {
            conexion = new MySqlConnection(Properties.Settings.Default.CadenaDeConexion);
            da = new MySqlDataAdapter();
        }

        public IQueryable<ProductoDTO> Elementos
        {
            get
            {
                try
                {
                    conexion.Open();
                    da.SelectCommand = new MySqlCommand("Select * from producto", conexion);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    conexion.Close();
                    List<ProductoDTO> productos = new List<ProductoDTO>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        ProductoDTO prod = new ProductoDTO()
                        {
                            idProducto = Convert.ToInt32(ds.Tables[0].Rows[i]["idProducto"]),
                            nombre = ds.Tables[0].Rows[i]["nombre"].ToString(),
                            idProveedor = Convert.ToInt32(ds.Tables[0].Rows[i]["idProveedor"]),
                            precioUnitario = Convert.ToInt32(ds.Tables[0].Rows[i]["precioUnitario"]),
                            stockMax = Convert.ToInt32(ds.Tables[0].Rows[i]["stockMax"]),
                            stockMin = Convert.ToInt32(ds.Tables[0].Rows[i]["stockMin"]),
                            stockActual = Convert.ToInt32(ds.Tables[0].Rows[i]["stockActual"]),
                            idTipoProducto = Convert.ToInt32(ds.Tables[0].Rows[i]["idTipoProducto"])
                        };
                        productos.Add(prod);
                    }
                    return productos.AsQueryable();
                }
                catch (Exception)
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                    return null;
                }
            }
        }

        public bool Eliminar(ProductoDTO entidad)
        {
            try
            {
                conexion.Open();
                da.DeleteCommand = new MySqlCommand("Delete from producto where idProducto = " + entidad.idProducto, conexion);
                int afectados = da.DeleteCommand.ExecuteNonQuery();
                conexion.Close();
                if (afectados > 0)
                {
                    return true;
                }
                else
                {
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

        public bool Insertar(ProductoDTO entidad)
        {
            try
            {
                conexion.Open();
                da.InsertCommand = new MySqlCommand("Insert into producto (nombre, idProveedor, precioUnitario, stockMax, stockMax, stockActual, idTipoProducto) values(nombre = '" + entidad.nombre + "', Proveedor = " + entidad.idProveedor + ", precioUnitario = " + entidad.precioUnitario + ", stockMax = " + entidad.stockMax + ", stockMin = " + entidad.stockMin + ", stockActual = " + entidad.stockActual + ", idTipoProducto = " + entidad.idTipoProducto + ")", conexion);
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
                return true;
            }
        }

        public bool Modificar(ProductoDTO entidad)
        {
            try
            {
                conexion.Open();
                da.UpdateCommand = new MySqlCommand("Update producto set nombre = '" + entidad.nombre + "', idProveedor = " + entidad.idProveedor + ", precioUnitario = " + entidad.precioUnitario + ", stockMax = " + entidad.stockMax + ", stockMin = " + entidad.stockMin + ", stockActual = " + entidad.stockActual + ", idTipoProdcuto = " + entidad.idTipoProducto + " where idProducto", conexion);
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
