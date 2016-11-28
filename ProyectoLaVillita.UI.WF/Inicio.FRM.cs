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
using ProyectoLaVillita.UI.WF.Productos;

namespace ProyectoLaVillita.UI.WF
{
    public partial class Inicio : Form
    {
        //private UsuarioDTO _user;
        private readonly UsuarioManager _userManage;
        public Inicio()
        {
            InitializeComponent();
            _userManage = new UsuarioManager();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            char c = '"';
            string titulo = "Sistema de inventario " + c + "La Villita" + c;
            if (MessageBox.Show("¿Está seguro que quiere salir?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            char c = '"';
            string titulo = "Sistema de inventario " + c + "La Villita" + c;
            if (_userManage.Login(txtUsuario.Text, txtContraseña.Text))
            {
                if (MessageBox.Show("¡Bienvenido!", titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    new Venta().Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("El usuario no existe",titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //txtUsuario.Clear();
                txtContraseña.Clear();
                txtContraseña.Focus();
            }
        }
    }
}
