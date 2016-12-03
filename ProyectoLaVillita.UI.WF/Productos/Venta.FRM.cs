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
        private VentaDTO _venta;
        private VentaManager _ventaManager;
        public string titulo="Sistema de inventario \"La Villita\"";
        public double cant, sub, total = 0;
        //private 
        public Venta()
        {
            InitializeComponent();
            _prod = new ProductoDTO();
            _prodManager = new ProductoManager();
            _dvManager = new DetalleVentaManger();
            _ventaManager = new VentaManager();
        }

		private void Venta_Load(object sender, EventArgs e)
		{
			//cmbProductos.GetItemText(_prodManager.Nombre);
			if (Program.idUsuario != 1)
			{
				usuariosToolStripMenuItem.Visible = false;
				cerrarSesiónToolStripMenuItem.Visible = true;
			}
			else
			{
				usuariosToolStripMenuItem.Visible = true;
				cerrarSesiónToolStripMenuItem.Visible = false;
			}
			var datos = _prodManager.Productos.ToList();
			if (datos.Count > 0)
			{
				cmbProductos.DisplayMember = "nombre";
				cmbProductos.DataSource = datos;
				cmbProductos.ValueMember = "idProducto";
			}
		}

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("¿Está seguro que quiere salir?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

		private void registroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new NuevoProducto().Show();
			this.Hide();
		}

		private void inventarioToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			new InventarioVenta().Show();
			this.Hide();
		}

		private void registroDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new NuevoProveedor().Show();
			this.Hide();
		}

		private void modificarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new ModificarProveedor().Show();
			this.Hide();
		}

		private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Entrada().Show();
			this.Hide();
		}

		private void datosDelClienteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new NuevaRenta().Show();
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

		private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new ModificarUsuario().Show();
			this.Hide();
		}

		private void cambiarDeUsuariioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Está seguro quq quiere cerrar sesión?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.Hide();
				Program.idUsuario = 0;
				new Inicio().Show();
			}
		}

		private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Está seguro quq quiere cerrar sesión?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.Hide();
				Program.idUsuario = 0;
				new Inicio().Show();
			}
		}

		private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            cant = Convert.ToDouble(txtCantidad.Text);
            sub = cant * _prod.precioVenta;
            //if(this.WindowState==FormClosed)
            try
            {
                if (_dv == null)
                {
                    _ventaManager.InsertarVenta(_venta);
                    _dv = new DetalleVentaDTO()
                    {
                        idProducto = cmbProductos.SelectedIndex,
                        //idProveedor
                        idVenta = _venta.idVenta,
                        fechaVenta = DateTime.Today,
                        cantidad = cant,
                        total = sub,
                    };
                    _dvManager.InsertarDetalleVenta(_dv);
                    dgvDetalleVenta.Rows.Add(_dv.idProducto, _dv.idProveedor, _dv.cantidad, _dv.total);
                }
                cmbProductos.ResetText();
                txtCantidad.Clear();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            total += sub;
            try
            {
                _venta = new VentaDTO()
                {
                    total = total,
                    notas = txtNotas.Text,
                };
                _ventaManager.InsertarVenta(_venta);
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
