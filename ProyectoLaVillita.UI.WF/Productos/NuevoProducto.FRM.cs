﻿using System;
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
			cmbProveedor.DataSource = _provManager.Proveedores.ToList();
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
