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
    public partial class AgregarProducto : Form
    {
        private ProductoDTO _producto;
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_producto == null)
            {
                _producto = new ProductoDTO();
            }
            _producto.nombre = txtNombreProducto.Text;
            _producto.precioUnitario = Convert.ToInt32(txtNombreProducto.Text);
            _producto.stockMax = Convert.ToInt32(txtStockMaximo.Text);
            _producto.stockMin = Convert.ToInt32(txtStockMinimo.Text);
            //switch(cmbProveedor.)
        }
    }
}
