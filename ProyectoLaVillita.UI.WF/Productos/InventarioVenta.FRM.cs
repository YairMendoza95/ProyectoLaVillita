﻿using System;
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
		private ProveedorManager _provManager;
		private ProductoDTO _prod;
		public string titulo = "Sistema de inventario \"La VIllita\"";
		public InventarioVenta()
		{
			InitializeComponent();
			_prodManager = new ProductoManager();
			_provManager = new ProveedorManager();
		}

		private void InventarioVenta_Load(object sender, EventArgs e)
		{
			if (Program.idUsuario != 1)
			{
				usuariosToolStripMenuItem.Visible = false;
				cerrarSesiónToolStripMenuItem.Visible = true;
			}
			else
			{
				usuariosToolStripMenuItem.Visible = true;
				cerrarSesiónToolStripMenuItem.Visible = false;
			}
			var productos = _prodManager.Productos.ToList();
			if (productos.Count > 0)
			{
				dgvProductos.DataSource = productos;
				dgvProductos.Columns[0].HeaderText = "Id";
				dgvProductos.Columns[0].DataPropertyName = "idProducto";
				//dgvProductos.Columns[0].AutoSizeMode;
				dgvProductos.Columns[1].HeaderText = "Nombre";
				dgvProductos.Columns[1].DataPropertyName = "nombre";
				dgvProductos.Columns[2].HeaderText = "Proveedor";
				dgvProductos.Columns[2].DataPropertyName = "idProveedor";
				dgvProductos.Columns[3].HeaderText = "Precio Compra";
				dgvProductos.Columns[3].DataPropertyName = "precioCompra";
				dgvProductos.Columns[4].HeaderText = "Precio Venta";
				dgvProductos.Columns[4].DataPropertyName = "precioVenta";
				dgvProductos.Columns[5].HeaderText = "Stock Actual";
				dgvProductos.Columns[5].DataPropertyName = "stockActual";
				dgvProductos.Columns[6].HeaderText = "Stock Máximo";
				dgvProductos.Columns[6].DataPropertyName = "stockMax";
				dgvProductos.Columns[7].HeaderText = "Stock Mínimo";
				dgvProductos.Columns[7].DataPropertyName = "stockMin";
				label11.Visible = false;
			}
			else
				label11.Visible = true;
			label13.Text = Program.nombreUsuario;
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

		private void registroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new NuevoProducto().Show();
			this.Hide();
		}

		private void registroDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new NuevoProveedor().Show();
			this.Hide();
		}

		private void modificarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new ModificarProveedor().Show();
			this.Hide();
		}

		private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Entrada().Show();
			this.Hide();
		}

		private void datosDelClienteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new NuevaRenta().Show();
			this.Hide();
		}

		private void modificarRentaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new ModificarRenta().Show();
			this.Hide();
		}

		private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			new InventarioRenta().Show();
			this.Hide();
		}

		private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new AgregarUsuario().Show();
			this.Hide();
		}

		private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new ModificarUsuario().Show();
			this.Hide();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Está seguro que desea salir?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				Application.Exit();
		}

		private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtId.Text = dgvProductos.SelectedRows[0].Cells[0].Value.ToString();
			txtNombre.Text = dgvProductos.SelectedRows[0].Cells[1].Value.ToString();
			txtProveedor.Text = _provManager.BuscarProveedorPorId(Convert.ToInt32(dgvProductos.SelectedRows[0].Cells[2].Value)).nombreProveedor;
			txtCompra.Text = dgvProductos.SelectedRows[0].Cells[3].Value.ToString();
			txtVenta.Text = dgvProductos.SelectedRows[0].Cells[4].Value.ToString();
			txtActual.Text = dgvProductos.SelectedRows[0].Cells[5].Value.ToString();
			txtMaximo.Text = dgvProductos.SelectedRows[0].Cells[6].Value.ToString();
			txtMinimo.Text = dgvProductos.SelectedRows[0].Cells[7].Value.ToString();
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			List<ProveedorDTO> proveedores = _provManager.Proveedores.ToList();
			txtProveedor.Visible = false;
			btnGuardar.Visible = true;
			txtNombre.ReadOnly = false;
			txtProveedor.ReadOnly = false;
			txtCompra.ReadOnly = false;
			txtVenta.ReadOnly = false;
			txtActual.ReadOnly = false;
			txtMaximo.ReadOnly = false;
			txtMinimo.ReadOnly = false;
			cmbProveedores.Visible = true;
			if (proveedores.Count > 0)
			{
				cmbProveedores.DataSource = proveedores;
				cmbProveedores.DisplayMember = "nombreProveedor";
				cmbProveedores.ValueMember = "idProveedor";
			}
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtId.Text != "" && txtNombre.Text != "" && txtProveedor.Text != "" && txtCompra.Text != "" && txtVenta.Text != "" && txtMaximo.Text != "" && txtMinimo.Text != "")
				{
					if (_prod == null)
					{
						_prod = new ProductoDTO()
						{
							idProducto = Convert.ToInt32(txtId.Text),
							nombre = txtNombre.Text,
							idProveedor = Convert.ToInt32(cmbProveedores.SelectedValue),
							precioCompra = Convert.ToDouble(txtCompra.Text),
							precioVenta = Convert.ToDouble(txtVenta.Text),
							stockActual = Convert.ToInt32(txtActual.Text),
							stockMax = Convert.ToInt32(txtMaximo.Text),
							stockMin = Convert.ToInt32(txtMinimo.Text)
						};
						if (MessageBox.Show("¿Desea guardar cambios?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
						{
							if (_prodManager.ModificarProducto(_prod))
							{
								MessageBox.Show("Producto actualizado satisfactoriamente", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
							dgvProductos.DataSource = _prodManager.Productos.ToList();
							btnEliminar.Visible = true;
							txtActual.Clear();
							txtCompra.Clear();
							txtId.Clear();
							txtMaximo.Clear();
							txtMinimo.Clear();
							txtNombre.Clear();
							txtVenta.Clear();
							txtProveedor.Clear();
							txtNombre.ReadOnly = true;
							txtProveedor.ReadOnly = true;
							txtCompra.ReadOnly = true;
							txtVenta.ReadOnly = true;
							txtActual.ReadOnly = true;
							txtMaximo.ReadOnly = true;
							txtMinimo.ReadOnly = true;
							txtProveedor.Visible = true;
							cmbProveedores.ResetText();
							cmbProveedores.Visible = false;
							btnGuardar.Visible = false;
						}
						else
						{
							MessageBox.Show("Error al actualizar el producto", titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
				_prod = null;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtId.Text != "")
				{
					if (_prod == null)
					{
						_prod = new ProductoDTO();
						_prod.idProducto = Convert.ToInt32(txtId.Text);
						if (MessageBox.Show("¿Desea eliminar este producto?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
						{
							_prodManager.EliminarProducto(_prod);
							dgvProductos.DataSource = _prodManager.Productos.ToList();
							MessageBox.Show("Producto eliminado satisfactoriamente", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
							txtActual.Clear();
							txtCompra.Clear();
							txtId.Clear();
							txtMaximo.Clear();
							txtMinimo.Clear();
							txtNombre.Clear();
							txtVenta.Clear();
							txtProveedor.Clear();
							txtNombre.ReadOnly = true;
							txtProveedor.ReadOnly = true;
							txtCompra.ReadOnly = true;
							txtVenta.ReadOnly = true;
							txtActual.ReadOnly = true;
							txtMaximo.ReadOnly = true;
							txtMinimo.ReadOnly = true;
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: "+ex.Message, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cambiarDeUsuariioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Está seguro quq quiere cerrar sesión?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.Hide();
				Program.idUsuario = 0;
				Program.nombreUsuario = "";
				new Inicio().Show();
			}
		}

		private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Está seguro quq quiere cerrar sesión?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.Hide();
				Program.idUsuario = 0;
				Program.nombreUsuario = "";
				new Inicio().Show();
			}
		}
	}
}
