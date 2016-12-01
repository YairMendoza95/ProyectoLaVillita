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
        public string titulo = "Sistema de inventario \"La Villita\"";
        public NuevoProducto()
        {
            InitializeComponent();
            _prodManager = new ProductoManager();
            _provManager = new ProveedorManager();
            _ent = new EntradaDTO();

        }

        private void registroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NuevoProducto().Show();
            this.Hide();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EliminarProducto().Show();
            this.Hide();
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ModificarProducto().Show();
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

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InventarioVenta().Show();
            this.Hide();
        }

        private void registroDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NuevoProveedor().Show();
            this.Hide();
        }

        private void eliminarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EliminarProveedor().Show();
            this.Hide();
        }

        private void modificarProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ModificarProveedor().Show();
            this.Hide();
        }

        private void datosDelClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NuevaRenta().Show();
            this.Hide();
        }

        private void eliminarRentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EliminarRenta().Show();
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

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EliminarUsuario().Show();
            this.Hide();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ModificarUsuario().Show();
            this.Hide();
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
                if (_prod == null)
                {
                    _prod = new ProductoDTO()
                    {
                        nombre = txtNombre.Text,
                        precioUnitario = Convert.ToDouble(txtCostoUnitario.Text),
                        idProveedor = cmbProveedor.SelectedIndex,
                        stockActual = sta,
                        stockMax = Convert.ToInt32(txtMaximo.Text),
                        stockMin = Convert.ToInt32(txtMinimo.Text)
                    };

                    _prodManager.AgregarProducto(_prod);
                }
                txtNombre.Clear();
                txtCostoUnitario.Clear();
                //cmbProveedor.d
                txtMaximo.Clear();
                txtMinimo.Clear();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void NuevoProducto_Load(object sender, EventArgs e)
        {
            cmbProveedor.GetItemText(_provManager.Nombre);
        }

        private void cambiarDeUsuariioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere salir?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                new Inicio().Show();
                this.Hide();
            }
        }
    }
}
