﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoLaVillita.BIZ;
using ProyectoLaVillita.COMMON.Entidades;

namespace ProyectoLaVillita.UI.WF.Productos
{
	public partial class ProductoPedir : Form
	{
		private ProductoManager _prodManager;
		public ProductoPedir()
		{
			InitializeComponent();
			_prodManager = new ProductoManager();
		}

		private void ProductoPedir_Load(object sender, EventArgs e)
		{
			List<ProductoDTO> productos = new List<ProductoDTO>();
			for (int i = 0; i < _prodManager.Productos.ToList().Count; i++)
			{
				if (_prodManager.Productos.ToList()[i].stockActual <= _prodManager.Productos.ToList()[i].stockMin)
				{
					productos.Add(_prodManager.Productos.ToList()[i]);
				}
			}
			if(productos.Count>0)
			{
				dgvProductos.DataSource = productos;
			}
		}
	}
}
