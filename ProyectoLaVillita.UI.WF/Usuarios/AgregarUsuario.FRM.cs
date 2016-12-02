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
using ProyectoLaVillita.UI.WF.Productos;
using ProyectoLaVillita.UI.WF;
using ProyectoLaVillita.UI.WF.Proveedores;
using ProyectoLaVillita.UI.WF.Rentas;

namespace ProyectoLaVillita.UI.WF.Usuarios
{
    public partial class AgregarUsuario : Form
    {
        public string titulo = "Sistema de inventario \"La Villita\"";
        private UsuarioDTO _user;
        private UsuarioManager _userManager;
        public AgregarUsuario()
        {
            InitializeComponent();
            _userManager = new UsuarioManager();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (_user == null)
                {
                    _user = new UsuarioDTO()
                    {
                        nombreUsuario = txtUsuario.Text.ToString(),
                        contraseña = txtContraseña.Text.ToString()
                    };
                    if (!txtConfirmarContraseña.Text.Equals(txtContraseña.Text))
                    {
                        MessageBox.Show("Las contraseñas no coinciden", titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtContraseña.Clear();
                        txtContraseña.Focus();
                        txtConfirmarContraseña.Clear();
                    }
                    else
                    {
                        _userManager.InsertarUsuario(_user);
                        MessageBox.Show("Usuario agregado correctamente", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtConfirmarContraseña.Clear();
                        txtContraseña.Clear();
                        txtUsuario.Clear();
                        if (MessageBox.Show("¿Desea iniciar sesión con el nuevo usuario?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            new Inicio().Show();
                            this.Hide();
                        }
                        else
                        {
                            new Venta().Show();
                            this.Hide();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere salir?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
