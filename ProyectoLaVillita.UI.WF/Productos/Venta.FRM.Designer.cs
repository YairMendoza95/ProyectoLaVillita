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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiendaDeAbarrotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDelProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentaDeSillasYMesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleRentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeNuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.modificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaRentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarRentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarRentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.Cantidad = new System.Windows.Forms.Label();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.dgvDetalleVenta);
            this.groupBox1.Controls.Add(this.Cantidad);
            this.groupBox1.Controls.Add(this.cmbProductos);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 343);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(88, 123);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(169, 23);
            this.txtCantidad.TabIndex = 16;
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
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(6, 196);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(111, 39);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiendaDeAbarrotesToolStripMenuItem,
            this.rentaDeSillasYMesasToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 19);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 25);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiendaDeAbarrotesToolStripMenuItem
            // 
            this.tiendaDeAbarrotesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.registroToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.tiendaDeAbarrotesToolStripMenuItem.Name = "tiendaDeAbarrotesToolStripMenuItem";
            this.tiendaDeAbarrotesToolStripMenuItem.Size = new System.Drawing.Size(139, 21);
            this.tiendaDeAbarrotesToolStripMenuItem.Text = "Tienda de abarrotes";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasToolStripMenuItem,
            this.salidasToolStripMenuItem,
            this.modificarProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.entradasToolStripMenuItem.Text = "Nuevo producto";
            this.entradasToolStripMenuItem.Click += new System.EventHandler(this.entradasToolStripMenuItem_Click);
            // 
            // salidasToolStripMenuItem
            // 
            this.salidasToolStripMenuItem.Name = "salidasToolStripMenuItem";
            this.salidasToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.salidasToolStripMenuItem.Text = "Eliminar producto";
            this.salidasToolStripMenuItem.Click += new System.EventHandler(this.salidasToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDelProveedorToolStripMenuItem,
            this.eliminarProveedorToolStripMenuItem,
            this.modificarProveedorToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // datosDelProveedorToolStripMenuItem
            // 
            this.datosDelProveedorToolStripMenuItem.Name = "datosDelProveedorToolStripMenuItem";
            this.datosDelProveedorToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.datosDelProveedorToolStripMenuItem.Text = "Nuevo proveedor";
            this.datosDelProveedorToolStripMenuItem.Click += new System.EventHandler(this.datosDelProveedorToolStripMenuItem_Click);
            // 
            // rentaDeSillasYMesasToolStripMenuItem
            // 
            this.rentaDeSillasYMesasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prToolStripMenuItem,
            this.detalleRentaToolStripMenuItem});
            this.rentaDeSillasYMesasToolStripMenuItem.Name = "rentaDeSillasYMesasToolStripMenuItem";
            this.rentaDeSillasYMesasToolStripMenuItem.Size = new System.Drawing.Size(155, 21);
            this.rentaDeSillasYMesasToolStripMenuItem.Text = "Renta de Sillas y mesas";
            // 
            // prToolStripMenuItem
            // 
            this.prToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaRentaToolStripMenuItem,
            this.eliminarRentaToolStripMenuItem,
            this.modificarRentaToolStripMenuItem});
            this.prToolStripMenuItem.Name = "prToolStripMenuItem";
            this.prToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.prToolStripMenuItem.Text = "Renta";
            // 
            // detalleRentaToolStripMenuItem
            // 
            this.detalleRentaToolStripMenuItem.Name = "detalleRentaToolStripMenuItem";
            this.detalleRentaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.detalleRentaToolStripMenuItem.Text = "Inventario";
            this.detalleRentaToolStripMenuItem.Click += new System.EventHandler(this.detalleRentaToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeNuevoUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // registroDeNuevoUsuarioToolStripMenuItem
            // 
            this.registroDeNuevoUsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem1,
            this.modificarUsuarioToolStripMenuItem});
            this.registroDeNuevoUsuarioToolStripMenuItem.Name = "registroDeNuevoUsuarioToolStripMenuItem";
            this.registroDeNuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.registroDeNuevoUsuarioToolStripMenuItem.Text = "Control de usuarios";
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.eliminarUsuarioToolStripMenuItem.Text = "Cambiar de usuario";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(139, 196);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 39);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // modificarProductoToolStripMenuItem
            // 
            this.modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            this.modificarProductoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.modificarProductoToolStripMenuItem.Text = "Modificar producto";
            this.modificarProductoToolStripMenuItem.Click += new System.EventHandler(this.modificarProductoToolStripMenuItem_Click);
            // 
            // eliminarProveedorToolStripMenuItem
            // 
            this.eliminarProveedorToolStripMenuItem.Name = "eliminarProveedorToolStripMenuItem";
            this.eliminarProveedorToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.eliminarProveedorToolStripMenuItem.Text = "Eliminar proveedor";
            this.eliminarProveedorToolStripMenuItem.Click += new System.EventHandler(this.eliminarProveedorToolStripMenuItem_Click);
            // 
            // modificarProveedorToolStripMenuItem
            // 
            this.modificarProveedorToolStripMenuItem.Name = "modificarProveedorToolStripMenuItem";
            this.modificarProveedorToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.modificarProveedorToolStripMenuItem.Text = "Modificar proveedor";
            this.modificarProveedorToolStripMenuItem.Click += new System.EventHandler(this.modificarProveedorToolStripMenuItem_Click);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.entradaToolStripMenuItem.Text = "Entradas";
            this.entradaToolStripMenuItem.Click += new System.EventHandler(this.entradaToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // nuevaRentaToolStripMenuItem
            // 
            this.nuevaRentaToolStripMenuItem.Name = "nuevaRentaToolStripMenuItem";
            this.nuevaRentaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.nuevaRentaToolStripMenuItem.Text = "Nueva renta";
            this.nuevaRentaToolStripMenuItem.Click += new System.EventHandler(this.nuevaRentaToolStripMenuItem_Click);
            // 
            // eliminarRentaToolStripMenuItem
            // 
            this.eliminarRentaToolStripMenuItem.Name = "eliminarRentaToolStripMenuItem";
            this.eliminarRentaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.eliminarRentaToolStripMenuItem.Text = "Eliminar renta";
            this.eliminarRentaToolStripMenuItem.Click += new System.EventHandler(this.eliminarRentaToolStripMenuItem_Click);
            // 
            // modificarRentaToolStripMenuItem
            // 
            this.modificarRentaToolStripMenuItem.Name = "modificarRentaToolStripMenuItem";
            this.modificarRentaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.modificarRentaToolStripMenuItem.Text = "Modificar renta";
            this.modificarRentaToolStripMenuItem.Click += new System.EventHandler(this.modificarRentaToolStripMenuItem_Click);
            // 
            // nuevoUsuarioToolStripMenuItem
            // 
            this.nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
            this.nuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.nuevoUsuarioToolStripMenuItem.Text = "Nuevo usuario";
            this.nuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoUsuarioToolStripMenuItem_Click);
            // 
            // eliminarUsuarioToolStripMenuItem1
            // 
            this.eliminarUsuarioToolStripMenuItem1.Name = "eliminarUsuarioToolStripMenuItem1";
            this.eliminarUsuarioToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.eliminarUsuarioToolStripMenuItem1.Text = "Eliminar usuario";
            this.eliminarUsuarioToolStripMenuItem1.Click += new System.EventHandler(this.eliminarUsuarioToolStripMenuItem1_Click);
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.modificarUsuarioToolStripMenuItem.Text = "Modificar usuario";
            this.modificarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuarioToolStripMenuItem_Click);
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
            this.dgvDetalleVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleVenta_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(73, 258);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 39);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
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
            this.colEliminar.Text = "Eliminar";
            this.colEliminar.UseColumnTextForButtonValue = true;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiendaDeAbarrotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDelProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentaDeSillasYMesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleRentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeNuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripMenuItem modificarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaRentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarRentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarRentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuarioToolStripMenuItem;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
    }
}