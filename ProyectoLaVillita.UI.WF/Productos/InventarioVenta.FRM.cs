using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoLaVillita.UI.WF.Proveedores;
using ProyectoLaVillita.UI.WF.Rentas;
using ProyectoLaVillita.UI.WF.Usuarios;
using ProyectoLaVillita.BIZ;
using ProyectoLaVillita.COMMON.Entidades;

namespace ProyectoLaVillita.UI.WF.Productos
{
	public partial class InventarioVenta : Form
	{
		private ProductoManager _prodManager;
		public string titulo = "Sistema de inventario \"La VIllita\"";
		public InventarioVenta()
		{
			InitializeComponent();
			_prodManager = new ProductoManager();
		}

		private void InventarioVenta_Load(object sender, EventArgs e)
		{
			dgvProductos.DataSource = _prodManager.Productos;
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			try
			{
				_prodManager.BuscarProductoPorNombre(txtIngresarNombre.Text);
			}
			catch (Exception)
			{

				throw;
			}
		}

	}
}
