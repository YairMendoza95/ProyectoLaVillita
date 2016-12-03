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
        private readonly UsuarioManager _userManage;
        public string titulo = "Sistema de inventario \"La VIllita\"";
        public Inicio()
        {
            InitializeComponent();
            _userManage = new UsuarioManager();
            txtUsuario.Focus();
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere salir?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
			if (_userManage.Login(txtUsuario.Text, txtContraseña.Text) && Program.idUsuario == 0)
			{
				Program.idUsuario = _userManage.BuscarUsuarioPorNombre(txtUsuario.Text).idUsuario;
				if (MessageBox.Show("¡Bienvenido! " + txtUsuario.Text, titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
				{
					new Venta().Show();
					this.Hide();
				}
			}
			else
			{
				MessageBox.Show("El usuario no existe", titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtContraseña.Clear();
				txtContraseña.Focus();
			}
        }
	}
}
