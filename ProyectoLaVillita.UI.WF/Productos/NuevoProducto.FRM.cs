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
		private ProveedorDTO _pro = new ProveedorDTO();
        public string titulo = "Sistema de inventario \"La Villita\"";
        public NuevoProducto()
        {
            InitializeComponent();
            _prodManager = new ProductoManager();
            _provManager = new ProveedorManager();
            _ent = new EntradaDTO();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere salir?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int sta = 0;
            sta += _ent.cantidad;
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
			cmbProveedor.DisplayMember = "nombreProveedor";
			cmbProveedor.DataSource = datos;
			cmbProveedor.ValueMember = "idProveedor";
			//cmbProveedor.SelectedValue
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
	}
}
