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
using ProyectoLaVillita.UI.WF.Productos;
using ProyectoLaVillita.UI.WF.Proveedores;
using ProyectoLaVillita.UI.WF.Rentas;
using ProyectoLaVillita.COMMON.Entidades;

namespace ProyectoLaVillita.UI.WF.Usuarios
{
    public partial class ModificarUsuario : Form
    {
        public string titulo = "Sistema de inventario \"La Villita\"";
        private UsuarioDTO _user;
        private UsuarioManager _userManager;
		private TipoUsuarioManager _tuManager;
        public ModificarUsuario()
        {
            InitializeComponent();
            _userManager = new UsuarioManager();
			_tuManager = new TipoUsuarioManager();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
			bool bandera;
			do
			{
				try
				{
					if (txtConfirmarContraseña.Text != "" && txtContraseña.Text != "" && txtNombre.Text != "" && txtId.Text != "")
					{
						if (_user == null)
						{
							_user = new UsuarioDTO()
							{
								idUsuario = Convert.ToInt32(txtId.Text),
								nombreUsuario = txtNombre.Text,
								contraseña = txtContraseña.Text,
								idTipoUsuario = Convert.ToInt32(cmbTipos.SelectedValue)
							};
							if (!txtConfirmarContraseña.Text.Equals(txtContraseña.Text))
							{
								MessageBox.Show("Las contraseña no coinciden", titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							else if (MessageBox.Show("¿Está seguro que quiere eliminar el usuario seleccionado?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
							{
								_userManager.ModificarUsuario(_user);
								txtId.Clear();
								txtNombre.Clear();
								txtContraseña.Clear();
								dgvUsuarios.ClearSelection();
								dgvUsuarios.DataSource = _userManager.Usuarios.ToList();
								btnEliminar.Visible = true;
								txtConfirmarContraseña.Clear();
								txtConfirmarContraseña.Visible = false;
								label6.Visible = false;
								cmbTipos.Visible = false;
								btnSalir.Visible = true;
								btnGuardar.Visible = false;
								btnModificar.Visible = true;
							}
						}
					}
					bandera = true;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
					bandera = false;
				}
			} while (!bandera);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere salir?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
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

		private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new AgregarUsuario().Show();
			this.Hide();
		}

		private void ModificarUsuario_Load(object sender, EventArgs e)
		{
			List<UsuarioDTO> usuarios = _userManager.Usuarios.ToList();
			if (usuarios.Count > 0)
			{
				dgvUsuarios.DataSource = usuarios;
				dgvUsuarios.Columns[0].HeaderText = "Id";
				dgvUsuarios.Columns[1].HeaderText = "Nombre de usuario";
				dgvUsuarios.Columns[2].HeaderText = "Contraseña";
				dgvUsuarios.Columns[3].HeaderText = "Tipo de usuario";
			}
			else
			{
				StringBuilder strb = new StringBuilder();
				strb.Append("No existen registros");
			}
			List<TipoUsuarioDTO> tipos = _tuManager.TiposUsuario.ToList(); 
			if(tipos.Count>0)
			{
				cmbTipos.DataSource = tipos;
				cmbTipos.DisplayMember = "nombre";
				cmbTipos.ValueMember = "idTipoUsuario";
			}
		}

		private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtId.Text = dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString();
			txtNombre.Text = dgvUsuarios.SelectedRows[0].Cells[1].Value.ToString();
			txtContraseña.Text = dgvUsuarios.SelectedRows[0].Cells[2].Value.ToString();
			txtTipo.Text = _tuManager.BuscarTipoPorId(Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells[3].Value)).nombre;
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			btnGuardar.Visible = true;
			btnEliminar.Visible = false;
			txtConfirmarContraseña.Visible = true;
			label6.Visible = true;
			btnSalir.Visible = false;
			btnModificar.Visible = false;
			txtConfirmarContraseña.ReadOnly = false; 
			txtTipo.Visible = false;
			cmbTipos.Visible = true;
			txtContraseña.ReadOnly = false;
			txtNombre.ReadOnly = false;
			txtConfirmarContraseña.Text = dgvUsuarios.SelectedRows[0].Cells[2].Value.ToString();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			try
			{
				if (_user == null)
				{
					_user = new UsuarioDTO();
					_user.idUsuario = Convert.ToInt32(txtId.Text);
					if (MessageBox.Show("¿Está seguro de eliminar este proveedor?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
					{
						_userManager.EliminarUsuario(_user);
						txtId.Clear();
						txtNombre.Clear();
						txtContraseña.Clear();
						txtTipo.Clear();
						dgvUsuarios.DataSource = _userManager.Usuarios.ToList();
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
			if (MessageBox.Show("¿Está seguro quq quiere cerrar sesión?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.Hide();
				Program.idTipoUsuario = 0;
				Program.usuario = 0;
				new Inicio().Show();
			}
		}
	}
}
