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

namespace ProyectoLaVillita.UI.WF
{
    public partial class AgregarProveedor : Form
    {
        private ProveedorDTO _proveedor;
        private readonly ProveedorManager _proveedorManager;
        public AgregarProveedor()
        {
            InitializeComponent();
            _proveedorManager = new ProveedorManager();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                _proveedor = new ProveedorDTO();
                _proveedor.nombreProveedor = txtNombre.Text;
                _proveedor.telefono = txtTelefono.Text;

                if (_proveedorManager.InsertarProveedor(_proveedor))
                    MessageBox.Show("Proveedor Registrado exitosamente");
                else
                    MessageBox.Show("Proveedor no guardado");

                txtNombre.Clear();
                txtTelefono.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: {0}", ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AgregarProducto().Show();
            this.Hide();
        }

        private void registroDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AgregarProveedor().Show();
            this.Hide();
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Entrada().Show();
            this.Hide();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VentaFRM().Show();
            this.Hide();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InventarioVentas().Show();
            this.Hide();
        }

        private void nuevaRentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datosDelClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Renta().Show();
            this.Hide();
        }

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new InventarioRenta().Show();
            this.Hide();
        }

        private void registroDeNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AgregarUsuario().Show();
            this.Hide();
        }
    }
}
