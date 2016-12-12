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
using ProyectoLaVillita.COMMON.Entidades;

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
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
			List<UsuarioDTO> usuario = _userManage.Usuarios.ToList();
			if (usuario.Count > 0)
			{
				cmbUsuarios.DataSource = usuario;
				cmbUsuarios.DisplayMember = "nombreUsuario";
				cmbUsuarios.ValueMember = "idUsuario";
			}
		}

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere salir?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
			if (_userManage.Login(cmbUsuarios.Text, txtContraseña.Text) && Program.idTipoUsuario == 0)
			{
				Program.idTipoUsuario = _userManage.BuscarUsuarioPorId(Convert.ToInt32(cmbUsuarios.SelectedValue)).idTipoUsuario;
				Program.usuario = Convert.ToInt32(cmbUsuarios.SelectedValue);
				new Venta().Show();
				this.Hide();

				MessageBox.Show("¡Bienvenido! " + cmbUsuarios.Text, titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("El usuario no existe", titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtContraseña.Clear();
				txtContraseña.Focus();
			}
        }

		private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar==Convert.ToChar(Keys.Enter))
			{
				if (_userManage.Login(cmbUsuarios.Text, txtContraseña.Text) && Program.idTipoUsuario == 0)
				{
					Program.idTipoUsuario = _userManage.BuscarUsuarioPorId(Convert.ToInt32(cmbUsuarios.SelectedValue)).idTipoUsuario;
					Program.usuario = Convert.ToInt32(cmbUsuarios.SelectedValue);
					new Venta().Show();
					this.Hide();

					MessageBox.Show("¡Bienvenido! " + cmbUsuarios.Text, titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
}
