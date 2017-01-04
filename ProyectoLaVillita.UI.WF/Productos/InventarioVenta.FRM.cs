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
		private ProveedorManager _provManager;
		private ProductoDTO _prod;
		public string titulo = "Sistema de inventario \"La VIllita\"";
		List<ProductoDTO> abarrotes = new List<ProductoDTO>();
		private TipoProductoManager _tuManager;
		public InventarioVenta()
		{
			InitializeComponent();
			_prodManager = new ProductoManager();
			_provManager = new ProveedorManager();
			_tuManager = new TipoProductoManager();
		}

		private void InventarioVenta_Load(object sender, EventArgs e)
		{
			if (Program.idTipoUsuario != 1) // si idUsuario es diferente de 1 (administrador) oculta el menu de usuarios y hace visible el boton de Cerrar sesión
			{
				usuariosToolStripMenuItem.Visible = false;
				cerrarSesiónToolStripMenuItem.Visible = true;
				productosToolStripMenuItem.Visible = false;
				proveedoresToolStripMenuItem.Visible = false;
				entradasToolStripMenuItem.Visible = false;
				inventarioToolStripMenuItem1.Visible = false;
				modificarRentaToolStripMenuItem.Visible = false;

			}
			else // si idUsuario es igual a 1 oculta el boton de cerrar sesión y hace visible el menu de usuarios
			{
				usuariosToolStripMenuItem.Visible = true;
				cerrarSesiónToolStripMenuItem.Visible = false;
			}
			// se crea una variable la cual almacena una lista con todos los registros de la tabla productos en la base de datos
			List<ProductoDTO> productos = _prodManager.Productos.ToList();
			for (int i = 0; i < productos.Count; i++)
			{
				if (productos[i].idTipoProducto == 1)
					abarrotes.Add(productos[i]);
			}
			// si la cantidad de registro en la tabla es mayor a 0 
			if (abarrotes.Count > 0)
			{
				// se asigna la fuente de donde se van a tomar los datos para llenar la tabla
				dgvProductos.DataSource = abarrotes;
				// se asignan las columnas con su nombre y el respectivo campo con el cual va a ser llenado
				dgvProductos.Columns[0].HeaderText = "Id";
				dgvProductos.Columns[0].DataPropertyName = "idProducto";
				dgvProductos.Columns[1].HeaderText = "Nombre";
				dgvProductos.Columns[1].DataPropertyName = "nombre";
				dgvProductos.Columns[2].HeaderText = "Proveedor";
				dgvProductos.Columns[2].DataPropertyName = "idProveedor";
				dgvProductos.Columns[3].HeaderText = "Tipo de producto";
				dgvProductos.Columns[3].DataPropertyName = "idTipoProducto";
				dgvProductos.Columns[4].HeaderText = "Precio Compra";
				dgvProductos.Columns[4].DataPropertyName = "precioCompra";
				dgvProductos.Columns[5].HeaderText = "Precio Venta";
				dgvProductos.Columns[5].DataPropertyName = "precioVenta";
				dgvProductos.Columns[6].HeaderText = "Stock Actual";
				dgvProductos.Columns[6].DataPropertyName = "stockActual";
				dgvProductos.Columns[7].HeaderText = "Stock Máximo";
				dgvProductos.Columns[7].DataPropertyName = "stockMax";
				dgvProductos.Columns[8].HeaderText = "Stock Mínimo";
				dgvProductos.Columns[8].DataPropertyName = "stockMin";
				label11.Visible = false;
			}
			else
				// de lo contrario muestra una etiqueta de advertencia
				label11.Visible = true;
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
			// Cuando se selecciona una fia en la tabla los cuadros de textos se llenan con su información
			txtId.Text = dgvProductos.SelectedRows[0].Cells[0].Value.ToString();
			txtNombre.Text = dgvProductos.SelectedRows[0].Cells[1].Value.ToString();
			txtProveedor.Text = _provManager.BuscarProveedorPorId(Convert.ToInt32(dgvProductos.SelectedRows[0].Cells[2].Value)).nombreProveedor;
			txtTipo.Text = _tuManager.BuscarTipoPorId(Convert.ToInt32(dgvProductos.SelectedRows[0].Cells[3].Value)).nombre;
			txtCompra.Text = dgvProductos.SelectedRows[0].Cells[4].Value.ToString();
			txtVenta.Text = dgvProductos.SelectedRows[0].Cells[5].Value.ToString();
			txtActual.Text = dgvProductos.SelectedRows[0].Cells[6].Value.ToString();
			txtMaximo.Text = dgvProductos.SelectedRows[0].Cells[7].Value.ToString();
			txtMinimo.Text = dgvProductos.SelectedRows[0].Cells[8].Value.ToString();
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			// se crea una variable tipo lista que almacene los registros de la tabla proveedores
			List<ProveedorDTO> proveedores = _provManager.Proveedores.ToList();
			txtProveedor.Visible = false;
			// se ocultan los botones
			btnModificar.Visible = false;
			btnGuardar.Visible = true;
			txtNombre.ReadOnly = false;
			txtProveedor.ReadOnly = false;
			txtVenta.ReadOnly = false;
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
			if ((Convert.ToDouble(txtVenta.Text) > Convert.ToDouble(txtCompra.Text)) && (Convert.ToInt32(txtMaximo.Text) > Convert.ToInt32(txtMinimo.Text)))
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
								dgvProductos.DataSource = abarrotes;
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
								txtVenta.ReadOnly = true;
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
				Program.idTipoUsuario = 0;
				Program.usuario = 0;
				new Inicio().Show();
			}
		}

		private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Cierre de sesión si el boton presionado en el cuadro de dialogo es OK se cierra la ventana actual la variable idUsuario se regresa a 0 y se muestra el formulario del login
			if (MessageBox.Show("¿Está seguro quq quiere cerrar sesión?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.Hide();
				Program.idTipoUsuario = 0;
				Program.usuario = 0;
				new Inicio().Show();
			}
		}

		private void txtActual_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsControl(e.KeyChar) || Char.IsControl(e.KeyChar))
				e.Handled = false;
			else
				e.Handled = true;
		}

		private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Venta().Show();
			this.Hide();
		}

		private void btnPedidos_Click(object sender, EventArgs e)
		{
			new ProductoPedir().Show();
			this.Hide();
		}
	}
}
