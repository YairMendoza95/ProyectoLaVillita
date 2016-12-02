using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using ProyectoLaVillita.BIZ;
using System.Threading.Tasks;
using System.Collections.Generic;
using ProyectoLaVillita.UI.WF.Usuarios;
using ProyectoLaVillita.UI.WF.Productos;
using ProyectoLaVillita.COMMON.Entidades;
using ProyectoLaVillita.UI.WF.Proveedores;

namespace ProyectoLaVillita.UI.WF.Rentas
{
    public partial class NuevaRenta : Form
    {
        public string titulo = "Sistema de inventario \"La Villita\"";
        private RentaDTO _renta;
        private RentaManager _rentaManager;
        public NuevaRenta()
        {
            InitializeComponent();
            _rentaManager = new RentaManager();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere salir?", titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
