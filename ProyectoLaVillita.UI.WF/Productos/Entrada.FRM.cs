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

namespace ProyectoLaVillita.UI.WF.Productos
{
    public partial class Entrada : Form
    {
        private EntradaDTO _ent;
        private ProductoManager _prodManager;
        private ProveedorManager _provManager;
        private EntradaManager _entManager;

        public Entrada()
        {
            InitializeComponent();
            _prodManager = new ProductoManager();
            _provManager = new ProveedorManager();
            _entManager = new EntradaManager();
        }

        private void Entrada_Load(object sender, EventArgs e)
        {
            cmbProductos.DataSource = _prodManager.Productos;
            cmbProveedores.DataSource = _provManager.Proveedores;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(_ent==null)
                {
                    _ent = new EntradaDTO()
                    {
                        idProducto = Convert.ToInt32(cmbProductos.SelectedIndex),
                        idProveedor = Convert.ToInt32(cmbProveedores.SelectedIndex),
                        fechaEntrada = Convert.ToDateTime(dtpFecheEntrada),
                        cantidad = Convert.ToInt32(txtCantidad.Text),
                        montoPagar = Convert.ToInt32(txtTotal.Text)
                    };
                    _entManager.InsertarEntrada(_ent);
                }
            }
            catch (Exception)
            {

                throw;
            }
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
            this.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InventarioVenta().Show();
            this.Hide();
        }

        private void datosDelClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NuevaRenta().Show();
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

        private void modificarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ModificarProveedor().Show();
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
    }
}
