using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoLaVillita.UI.WF.Productos;
using ProyectoLaVillita.UI.WF.Rentas;
using ProyectoLaVillita.UI.WF.Usuarios;
using ProyectoLaVillita.BIZ;
using ProyectoLaVillita.COMMON.Entidades;

namespace ProyectoLaVillita.UI.WF.Proveedores
{
    public partial class NuevoProveedor : Form
    {
        private ProveedorDTO _prov;
        private ProveedorManager _provManager;
        public string titulo = "Sistema de inventario \"La Villita\"";
        public string numeros = "1234567890";
        public NuevoProveedor()
        {
            InitializeComponent();
            _provManager = new ProveedorManager();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere salir?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_prov == null && txtTelefono.Text.Length == 10)
                {
                    _prov = new ProveedorDTO()
                    {
                        nombreProveedor = txtNombre.Text,
                        telefono = txtTelefono.Text
                    };
                    if (_provManager.InsertarProveedor(_prov))
                        MessageBox.Show("Proveedor registrado corectamente", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Proveedor no registrado", titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtNombre.Clear();
                    txtTelefono.Clear();
                }
                else if (txtTelefono.Text.Length > 0 || txtTelefono.Text.Length < 0)
                {
                    MessageBox.Show("El teléfono debe contener 10 digitos", titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTelefono.Clear();
                    txtTelefono.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
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

		private void NuevoProveedor_Load(object sender, EventArgs e)
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
	}
}
