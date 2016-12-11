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
    public partial class NuevoProducto : Form
    {
        private ProductoDTO _prod;
        private ProductoManager _prodManager;
        private ProveedorManager _provManager;
        private EntradaDTO _ent;
		private ProveedorDTO _pro;
		private TipoProductoManager _tipoManager;
        public string titulo = "Sistema de inventario \"La Villita\"";
        public NuevoProducto()
        {
            InitializeComponent();
            _prodManager = new ProductoManager();
            _provManager = new ProveedorManager();
            _ent = new EntradaDTO();
			_pro = new ProveedorDTO();
			_tipoManager = new TipoProductoManager();
		}

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere salir?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int sta = 0;
            try
            {
				if (txtCompra.Text != "" && txtNombre.Text != "" && txtVenta.Text != "" && txtMinimo.Text != "" && txtMaximo.Text != "")
				{
					if (_prod == null)
					{
						_prod = new ProductoDTO()
						{
							nombre = txtNombre.Text,
							idProveedor = Convert.ToInt32(cmbProveedor.SelectedValue),
							idTipoProducto = Convert.ToInt32(cmbTipo.SelectedValue),
							precioCompra = Convert.ToDouble(txtCompra.Text),
							precioVenta = Convert.ToDouble(txtVenta.Text),
							stockActual = sta,
							stockMax = Convert.ToInt32(txtMaximo.Text),
							stockMin = Convert.ToInt32(txtMinimo.Text)
						};
						if (_prodManager.AgregarProducto(_prod))
						{
							txtNombre.Clear();
							txtCompra.Clear();
							cmbProveedor.ResetText();
							cmbTipo.ResetText();
							txtMaximo.Clear();
							txtVenta.Clear();
							txtMinimo.Clear();
							MessageBox.Show("Producto registrado exitosamente", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
							MessageBox.Show("Producto no registrado", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
                
            }
            catch (Exception ex)
            {
				MessageBox.Show("Error: " + ex.Message, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
        }

		private void NuevoProducto_Load(object sender, EventArgs e)
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
			var datos = _provManager.Proveedores.ToList();
			if (datos.Count > 0)
			{
				cmbProveedor.DataSource = datos;
				cmbProveedor.DisplayMember = "nombreProveedor";
				cmbProveedor.ValueMember = "idProveedor";
			}
			List<TipoProductoDTO> tipo = _tipoManager.Tipos.ToList();
			if(datos.Count>0)
			{
				cmbTipo.DataSource = tipo;
				cmbTipo.DisplayMember = "nombre";
				cmbTipo.ValueMember = "idTipoProducto";
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

		private void modificarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new InventarioVenta().Show();
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

		private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Está seguro quq quiere cerrar sesión?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.Hide();
				Program.idUsuario = 0;
				new Inicio().Show();
			}
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
		bool bandera = true;
		private void txtCompra_KeyPress(object sender, KeyPressEventArgs e)
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

		private void txtMinimo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(Char.IsDigit(e.KeyChar)&&Char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}
	}
}
