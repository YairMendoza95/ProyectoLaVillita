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
using ProyectoLaVillita.UI.WF.Proveedores;
using ProyectoLaVillita.UI.WF.Rentas;
using ProyectoLaVillita.UI.WF.Usuarios;

namespace ProyectoLaVillita.UI.WF.Productos
{
    public partial class Venta : Form
    {
        private ProductoDTO _prod;
        private ProductoManager _prodManager;
        private DetalleVentaDTO _dv;
        private DetalleVentaManger _dvManager;
        //private 
        public Venta()
        {
            InitializeComponent();
            _prod = new ProductoDTO();
            _prodManager = new ProductoManager();
            _dvManager = new DetalleVentaManger();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            cmbProductos.GetItemText(_prodManager.Nombre);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NuevoProducto().Show();
            this.Hide();
        }

        private void salidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EliminarProducto().Show();
            this.Hide();
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ModificarProducto().Show();
            this.Hide();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InventarioVenta().Show();
            this.Hide();
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Entrada().Show();
            this.Hide();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Venta().Show();
            this.Hide();
        }

        private void datosDelProveedorToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void nuevaRentaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void detalleRentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InventarioRenta().Show();
            this.Hide();
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AgregarUsuario().Show();
            this.Hide();
        }

        private void eliminarUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new EliminarUsuario().Show();
            this.Hide();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ModificarUsuario().Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double cant = Convert.ToDouble(txtCantidad.Text);
            double sub = cant * _prod.precioUnitario;
            
            try
            {
                if (_dv == null)
                {
                    _dv = new DetalleVentaDTO()
                    {
                        idProducto = cmbProductos.SelectedIndex,
                        //idProveedor
                        fechaVenta = DateTime.Today,
                        cantidad = cant,
                        total = sub,
                    };
                    _dvManager.InsertarDetalleVenta(_dv);
                    dgvDetalleVenta.Rows.Add(_dv.idProducto, _dv.idProveedor, _dv.cantidad, _dv.total);
                }
                //cmbProductos
                txtCantidad.Clear();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvDetalleVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //colEliminar.DataGridView.Click;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
