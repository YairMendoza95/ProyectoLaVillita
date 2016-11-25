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
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                _userManage.Login(txtUsuario.Text, txtContraseña.Text);
                new VentaFRM().Show();
                this.Hide();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
