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
            cmbProductos.DataSource = _prodManager.Nombre.ToList();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere salir?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            txtProveedor.Text = _provManager.BuscarProveedorPorId(
                _prodManager.BuscarProductoPorNombre(cmbProductos.SelectedIndex.ToString()).idProveedor)
                .nombreProveedor;
            try
            {
                if(_ent==null)
                {
                    _ent = new EntradaDTO()
                    {
                        idProducto = Convert.ToInt32(cmbProductos.SelectedIndex),
                        idProveedor = Convert.ToInt32(txtProveedor.Text),
                        fechaEntrada = Convert.ToDateTime(dtpFecheEntrada),
                        cantidad = Convert.ToInt32(txtCantidad.Text),
                        montoPagar = Convert.ToInt32(txtTotal.Text)
                    };
                    if(_entManager.InsertarEntrada(_ent))
                    {
                        MessageBox.Show("El producto fue actualizado corectamente", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbProductos.ResetText();
                        txtProveedor.Clear();
                        dtpFecheEntrada.ResetText();
                        txtCantidad.Clear();
                        txtTotal.Clear();
                        cmbProductos.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Entrada no registrada", titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
	}
}
