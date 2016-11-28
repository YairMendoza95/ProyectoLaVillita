namespace ProyectoLaVillita.UI.WF.Productos
{
    partial class ModificarProducto
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiendaDeAbarrotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentaDeSillasYMesasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaRentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDelClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarRentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarRentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeNuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarDeUsuariioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIngresarNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMaximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dgvProductos);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 474);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sistema de inventario \"La Villita\"";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(194, 420);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 39);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(695, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiendaDeAbarrotesToolStripMenuItem
            // 
            this.tiendaDeAbarrotesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.tiendaDeAbarrotesToolStripMenuItem.Name = "tiendaDeAbarrotesToolStripMenuItem";
            this.tiendaDeAbarrotesToolStripMenuItem.Size = new System.Drawing.Size(139, 21);
            this.tiendaDeAbarrotesToolStripMenuItem.Text = "Tienda de abarrotes";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeProductosToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem,
            this.modificarProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // registroDeProductosToolStripMenuItem
            // 
            this.registroDeProductosToolStripMenuItem.Name = "registroDeProductosToolStripMenuItem";
            this.registroDeProductosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.registroDeProductosToolStripMenuItem.Text = "Nuevo producto";
            this.registroDeProductosToolStripMenuItem.Click += new System.EventHandler(this.registroDeProductosToolStripMenuItem_Click);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar producto";
            this.eliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem_Click);
            // 
            // modificarProductoToolStripMenuItem
            // 
            this.modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            this.modificarProductoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.modificarProductoToolStripMenuItem.Text = "Modificar producto";
            this.modificarProductoToolStripMenuItem.Click += new System.EventHandler(this.modificarProductoToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeProveedoresToolStripMenuItem,
            this.eliminarProveedorToolStripMenuItem,
            this.modificarProveedorToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // registroDeProveedoresToolStripMenuItem
            // 
            this.registroDeProveedoresToolStripMenuItem.Name = "registroDeProveedoresToolStripMenuItem";
            this.registroDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.registroDeProveedoresToolStripMenuItem.Text = "Nuevo proveedor";
            this.registroDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.registroDeProveedoresToolStripMenuItem_Click);
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
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.entradasToolStripMenuItem.Text = "Entradas";
            this.entradasToolStripMenuItem.Click += new System.EventHandler(this.entradasToolStripMenuItem_Click);
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
            this.eliminarRentaToolStripMenuItem,
            this.modificarRentaToolStripMenuItem});
            this.nuevaRentaToolStripMenuItem.Name = "nuevaRentaToolStripMenuItem";
            this.nuevaRentaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevaRentaToolStripMenuItem.Text = "Renta";
            // 
            // datosDelClienteToolStripMenuItem
            // 
            this.datosDelClienteToolStripMenuItem.Name = "datosDelClienteToolStripMenuItem";
            this.datosDelClienteToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.datosDelClienteToolStripMenuItem.Text = "Nueva renta";
            this.datosDelClienteToolStripMenuItem.Click += new System.EventHandler(this.datosDelClienteToolStripMenuItem_Click);
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
            // inventarioToolStripMenuItem1
            // 
            this.inventarioToolStripMenuItem1.Name = "inventarioToolStripMenuItem1";
            this.inventarioToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
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
            this.eliminarUsuarioToolStripMenuItem,
            this.modificarUsuarioToolStripMenuItem});
            this.registroDeNuevoUsuarioToolStripMenuItem.Name = "registroDeNuevoUsuarioToolStripMenuItem";
            this.registroDeNuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.registroDeNuevoUsuarioToolStripMenuItem.Text = "Control de usuarios";
            // 
            // nuevoUsuarioToolStripMenuItem
            // 
            this.nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
            this.nuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.nuevoUsuarioToolStripMenuItem.Text = "Nuevo usuario";
            this.nuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoUsuarioToolStripMenuItem_Click);
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar usuario";
            this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuarioToolStripMenuItem_Click);
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.modificarUsuarioToolStripMenuItem.Text = "Modificar usuario";
            this.modificarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuarioToolStripMenuItem_Click);
            // 
            // cambiarDeUsuariioToolStripMenuItem
            // 
            this.cambiarDeUsuariioToolStripMenuItem.Name = "cambiarDeUsuariioToolStripMenuItem";
            this.cambiarDeUsuariioToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.cambiarDeUsuariioToolStripMenuItem.Text = "Cambiar de Usuario";
            this.cambiarDeUsuariioToolStripMenuItem.Click += new System.EventHandler(this.cambiarDeUsuariioToolStripMenuItem_Click);
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
            this.btnSalir.Location = new System.Drawing.Point(396, 420);
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
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombre,
            this.idProveedor,
            this.precioUnitario,
            this.stockActual,
            this.stockMaximo,
            this.stockMinimo});
            this.dgvProductos.Location = new System.Drawing.Point(10, 150);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(676, 255);
            this.dgvProductos.TabIndex = 1;
            // 
            // idProducto
            // 
            this.idProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idProducto.HeaderText = "Id";
            this.idProducto.Name = "idProducto";
            this.idProducto.Width = 46;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // idProveedor
            // 
            this.idProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idProveedor.HeaderText = "Proveedor";
            this.idProveedor.Name = "idProveedor";
            // 
            // precioUnitario
            // 
            this.precioUnitario.HeaderText = "Costo Unitario";
            this.precioUnitario.Name = "precioUnitario";
            // 
            // stockActual
            // 
            this.stockActual.HeaderText = "Total en Inventario";
            this.stockActual.Name = "stockActual";
            // 
            // stockMaximo
            // 
            this.stockMaximo.HeaderText = "Stock Máximo";
            this.stockMaximo.Name = "stockMaximo";
            // 
            // stockMinimo
            // 
            this.stockMinimo.HeaderText = "Stock Mínimo";
            this.stockMinimo.Name = "stockMinimo";
            // 
            // ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 472);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificarProducto";
            this.Text = "Sistema de inventario \"La Villita\"";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiendaDeAbarrotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentaDeSillasYMesasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevaRentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDelClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarRentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarRentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeNuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarDeUsuariioToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIngresarNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMaximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMinimo;
    }
}