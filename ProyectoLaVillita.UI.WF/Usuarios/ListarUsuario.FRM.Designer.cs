﻿namespace ProyectoLaVillita.UI.WF.Usuarios
{
    partial class ModificarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.grpInformacion = new System.Windows.Forms.GroupBox();
			this.txtTipo = new System.Windows.Forms.TextBox();
			this.cmbTipos = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tiendaDeAbarrotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registroDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inventarioToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registroDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rentaDeSillasYMesasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevaRentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.datosDelClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarRentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registroDeNuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cambiarDeUsuariioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtIngresarNombre = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.dgvUsuarios = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.grpInformacion.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
			this.groupBox1.Controls.Add(this.grpInformacion);
			this.groupBox1.Controls.Add(this.btnEliminar);
			this.groupBox1.Controls.Add(this.btnModificar);
			this.groupBox1.Controls.Add(this.menuStrip1);
			this.groupBox1.Controls.Add(this.btnGuardar);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.btnSalir);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.dgvUsuarios);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(2, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(792, 474);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Modificar usuario";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// grpInformacion
			// 
			this.grpInformacion.Controls.Add(this.txtTipo);
			this.grpInformacion.Controls.Add(this.cmbTipos);
			this.grpInformacion.Controls.Add(this.label7);
			this.grpInformacion.Controls.Add(this.txtConfirmarContraseña);
			this.grpInformacion.Controls.Add(this.label6);
			this.grpInformacion.Controls.Add(this.txtContraseña);
			this.grpInformacion.Controls.Add(this.label5);
			this.grpInformacion.Controls.Add(this.txtNombre);
			this.grpInformacion.Controls.Add(this.label4);
			this.grpInformacion.Controls.Add(this.txtId);
			this.grpInformacion.Controls.Add(this.label2);
			this.grpInformacion.Location = new System.Drawing.Point(468, 150);
			this.grpInformacion.Name = "grpInformacion";
			this.grpInformacion.Size = new System.Drawing.Size(318, 192);
			this.grpInformacion.TabIndex = 24;
			this.grpInformacion.TabStop = false;
			this.grpInformacion.Text = "Información";
			// 
			// txtTipo
			// 
			this.txtTipo.Location = new System.Drawing.Point(174, 85);
			this.txtTipo.Name = "txtTipo";
			this.txtTipo.ReadOnly = true;
			this.txtTipo.Size = new System.Drawing.Size(131, 23);
			this.txtTipo.TabIndex = 26;
			// 
			// cmbTipos
			// 
			this.cmbTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipos.FormattingEnabled = true;
			this.cmbTipos.Location = new System.Drawing.Point(174, 85);
			this.cmbTipos.Name = "cmbTipos";
			this.cmbTipos.Size = new System.Drawing.Size(131, 24);
			this.cmbTipos.TabIndex = 25;
			this.cmbTipos.Visible = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 88);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(108, 16);
			this.label7.TabIndex = 24;
			this.label7.Text = "Tipo de usuario";
			// 
			// txtConfirmarContraseña
			// 
			this.txtConfirmarContraseña.Location = new System.Drawing.Point(174, 144);
			this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
			this.txtConfirmarContraseña.PasswordChar = '*';
			this.txtConfirmarContraseña.ReadOnly = true;
			this.txtConfirmarContraseña.Size = new System.Drawing.Size(131, 23);
			this.txtConfirmarContraseña.TabIndex = 23;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 147);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(150, 16);
			this.label6.TabIndex = 22;
			this.label6.Text = "Confirmar contraseña";
			// 
			// txtContraseña
			// 
			this.txtContraseña.Location = new System.Drawing.Point(174, 115);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.PasswordChar = '*';
			this.txtContraseña.ReadOnly = true;
			this.txtContraseña.Size = new System.Drawing.Size(131, 23);
			this.txtContraseña.TabIndex = 21;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 118);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 16);
			this.label5.TabIndex = 20;
			this.label5.Text = "Contraseña";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(174, 56);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.ReadOnly = true;
			this.txtNombre.Size = new System.Drawing.Size(131, 23);
			this.txtNombre.TabIndex = 19;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 16);
			this.label4.TabIndex = 18;
			this.label4.Text = "Nombre de usuario";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(174, 27);
			this.txtId.Name = "txtId";
			this.txtId.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(131, 23);
			this.txtId.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 16);
			this.label2.TabIndex = 16;
			this.label2.Text = "Id";
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Location = new System.Drawing.Point(54, 420);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(127, 39);
			this.btnEliminar.TabIndex = 15;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Location = new System.Drawing.Point(333, 420);
			this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(127, 39);
			this.btnModificar.TabIndex = 14;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiendaDeAbarrotesToolStripMenuItem,
            this.rentaDeSillasYMesasToolStripMenuItem1,
            this.usuariosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(3, 19);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(786, 25);
			this.menuStrip1.TabIndex = 13;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tiendaDeAbarrotesToolStripMenuItem
			// 
			this.tiendaDeAbarrotesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.registrosToolStripMenuItem});
			this.tiendaDeAbarrotesToolStripMenuItem.Name = "tiendaDeAbarrotesToolStripMenuItem";
			this.tiendaDeAbarrotesToolStripMenuItem.Size = new System.Drawing.Size(139, 21);
			this.tiendaDeAbarrotesToolStripMenuItem.Text = "Tienda de abarrotes";
			// 
			// productosToolStripMenuItem
			// 
			this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeProductosToolStripMenuItem,
            this.inventarioToolStripMenuItem2});
			this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
			this.productosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.productosToolStripMenuItem.Text = "Productos";
			// 
			// registroDeProductosToolStripMenuItem
			// 
			this.registroDeProductosToolStripMenuItem.Name = "registroDeProductosToolStripMenuItem";
			this.registroDeProductosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.registroDeProductosToolStripMenuItem.Text = "Nuevo producto";
			this.registroDeProductosToolStripMenuItem.Click += new System.EventHandler(this.registroDeProductosToolStripMenuItem_Click);
			// 
			// inventarioToolStripMenuItem2
			// 
			this.inventarioToolStripMenuItem2.Name = "inventarioToolStripMenuItem2";
			this.inventarioToolStripMenuItem2.Size = new System.Drawing.Size(175, 22);
			this.inventarioToolStripMenuItem2.Text = "Inventario";
			this.inventarioToolStripMenuItem2.Click += new System.EventHandler(this.inventarioToolStripMenuItem2_Click);
			// 
			// proveedoresToolStripMenuItem
			// 
			this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeProveedoresToolStripMenuItem,
            this.modificarProveedorToolStripMenuItem});
			this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
			this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.proveedoresToolStripMenuItem.Text = "Proveedores";
			// 
			// registroDeProveedoresToolStripMenuItem
			// 
			this.registroDeProveedoresToolStripMenuItem.Name = "registroDeProveedoresToolStripMenuItem";
			this.registroDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
			this.registroDeProveedoresToolStripMenuItem.Text = "Nuevo proveedor";
			this.registroDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.registroDeProveedoresToolStripMenuItem_Click);
			// 
			// modificarProveedorToolStripMenuItem
			// 
			this.modificarProveedorToolStripMenuItem.Name = "modificarProveedorToolStripMenuItem";
			this.modificarProveedorToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
			this.modificarProveedorToolStripMenuItem.Text = "Listado de proveedores";
			this.modificarProveedorToolStripMenuItem.Click += new System.EventHandler(this.modificarProveedorToolStripMenuItem_Click);
			// 
			// registrosToolStripMenuItem
			// 
			this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasToolStripMenuItem,
            this.ventasToolStripMenuItem});
			this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
			this.registrosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.registrosToolStripMenuItem.Text = "Registros";
			// 
			// entradasToolStripMenuItem
			// 
			this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
			this.entradasToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.entradasToolStripMenuItem.Text = "Entradas";
			this.entradasToolStripMenuItem.Click += new System.EventHandler(this.entradasToolStripMenuItem_Click);
			// 
			// ventasToolStripMenuItem
			// 
			this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
			this.ventasToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.ventasToolStripMenuItem.Text = "Ventas";
			this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
			// 
			// rentaDeSillasYMesasToolStripMenuItem1
			// 
			this.rentaDeSillasYMesasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaRentaToolStripMenuItem,
            this.inventarioToolStripMenuItem1});
			this.rentaDeSillasYMesasToolStripMenuItem1.Name = "rentaDeSillasYMesasToolStripMenuItem1";
			this.rentaDeSillasYMesasToolStripMenuItem1.Size = new System.Drawing.Size(155, 21);
			this.rentaDeSillasYMesasToolStripMenuItem1.Text = "Renta de Sillas y Mesas";
			// 
			// nuevaRentaToolStripMenuItem
			// 
			this.nuevaRentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDelClienteToolStripMenuItem,
            this.modificarRentaToolStripMenuItem});
			this.nuevaRentaToolStripMenuItem.Name = "nuevaRentaToolStripMenuItem";
			this.nuevaRentaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.nuevaRentaToolStripMenuItem.Text = "Renta";
			// 
			// datosDelClienteToolStripMenuItem
			// 
			this.datosDelClienteToolStripMenuItem.Name = "datosDelClienteToolStripMenuItem";
			this.datosDelClienteToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.datosDelClienteToolStripMenuItem.Text = "Nueva renta";
			this.datosDelClienteToolStripMenuItem.Click += new System.EventHandler(this.datosDelClienteToolStripMenuItem_Click);
			// 
			// modificarRentaToolStripMenuItem
			// 
			this.modificarRentaToolStripMenuItem.Name = "modificarRentaToolStripMenuItem";
			this.modificarRentaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.modificarRentaToolStripMenuItem.Text = "Listado de rentas";
			this.modificarRentaToolStripMenuItem.Click += new System.EventHandler(this.modificarRentaToolStripMenuItem_Click);
			// 
			// inventarioToolStripMenuItem1
			// 
			this.inventarioToolStripMenuItem1.Name = "inventarioToolStripMenuItem1";
			this.inventarioToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
			this.inventarioToolStripMenuItem1.Text = "Inventario";
			this.inventarioToolStripMenuItem1.Click += new System.EventHandler(this.inventarioToolStripMenuItem1_Click);
			// 
			// usuariosToolStripMenuItem
			// 
			this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeNuevoUsuarioToolStripMenuItem,
            this.cambiarDeUsuariioToolStripMenuItem});
			this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
			this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
			this.usuariosToolStripMenuItem.Text = "Usuarios";
			// 
			// registroDeNuevoUsuarioToolStripMenuItem
			// 
			this.registroDeNuevoUsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoUsuarioToolStripMenuItem,
            this.modificarUsuarioToolStripMenuItem});
			this.registroDeNuevoUsuarioToolStripMenuItem.Name = "registroDeNuevoUsuarioToolStripMenuItem";
			this.registroDeNuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.registroDeNuevoUsuarioToolStripMenuItem.Text = "Control de usuarios";
			// 
			// nuevoUsuarioToolStripMenuItem
			// 
			this.nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
			this.nuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.nuevoUsuarioToolStripMenuItem.Text = "Nuevo usuario";
			this.nuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoUsuarioToolStripMenuItem_Click);
			// 
			// modificarUsuarioToolStripMenuItem
			// 
			this.modificarUsuarioToolStripMenuItem.Enabled = false;
			this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
			this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.modificarUsuarioToolStripMenuItem.Text = "Listado de usuarios";
			// 
			// cambiarDeUsuariioToolStripMenuItem
			// 
			this.cambiarDeUsuariioToolStripMenuItem.Name = "cambiarDeUsuariioToolStripMenuItem";
			this.cambiarDeUsuariioToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.cambiarDeUsuariioToolStripMenuItem.Text = "Cambiar de Usuario";
			this.cambiarDeUsuariioToolStripMenuItem.Click += new System.EventHandler(this.cambiarDeUsuariioToolStripMenuItem_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Location = new System.Drawing.Point(554, 366);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(127, 39);
			this.btnGuardar.TabIndex = 12;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Visible = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(302, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 28);
			this.label3.TabIndex = 10;
			this.label3.Text = "La Villita";
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(572, 422);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(127, 39);
			this.btnSalir.TabIndex = 8;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.txtIngresarNombre);
			this.groupBox3.Controls.Add(this.btnBuscar);
			this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(10, 85);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(422, 59);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Busqueda";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Ingresar nombre";
			// 
			// txtIngresarNombre
			// 
			this.txtIngresarNombre.Location = new System.Drawing.Point(137, 23);
			this.txtIngresarNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtIngresarNombre.Name = "txtIngresarNombre";
			this.txtIngresarNombre.Size = new System.Drawing.Size(162, 23);
			this.txtIngresarNombre.TabIndex = 4;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Location = new System.Drawing.Point(310, 15);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(105, 35);
			this.btnBuscar.TabIndex = 5;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// dgvUsuarios
			// 
			this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsuarios.Location = new System.Drawing.Point(10, 150);
			this.dgvUsuarios.Name = "dgvUsuarios";
			this.dgvUsuarios.Size = new System.Drawing.Size(440, 255);
			this.dgvUsuarios.TabIndex = 1;
			this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
			// 
			// ModificarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(794, 474);
			this.Controls.Add(this.groupBox1);
			this.Name = "ModificarUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema de inventario \"La Villita\"";
			this.Load += new System.EventHandler(this.ModificarUsuario_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.grpInformacion.ResumeLayout(false);
			this.grpInformacion.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIngresarNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tiendaDeAbarrotesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registroDeProductosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registroDeProveedoresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modificarProveedorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rentaDeSillasYMesasToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem nuevaRentaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem datosDelClienteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modificarRentaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registroDeNuevoUsuarioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modificarUsuarioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cambiarDeUsuariioToolStripMenuItem;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.TextBox txtConfirmarContraseña;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox grpInformacion;
		private System.Windows.Forms.ComboBox cmbTipos;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtTipo;
	}
}