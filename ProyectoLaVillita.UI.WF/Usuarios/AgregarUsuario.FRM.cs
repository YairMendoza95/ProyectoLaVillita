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
using ProyectoLaVillita.UI.WF.Productos;
using ProyectoLaVillita.UI.WF.Proveedores;
using ProyectoLaVillita.UI.WF.Rentas;

namespace ProyectoLaVillita.UI.WF.Usuarios
{
    public partial class AgregarUsuario : Form
    {
        public string titulo = "Sistema de inventario \"La Villita\"";
        private UsuarioDTO _user;
        private UsuarioManager _userManager;
        public AgregarUsuario()
        {
            InitializeComponent();
            _userManager = new UsuarioManager();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (_user == null)
                {
                    _user = new UsuarioDTO()
                    {
                        nombreUsuario = txtUsuario.Text.ToString(),
                        contraseña = txtContraseña.Text.ToString()
                    };
                    if (!txtConfirmarContraseña.Text.Equals(txtContraseña.Text))
                    {
                        MessageBox.Show("Las contraseñas no coinciden", titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtContraseña.Clear();
                        txtContraseña.Focus();
                        txtConfirmarContraseña.Clear();
                    }
                    else
                    {
                        _userManager.InsertarUsuario(_user);
                        MessageBox.Show("Usuario agregado correctamente", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtConfirmarContraseña.Clear();
                        txtContraseña.Clear();
                        txtUsuario.Clear();
                        if (MessageBox.Show("¿Desea iniciar sesión con el nuevo usuario?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
							this.Hide();
							Program.idUsuario = 0;
							new Inicio().Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
	}
}
