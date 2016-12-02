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
using ProyectoLaVillita.UI.WF.Proveedores;
using ProyectoLaVillita.UI.WF.Usuarios;
using ProyectoLaVillita.BIZ;
using ProyectoLaVillita.COMMON.Entidades;

namespace ProyectoLaVillita.UI.WF.Rentas
{
    public partial class InventarioRenta : Form
    {
        //private ProductoDTO _prod;
        private ProductoManager _prodManager;
        public string titulo = "Sistema de inventario \"La Villita\"";
        public InventarioRenta()
        {
            InitializeComponent();
            _prodManager = new ProductoManager();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere salir?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void InventarioRenta_Load(object sender, EventArgs e)
        {
            txtMesas.Text = _prodManager.BuscarProductoPorNombre("Mesa").stockActual.ToString();
            txtSillas.Text = _prodManager.BuscarProductoPorNombre("Silla").stockActual.ToString();
        }
    }
}
