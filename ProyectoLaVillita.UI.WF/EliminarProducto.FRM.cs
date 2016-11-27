using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLaVillita.UI.WF
{
    public partial class EliminarProducto : Form
    {
        public EliminarProducto()
        {
            InitializeComponent();
        }

        private void modificaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EliminarProducto().Show();
            this.Hide();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ModificarProducto().Show();
            this.Hide();
        }
    }
}
