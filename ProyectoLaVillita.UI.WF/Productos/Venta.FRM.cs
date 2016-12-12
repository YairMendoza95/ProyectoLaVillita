using System;
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
using ProyectoLaVillita.UI.WF.Proveedores;
using ProyectoLaVillita.UI.WF.Rentas;
using ProyectoLaVillita.UI.WF.Usuarios;

namespace ProyectoLaVillita.UI.WF.Productos
{
    public partial class Venta : Form
    {
        private ProductoDTO _prod;
        private ProductoManager _prodManager;
        private DetalleVentaManger _dvManager;
        private VentaDTO _venta;
        private VentaManager _ventaManager;
		private ProveedorManager _provManager;
		double total = 0;
		private DetalleVentaDTO _dv;
        public string titulo="Sistema de inventario \"La Villita\"";
        public Venta()
        {
            InitializeComponent();
            _prod = new ProductoDTO();
            _prodManager = new ProductoManager();
            _dvManager = new DetalleVentaManger();
            _ventaManager = new VentaManager();
			_provManager = new ProveedorManager();
        }

		private void Venta_Load(object sender, EventArgs e)
		{
			if (Program.idTipoUsuario != 1)
			{
				usuariosToolStripMenuItem.Visible = false;
				cerrarSesiónToolStripMenuItem.Visible = true;
				entradasToolStripMenuItem.Visible = false;
				proveedoresToolStripMenuItem.Visible = false;
			}
			else
			{
				usuariosToolStripMenuItem.Visible = true;
				cerrarSesiónToolStripMenuItem.Visible = false;
			}
			var datos = _prodManager.Productos.ToList();
			List<ProductoDTO> abarrotes = new List<ProductoDTO>();
			for (int i = 0; i < datos.Count; i++)
			{
				if (datos[i].idTipoProducto == 2)
					abarrotes.Add(datos[i]);
			}
			if (abarrotes.Count > 0)
			{
				cmbProductos.DataSource = abarrotes;
				cmbProductos.DisplayMember = "nombre";
				cmbProductos.ValueMember = "idProducto";
			}
		}

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("¿Está seguro que quiere salir?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
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

		private void cmbProductos_SelectionChangeCommitted(object sender, EventArgs e)
		{
			txtProveedor.Text = _provManager.BuscarProveedorPorId(_prodManager.BuscarProductosPorId(Convert.ToInt32(cmbProductos.SelectedValue)).idProveedor).nombreProveedor;
		}

		private void btnAgregar_Click(object sender, EventArgs e)
        {
			int producto = Convert.ToInt32(cmbProductos.SelectedValue);
			int proveedor = _prodManager.BuscarProductosPorId(Convert.ToInt32(cmbProductos.SelectedValue)).idProveedor;
			double subtotal = _prodManager.BuscarProductosPorId(Convert.ToInt32(cmbProductos.SelectedValue)).precioVenta * Convert.ToDouble(txtCantidad.Text);
			if (txtProveedor.Text != "" && txtCantidad.Text != "")
			{
				dgvDetalleVenta.Rows.Add(producto, proveedor, txtCantidad.Text, subtotal);
				total += subtotal;
				txtSubtotal.Text = total.ToString();
			}			
			txtCantidad.Clear();
			txtProveedor.Clear();
			//txtNotas.Clear();
			cmbProductos.ResetText();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
				_venta = new VentaDTO()
				{
					idUsuario = Program.usuario,
					fechaVenta = DateTime.Today.ToString(),
					total = total,
					notas = txtNotas.Text,
				};
                if(_ventaManager.InsertarVenta(_venta))
				{
					for (int i = 0; i < dgvDetalleVenta.RowCount; i++)
					{
						try
						{
							_dv = new DetalleVentaDTO()
							{
								idVenta = _venta.idVenta,
								idProducto = Convert.ToInt32(dgvDetalleVenta.Rows[i].Cells[0].Value.ToString()),
								idProveedor = _prodManager.BuscarProductosPorId(Convert.ToInt32(dgvDetalleVenta.Rows[i].Cells[0].Value)).idProveedor,
								cantidad = Convert.ToDouble(dgvDetalleVenta.Rows[i].Cells[2].Value),
								total = Convert.ToDouble(dgvDetalleVenta.Rows[i].Cells[3].Value)
							};
							if(_dvManager.InsertarDetalleVenta(_dv))
							{
								int stock = _prodManager.BuscarProductoPorNombre(dgvDetalleVenta.Rows[i].Cells[0].Value.ToString()).stockActual;
								stock -= Convert.ToInt32(dgvDetalleVenta.Rows[i].Cells[2]);
								if (_prod == null)
								{
									_prod = new ProductoDTO()
									{
										idProducto = Convert.ToInt32(dgvDetalleVenta.Rows[i].Cells[0].Value),
										nombre = dgvDetalleVenta.Rows[i].Cells[0].Value.ToString(),
										idProveedor = _prodManager.BuscarProductoPorNombre(dgvDetalleVenta.Rows[i].Cells[0].Value.ToString()).idProveedor,
										idTipoProducto = _prodManager.BuscarProductoPorNombre(dgvDetalleVenta.Rows[i].Cells[0].Value.ToString()).idTipoProducto,
										precioVenta = _prodManager.BuscarProductoPorNombre(dgvDetalleVenta.Rows[i].Cells[0].Value.ToString()).precioVenta,
										precioCompra = _prodManager.BuscarProductoPorNombre(dgvDetalleVenta.Rows[i].Cells[0].Value.ToString()).precioCompra,
										stockActual = stock,
										stockMax = _prodManager.BuscarProductoPorNombre(dgvDetalleVenta.Rows[i].Cells[0].Value.ToString()).stockMax,
										stockMin = _prodManager.BuscarProductoPorNombre(dgvDetalleVenta.Rows[i].Cells[0].Value.ToString()).stockMin
									};
									_prodManager.ModificarProducto(_prod);
									cmbProductos.ResetText();
									txtProveedor.Clear();
									txtCantidad.Clear();
									txtSubtotal.Clear();
									txtNotas.Clear();
									cmbProductos.Focus();
								}
							}

						}
						catch (Exception)
						{

							throw;
						}
					}
				}

            }
            catch(Exception)
            {
                throw;
            }
        }

		private void dgvDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 4)
			{
				dgvDetalleVenta.Rows.Remove(dgvDetalleVenta.CurrentRow);
			}
		}

		public void GuardarDetalleVenta(int idProducto, int idVenta, int idProveedor, double cantidad, double subtotal)
		{
			_dv = new DetalleVentaDTO()
			{
				idProducto = idProducto,
				idVenta = idVenta,
				idProveedor = idProveedor,
				cantidad = cantidad,
				total = subtotal
			};
			_dvManager.InsertarDetalleVenta(_dv);
		}
	}
}
