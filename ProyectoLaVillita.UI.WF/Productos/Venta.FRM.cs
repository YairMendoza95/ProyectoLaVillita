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
				Program.idUsuario = 0;
				new Inicio().Show();
			}
		}

		private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Está seguro quq quiere cerrar sesión?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.Hide();
				Program.idUsuario = 0;
				new Inicio().Show();
			}
		}

		private void cmbProductos_SelectionChangeCommitted(object sender, EventArgs e)
		{
			txtProveedor.Text = _provManager.BuscarProveedorPorId(_prodManager.BuscarProductosPorId(Convert.ToInt32(cmbProductos.SelectedValue)).idProveedor).nombreProveedor;
		}

		private void btnAgregar_Click(object sender, EventArgs e)
        {
			string producto = _prodManager.BuscarProductosPorId(Convert.ToInt32(cmbProductos.SelectedValue)).nombre;
			string proveedor = _provManager.BuscarProveedorPorId(_prodManager.BuscarProductosPorId(Convert.ToInt32(cmbProductos.SelectedValue)).idProveedor).nombreProveedor;
			double subtotal = _prodManager.BuscarProductosPorId(Convert.ToInt32(cmbProductos.SelectedValue)).precioVenta * Convert.ToDouble(txtCantidad.Text);
			if (txtProveedor.Text != "" && txtCantidad.Text != "")
			{
				dgvDetalleVenta.Rows.Add(producto, proveedor, txtCantidad.Text, subtotal);
				for (int i = 0; i < dgvDetalleVenta.Rows.Count - 1; i++)
				{
					total += subtotal;
				} 
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
					idUsuario = Program.idUsuario,
					fechaVenta = DateTime.Today,
					total = total,
					notas = txtNotas.Text,
				};
                _ventaManager.InsertarVenta(_venta);


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
		private void txtSubtotal_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
