﻿using System;
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
using ProyectoLaVillita.COMMON.Entidades;
using ProyectoLaVillita.BIZ;

namespace ProyectoLaVillita.UI.WF.Proveedores
{
    public partial class ModificarProveedor : Form
    {
        public string titulo = "Sistema de inventario \"La Villita\"";
        private ProveedorDTO _prov;
        private ProveedorManager _provManager;
        public IQueryable<ProveedorDTO> proveedor;

        public ModificarProveedor()
        {
            InitializeComponent();
            _provManager = new ProveedorManager();
        }
        public void listar()
        {
            proveedor = _provManager.Proveedores;
            if (proveedor.Count() > 0)
            {
                dgvProveedor.DataSource = proveedor;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere salir?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void registroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NuevoProducto().Show();
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
            new ModificarRenta().Show();
            this.Hide();
        }

        private void cambiarDeUsuariioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro que quiere cerrar sesión?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new Inicio().Show();
                this.Hide();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_prov == null)
            {
                _prov = new ProveedorDTO()
                {
                    nombreProveedor = dgvProveedor.SelectedColumns.ToString(),
                    telefono = dgvProveedor.SelectedColumns.ToString()
                };
            }
            _provManager.ModificarProveedor(_prov);
        }

        private void ModificarProveedor_Load(object sender, EventArgs e)
        {

            listar();
        }
    }
}
