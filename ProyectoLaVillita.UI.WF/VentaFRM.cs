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

namespace ProyectoLaVillita.UI.WF
{
    public partial class VentaFRM : Form
    {
        public VentaFRM()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AgregarProducto().Show();
            this.Hide();
        }

        private void datosDelProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AgregarProveedor().Show();
            this.Hide();
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Entrada().Show();
            this.Hide();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VentaFRM().Show();
            this.Hide();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InventarioVentas().Show();
            this.Hide();
        }

        private void datosDelClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Renta().Show();
            this.Hide();
        }

        private void detalleRentaToolStripMenuItem_Click(object sender, EventArgs e)
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
