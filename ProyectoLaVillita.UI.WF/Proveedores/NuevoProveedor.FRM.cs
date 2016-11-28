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
        public char c = '"';
        public string titulo;
        public NuevoProveedor()
        {
            InitializeComponent();
            _provManager = new ProveedorManager();
            titulo = "Sistema de inventario " + c + "La Villita" + c;
        }

        private void registroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NuevoProducto().Show();
            this.Hide();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EliminarProducto().Show();
            this.Hide();
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ModificarProducto().Show();
            this.Hide();
        }

        private void registroDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NuevoProveedor().Show();
            this.Hide();
        }

        private void eLiminarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EliminarProveedor().Show();
            this.Hide();
        }

        private void modificarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ModificarProveedor().Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
            if (MessageBox.Show("¿Está seguro que quiere salir?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            char c = '"';
            string titulo = "Sistema de inventario " + c + "La Villita" + c;
            try
            {
                if (_prov == null)
                {
                    _prov = new ProveedorDTO()
                    {
                        nombreProveedor = txtNombre.Text,
                        telefono = txtTelefono.Text
                    };
                    //_provManager.InsertarProveedor(_prov);

                    if (_provManager.InsertarProveedor(_prov))
                        MessageBox.Show("Proveedor registrado corectamente", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Proveedor no registrado", titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtNombre.Clear();
                txtTelefono.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void cambiarDeUsuariioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere cerrar sesión?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new Inicio().Show();
                this.Hide();
            }
        }
    }
}
