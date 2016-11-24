﻿using System;
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
    public partial class AgregarProveedor : Form
    {
        private ProveedorDTO _proveedor;
        private readonly ProveedorManager _proveedorManager;
        public AgregarProveedor()
        {
            InitializeComponent();
            _proveedorManager = new ProveedorManager();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_proveedor == null)
                {
                    _proveedor = new ProveedorDTO()
                    {
                        nombreProveedor = txtNombre.Text,
                        telefono = txtTelefono.Text
                    };
                }
                _proveedorManager.InsertarProveedor(_proveedor);
                MessageBox.Show("Proveedor Registrado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: {0}", ex.Message);
            }
           

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
