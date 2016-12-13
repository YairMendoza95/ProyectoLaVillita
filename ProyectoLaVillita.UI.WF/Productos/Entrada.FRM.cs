using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoLaVillita.COMMON.Entidades;
using ProyectoLaVillita.BIZ;
using ProyectoLaVillita.UI.WF.Proveedores;
using ProyectoLaVillita.UI.WF.Rentas;
using ProyectoLaVillita.UI.WF.Usuarios;
using DevComponents.DotNetBar;

namespace ProyectoLaVillita.UI.WF.Productos
{
    public partial class Entrada : Form
    {
        private EntradaDTO _ent;
        private ProductoManager _prodManager;
        private ProveedorManager _provManager;
        private EntradaManager _entManager;
		private ProductoDTO _prod;
        public string titulo = "Sistema de inventario \"La VIllita\"";
        public Entrada()
        {
            InitializeComponent();
            _prodManager = new ProductoManager();
            _provManager = new ProveedorManager();
            _entManager = new EntradaManager();
        }

        private void Entrada_Load(object sender, EventArgs e)
        {
			if (Program.idTipoUsuario != 1)
			{
				usuariosToolStripMenuItem.Visible = false;
				cerrarSesiónToolStripMenuItem.Visible = true;
				entradasToolStripMenuItem.Visible = false;
				productosToolStripMenuItem.Visible = false;
				proveedoresToolStripMenuItem.Visible = false;
				inventarioToolStripMenuItem1.Visible = false;
				modificarRentaToolStripMenuItem.Visible = false;
			}
			else
			{
				usuariosToolStripMenuItem.Visible = true;
				cerrarSesiónToolStripMenuItem.Visible = false;
			}
			List<ProductoDTO> productos = _prodManager.Productos.ToList();
			if (productos.Count > 0)
			{
				cmbProductos.DataSource = productos;
				cmbProductos.DisplayMember = "nombre";
				cmbProductos.ValueMember = "idProducto";
			}
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere salir?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
			try
            {
				if (txtProveedor.Text != "" && txtCantidad.Text != "" && txtTotal.Text != "")
				{
					if (_ent == null)
					{
						_ent = new EntradaDTO()
						{
							idProducto = Convert.ToInt32(cmbProductos.SelectedValue),
							idProveedor = Convert.ToInt32(_prodManager.BuscarProductosPorId(Convert.ToInt32(cmbProductos.SelectedValue)).idProveedor),
							fechaEntrada = dtpFecheEntrada.Text,
							cantidad = Convert.ToInt32(txtCantidad.Text),
							montoPagar = Convert.ToInt32(txtTotal.Text)
						};

						if (_entManager.InsertarEntrada(_ent))
						{
							MessageBox.Show("Entrada registrada satisfactariamente", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
							int stock = _prodManager.BuscarProductosPorId(Convert.ToInt32(cmbProductos.SelectedValue)).stockActual;
							stock += Convert.ToInt32(txtCantidad.Text);
							double compra = Convert.ToDouble(txtTotal.Text) / Convert.ToInt32(txtCantidad.Text);
							if (_prod == null)
							{
								_prod = new ProductoDTO()
								{
									idProducto = Convert.ToInt32(cmbProductos.SelectedValue),
									nombre = _prodManager.BuscarProductosPorId(Convert.ToInt32(cmbProductos.SelectedValue)).nombre,
									idProveedor = _prodManager.BuscarProductosPorId(Convert.ToInt32(cmbProductos.SelectedValue)).idProveedor,
									idTipoProducto=_prodManager.BuscarProductosPorId(Convert.ToInt32(cmbProductos.SelectedValue)).idTipoProducto,
									precioVenta = _prodManager.BuscarProductosPorId(Convert.ToInt32(cmbProductos.SelectedValue)).precioVenta,
									precioCompra = compra,
									stockActual = stock,
									stockMax = _prodManager.BuscarProductosPorId(Convert.ToInt32(cmbProductos.SelectedValue)).stockMax,
									stockMin = _prodManager.BuscarProductosPorId(Convert.ToInt32(cmbProductos.SelectedValue)).stockMin
								};
								_prodManager.ModificarProducto(_prod);
								cmbProductos.ResetText();
								txtProveedor.Clear();
								dtpFecheEntrada.ResetText();
								txtCantidad.Clear();
								txtTotal.Clear();
								cmbProductos.Focus();
								_prod = null;
							}
							_ent = null;
						}
						else
						{
							MessageBox.Show("Entrada no registrada", titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

						}
					}
				}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cambiarDeUsuariioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere cerrar sesión?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                new Inicio().Show();
                this.Hide();
            }
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

		private void registroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new NuevoProducto().Show();
			this.Hide();
		}

		private void modificarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new ModificarProveedor().Show();
			this.Hide();
		}

		private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Venta().Show();
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

		private void cambiarDeUsuariioToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			if(MessageBox.Show("¿Está seguro quq quiere cerrar sesión?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
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

		private void cmbProductos_SelectionChangeCommitted(object sender, EventArgs e)
		{
			txtProveedor.Text = _provManager.BuscarProveedorPorId(_prodManager.BuscarProductosPorId(Convert.ToInt32(cmbProductos.SelectedValue)).idProveedor).nombreProveedor.ToString();
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
		bool bandera = true;
		private void txtTotal_KeyPress_1(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != 46)
			{
				e.Handled = true;
			}
			else if (e.KeyChar == 46)
			{
				if (bandera)
				{
					bandera = false;
				}
				else
				{
					e.Handled = true;
				}
			}
		}
	}
}
