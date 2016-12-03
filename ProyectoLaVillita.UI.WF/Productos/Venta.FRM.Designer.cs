namespace ProyectoLaVillita.UI.WF.Productos
{
    partial class Venta
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
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.cmbProductos = new System.Windows.Forms.ComboBox();
			this.Cantidad = new System.Windows.Forms.Label();
			this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
			this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
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
			this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtNotas = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(139, 244);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(118, 39);
			this.btnSalir.TabIndex = 10;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Location = new System.Drawing.Point(6, 244);
			this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(111, 39);
			this.btnAgregar.TabIndex = 13;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(273, 44);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(110, 28);
			this.label6.TabIndex = 14;
			this.label6.Text = "La Villita";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 95);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 16);
			this.label4.TabIndex = 15;
			this.label4.Text = "Producto";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(88, 123);
			this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(169, 23);
			this.txtCantidad.TabIndex = 16;
			// 
			// cmbProductos
			// 
			this.cmbProductos.FormattingEnabled = true;
			this.cmbProductos.Location = new System.Drawing.Point(88, 92);
			this.cmbProductos.Name = "cmbProductos";
			this.cmbProductos.Size = new System.Drawing.Size(169, 24);
			this.cmbProductos.TabIndex = 26;
			this.cmbProductos.Text = "--Elige un producto--";
			// 
			// Cantidad
			// 
			this.Cantidad.AutoSize = true;
			this.Cantidad.Location = new System.Drawing.Point(12, 126);
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.Size = new System.Drawing.Size(70, 16);
			this.Cantidad.TabIndex = 27;
			this.Cantidad.Text = "Cantidad";
			// 
			// dgvDetalleVenta
			// 
			this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProducto,
            this.colProveedor,
            this.colCantidad,
            this.colSubtotal,
            this.colEliminar});
			this.dgvDetalleVenta.Location = new System.Drawing.Point(263, 75);
			this.dgvDetalleVenta.Name = "dgvDetalleVenta";
			this.dgvDetalleVenta.Size = new System.Drawing.Size(387, 256);
			this.dgvDetalleVenta.TabIndex = 28;
			// 
			// colProducto
			// 
			this.colProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colProducto.HeaderText = "Producto";
			this.colProducto.Name = "colProducto";
			// 
			// colProveedor
			// 
			this.colProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colProveedor.HeaderText = "Proveedor";
			this.colProveedor.Name = "colProveedor";
			// 
			// colCantidad
			// 
			this.colCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colCantidad.HeaderText = "Cantidad";
			this.colCantidad.Name = "colCantidad";
			// 
			// colSubtotal
			// 
			this.colSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colSubtotal.HeaderText = "Subtotal";
			this.colSubtotal.Name = "colSubtotal";
			// 
			// colEliminar
			// 
			this.colEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colEliminar.HeaderText = "";
			this.colEliminar.Name = "colEliminar";
			this.colEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Location = new System.Drawing.Point(73, 291);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(111, 39);
			this.btnGuardar.TabIndex = 29;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
			this.groupBox1.Controls.Add(this.menuStrip1);
			this.groupBox1.Controls.Add(this.txtNotas);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnGuardar);
			this.groupBox1.Controls.Add(this.dgvDetalleVenta);
			this.groupBox1.Controls.Add(this.Cantidad);
			this.groupBox1.Controls.Add(this.cmbProductos);
			this.groupBox1.Controls.Add(this.txtCantidad);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.btnAgregar);
			this.groupBox1.Controls.Add(this.btnSalir);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(664, 343);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ventas";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiendaDeAbarrotesToolStripMenuItem,
            this.rentaDeSillasYMesasToolStripMenuItem1,
            this.usuariosToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(3, 19);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(658, 25);
			this.menuStrip1.TabIndex = 32;
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
			this.ventasToolStripMenuItem.Enabled = false;
			this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
			this.ventasToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.ventasToolStripMenuItem.Text = "Ventas";
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
			this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
			this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.modificarUsuarioToolStripMenuItem.Text = "Listado de usuarios";
			this.modificarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuarioToolStripMenuItem_Click);
			// 
			// cambiarDeUsuariioToolStripMenuItem
			// 
			this.cambiarDeUsuariioToolStripMenuItem.Name = "cambiarDeUsuariioToolStripMenuItem";
			this.cambiarDeUsuariioToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.cambiarDeUsuariioToolStripMenuItem.Text = "Cambiar de Usuario";
			this.cambiarDeUsuariioToolStripMenuItem.Click += new System.EventHandler(this.cambiarDeUsuariioToolStripMenuItem_Click);
			// 
			// cerrarSesiónToolStripMenuItem
			// 
			this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
			this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(96, 21);
			this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
			this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
			// 
			// txtNotas
			// 
			this.txtNotas.Location = new System.Drawing.Point(88, 151);
			this.txtNotas.Multiline = true;
			this.txtNotas.Name = "txtNotas";
			this.txtNotas.Size = new System.Drawing.Size(169, 86);
			this.txtNotas.TabIndex = 31;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 154);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 16);
			this.label1.TabIndex = 30;
			this.label1.Text = "Notas";
			// 
			// Venta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(662, 343);
			this.Controls.Add(this.groupBox1);
			this.Name = "Venta";
			this.Text = "Sistema de inventario \"La Villita\"";
			this.Load += new System.EventHandler(this.Venta_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
		private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
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
		private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
	}
}