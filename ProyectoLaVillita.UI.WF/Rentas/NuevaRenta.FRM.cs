using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using ProyectoLaVillita.BIZ;
using System.Threading.Tasks;
using System.Collections.Generic;
using ProyectoLaVillita.UI.WF.Usuarios;
using ProyectoLaVillita.UI.WF.Productos;
using ProyectoLaVillita.COMMON.Entidades;
using ProyectoLaVillita.UI.WF.Proveedores;

namespace ProyectoLaVillita.UI.WF.Rentas
{
    public partial class NuevaRenta : Form
    {
        public string titulo = "Sistema de inventario \"La Villita\"";
        private RentaDTO _renta;
        private RentaManager _rentaManager;
		private ProductoManager _prodManager;
		private ClienteManager _clienteManager;
		private ClienteDTO _cliente;
		private DetalleRentaDTO _dr;
		private DetalleRentaManager _drManager;
		private ProductoDTO _prod;
		double total = 0;
        public NuevaRenta()
        {
            InitializeComponent();
            _rentaManager = new RentaManager();
			_prodManager = new ProductoManager();
			_clienteManager = new ClienteManager();
			_drManager = new DetalleRentaManager();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
			if ((Convert.ToDouble(txtCantidad.Text) <= _prodManager.BuscarProductosPorId(Convert.ToInt32(cmbProductos.SelectedValue)).stockActual) &&
			   (_prodManager.BuscarProductosPorId(Convert.ToInt32(cmbProductos.SelectedValue)).stockActual >= _prodManager.BuscarProductosPorId(Convert.ToInt32(cmbProductos.SelectedValue)).stockMin) &&
			   (Convert.ToDouble(txtCantidad.Text) > 0))
			{
				int producto = Convert.ToInt32(cmbProductos.SelectedValue);
				int cantidad = Convert.ToInt32(txtCantidad.Text);
				double subtotal = cantidad * _prodManager.BuscarProductosPorId(Convert.ToInt32(cmbProductos.SelectedValue)).precioVenta;
				if (txtCantidad.Text != "")
				{
					dgvDetalleVenta.Rows.Add(producto, cantidad, subtotal);
					total += subtotal;
					txtTotal.Text = total.ToString();
				}
			}
			else
			{
				MessageBox.Show("No se puede asignar el producto", titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("¿Está seguro que quiere salir?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				Application.Exit();	
        }

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			int cliente = 0;
			if (rbtAgregar.Checked)
			{
				if (txtCliente.Text != "" && txtApPaterno.Text != "" && txtApMaterno.Text != "" && txtTelefono.Text != "")
				{
					_cliente = new ClienteDTO()
					{
						nombre = txtCliente.Text,
						apPaterno = txtApPaterno.Text,
						apMaterno = txtApMaterno.Text,
						telefono = txtTelefono.Text
					};
					_clienteManager.InsertarCliente(_cliente);
					cliente = _clienteManager.Clientes.Last().idCliente;
				}
			}
			else if (rbtBuscar.Checked)
			{
				cliente = Convert.ToInt32(cmbCliente.SelectedValue);
			}
			if (txtCantidad.Text != "" && dateTimePicker1.Text != "" && dateTimePicker2.Text != "")
			{
				_renta = new RentaDTO()
				{
					idUsuario = Program.usuario,
					idTipoUsuario = Program.idTipoUsuario,
					idCliente = cliente,
					total = Convert.ToDouble(txtTotal.Text),
					fechaInicio = dateTimePicker1.Value.ToString(),
					fechaVencimiento = dateTimePicker2.Value.ToString(),
					notas = txtNotas.Text
				};
				if (_rentaManager.InsertarRenta(_renta))
				{
					for (int i = 0; i < dgvDetalleVenta.RowCount - 1; i++)
					{
						try
						{
							_dr = new DetalleRentaDTO()
							{
								idRenta = _rentaManager.Rentas.Last().idRenta,
								idProducto = Convert.ToInt32(cmbProductos.SelectedValue),
								idProveedor = _prodManager.BuscarProductosPorId(Convert.ToInt32(cmbProductos.SelectedValue)).idProveedor,
								cantidad = Convert.ToInt32(dgvDetalleVenta.Rows[i].Cells[1].Value),
								total = Convert.ToDouble(dgvDetalleVenta.Rows[i].Cells[2].Value),
							};
							if (_drManager.InsertarDetalleRenta(_dr))
							{
								int stock = _prodManager.BuscarProductosPorId(Convert.ToInt32(dgvDetalleVenta.Rows[i].Cells[0].Value)).stockActual;

								stock -= Convert.ToInt32(dgvDetalleVenta.Rows[i].Cells[2].Value);

								if (_prod == null)
								{
									_prod = new ProductoDTO()
									{
										idProducto = Convert.ToInt32(dgvDetalleVenta.Rows[i].Cells[0].Value),

										nombre = _prodManager.BuscarProductosPorId(Convert.ToInt32(dgvDetalleVenta.Rows[i].Cells[0].Value)).nombre,

										idProveedor = _prodManager.BuscarProductosPorId(Convert.ToInt32(dgvDetalleVenta.Rows[i].Cells[0].Value)).idProveedor,

										idTipoProducto = _prodManager.BuscarProductosPorId(Convert.ToInt32(dgvDetalleVenta.Rows[i].Cells[0].Value)).idTipoProducto,

										precioVenta = _prodManager.BuscarProductosPorId(Convert.ToInt32(dgvDetalleVenta.Rows[i].Cells[0].Value)).precioVenta,

										precioCompra = _prodManager.BuscarProductosPorId(Convert.ToInt32(dgvDetalleVenta.Rows[i].Cells[0].Value)).precioCompra,

										stockActual = stock,

										stockMax = _prodManager.BuscarProductosPorId(Convert.ToInt32(dgvDetalleVenta.Rows[i].Cells[0].Value)).stockMax,

										stockMin = _prodManager.BuscarProductosPorId(Convert.ToInt32(dgvDetalleVenta.Rows[i].Cells[0].Value)).stockMin
									};
									_prodManager.ModificarProducto(_prod);
									cmbProductos.ResetText();
									txtCantidad.Clear();
									txtTotal.Clear();
									txtNotas.Clear();
									cmbProductos.Focus();
								}
							}
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error: " + ex.Message, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
					}
					MessageBox.Show("Renta registrada", titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					MessageBox.Show("Renta no registrada", titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
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

		private void registroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new NuevoProducto().Show();
			this.Hide();
		}

		private void inventarioToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			new InventarioVenta().Show();
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

		private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Venta().Show();
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

		private void NuevaRenta_Load(object sender, EventArgs e)
		{
			if (Program.idTipoUsuario != 1)
			{
				usuariosToolStripMenuItem.Visible = false;
				cerrarSesiónToolStripMenuItem.Visible = true;
				entradasToolStripMenuItem.Visible = false;
				proveedoresToolStripMenuItem.Visible = false;
				productosToolStripMenuItem.Visible = false;
				inventarioToolStripMenuItem1.Visible = false;
				modificarRentaToolStripMenuItem.Visible = false;
			}
			else
			{
				usuariosToolStripMenuItem.Visible = true;
				cerrarSesiónToolStripMenuItem.Visible = false;
			}
			List<ProductoDTO> productos = _prodManager.Productos.ToList();
			List<ProductoDTO> alquiler = new List<ProductoDTO>();
			for (int i = 0; i < productos.Count; i++)
			{
				if (productos[i].idTipoProducto == 1)
					alquiler.Add(productos[i]);
			}
			if (alquiler.Count > 0)
			{
				cmbProductos.DataSource = alquiler;
				cmbProductos.DisplayMember = "nombre";
				cmbProductos.ValueMember = "idProducto";
			}
			List<ClienteDTO> clientes = _clienteManager.Clientes.ToList();
			if (clientes.Count > 0)
			{
				cmbCliente.DataSource = clientes;
				cmbCliente.DisplayMember = "nombre";
				cmbCliente.ValueMember = "idCliente";
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
			if (MessageBox.Show("¿Está seguro quq quiere cerrar sesión?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.Hide();
				Program.idTipoUsuario = 0;
				Program.usuario = 0;
				new Inicio().Show();
			}
		}

		private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void rbtBuscar_CheckedChanged(object sender, EventArgs e)
		{
			gpbBuscar.Visible = true;
			gpbAgregar.Visible = false;
		}

		private void rbtAgregar_CheckedChanged(object sender, EventArgs e)
		{
			gpbAgregar.Visible = true;
			gpbBuscar.Visible = false;
		}
	}
}
