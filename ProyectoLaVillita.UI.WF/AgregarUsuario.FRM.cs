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
    public partial class AgregarUsuario : Form
    {
        private UsuarioDTO _user;
        private readonly UsuarioManager _userManager;
        public AgregarUsuario()
        {
            InitializeComponent();
            _userManager = new UsuarioManager();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_user == null)
            {
                _user = new UsuarioDTO()
                {
                    nombreUsuario = txtUsuario.Text,
                    contraseña = txtUsuario.Text
                };
                if (!txtConfirmarContraseña.Text.Equals(_user.contraseña))
                {
                    MessageBox.Show("La contraseña no coincide");
                }
                else
                {
                    _userManager.InsertarUsuario(_user);
                    MessageBox.Show("Usuario agregado correctamente");
                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new AgregarProducto().Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            new AgregarProveedor().Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            new InventarioVentas().Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            new Entrada().Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            new VentaFRM().Show();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            new Renta().Show();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            new InventarioRenta().Show();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            new AgregarUsuario().Show();
        }
    }
}
