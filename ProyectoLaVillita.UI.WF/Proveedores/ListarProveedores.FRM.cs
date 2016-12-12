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
using ProyectoLaVillita.COMMON.Entidades;
using ProyectoLaVillita.BIZ;

namespace ProyectoLaVillita.UI.WF.Proveedores
{
    public partial class ModificarProveedor : Form
    {
        public string titulo = "Sistema de inventario \"La Villita\"";
        private ProveedorDTO _prov;
        private ProveedorManager _provManager;

        public ModificarProveedor()
        {
            InitializeComponent();
            _provManager = new ProveedorManager();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere salir?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
			//crear un nuevo proveedor
			//llenarlo con los datos de las cajas (la id_proveedor puede ser solo lectura o no visible
			//mandas la modificación
			//vacias las cajas


			//solo hacerlo si las cajas estan llenas

			if (txtId.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "")
			{
				if (_prov == null)
				{
					_prov = new ProveedorDTO()
					{
						idProveedor = Convert.ToInt32(txtId.Text),
						nombreProveedor = txtNombre.Text,
						telefono = txtTelefono.Text
					};
					if(MessageBox.Show("¿Está seguro que quiere modificar este registro?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
					{
						_provManager.ModificarProveedor(_prov);
						txtId.Clear();
						txtNombre.Clear();
						txtTelefono.Clear();
						dgvProveedor.ClearSelection();
						dgvProveedor.DataSource = _provManager.Proveedores.ToList();
						btnEliminar.Visible = true;
					}
				}
			}
        }

        private void ModificarProveedor_Load(object sender, EventArgs e)
		{
			if (Program.idTipoUsuario != 1)
			{
				usuariosToolStripMenuItem.Visible = false;
				cerrarSesiónToolStripMenuItem.Visible = true;
			}
			else
			{
				usuariosToolStripMenuItem.Visible = true;
				cerrarSesiónToolStripMenuItem.Visible = false;
			}
			List<ProveedorDTO> datos = _provManager.Proveedores.ToList();
			if (datos.Count > 0)
			{
				dgvProveedor.DataSource = datos;
				dgvProveedor.Columns[0].HeaderText = "Id";
				dgvProveedor.Columns[1].HeaderText = "Nombre del proveedor";
				dgvProveedor.Columns[2].HeaderText = "Teléfono";
			}
			else
			{
				StringBuilder strb = new StringBuilder();
				strb.Append("No existen registros disponibles");
				//lbl
			}
			btnGuardar.Visible = false;
        }

		private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//tomar los valores y mandarlos a las cajas de texto
			txtId.Text = dgvProveedor.SelectedRows[0].Cells[0].Value.ToString();
			txtNombre.Text = dgvProveedor.SelectedRows[0].Cells[1].Value.ToString();
			txtTelefono.Text = dgvProveedor.SelectedRows[0].Cells[2].Value.ToString();
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			txtNombre.ReadOnly = false;
			txtTelefono.ReadOnly = false;
			btnGuardar.Visible = true;
			btnEliminar.Visible = false;
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (_prov == null)
			{
				_prov = new ProveedorDTO();
				_prov.idProveedor = Convert.ToInt32(txtId.Text);
				if (MessageBox.Show("¿Está seguro de eliminar este proveedor?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					_provManager.EliminarProveedor(_prov);
					txtId.Clear();
					txtNombre.Clear();
					txtTelefono.Clear();
					dgvProveedor.DataSource = _provManager.Proveedores.ToList();
				}
			}
		}

		private void inventarioToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			new InventarioVenta().Show();
			this.Hide();
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
			new InventarioRenta().Show();
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
	}
}
