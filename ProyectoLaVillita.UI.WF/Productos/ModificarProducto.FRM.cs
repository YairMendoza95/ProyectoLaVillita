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

namespace ProyectoLaVillita.UI.WF.Productos
{
    public partial class ModificarProducto : Form
    {
        private ProductoDTO _prod;
        private ProductoManager _prodManager;
        public ModificarProducto()
        {
            InitializeComponent();
            _prodManager = new ProductoManager();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _prodManager.BuscarProductoPorNombre(txtIngresarNombre.Text).idProveedor.ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            _prod.nombre = nombre.ToString();
            _prod.precioUnitario = Convert.ToDouble(precioUnitario);
            _prodManager.ModificarProducto(_prod);
        }
    }
}
