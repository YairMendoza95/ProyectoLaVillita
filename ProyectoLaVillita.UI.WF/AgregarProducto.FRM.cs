﻿using System;
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        private void registroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AgregarProducto().Show();
            this.Hide();
        }

        private void registroDeNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AgregarUsuario().Show();
            this.Hide();
        }

        private void cambiarDeUsuariioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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
    }
}
