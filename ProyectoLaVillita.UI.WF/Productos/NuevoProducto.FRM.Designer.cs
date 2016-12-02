namespace ProyectoLaVillita.UI.WF.Productos
{
    partial class NuevoProducto
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
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtMinimo = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtMaximo = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.cmbProveedor = new System.Windows.Forms.ComboBox();
			this.proveedorManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.txtCostoUnitario = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
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
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.proveedorManagerBindingSource)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
			this.groupBox1.Controls.Add(this.menuStrip1);
			this.groupBox1.Controls.Add(this.txtMinimo);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtMaximo);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.btnGuardar);
			this.groupBox1.Controls.Add(this.btnSalir);
			this.groupBox1.Controls.Add(this.cmbProveedor);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtCostoUnitario);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(664, 319);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nuevo producto";
			// 
			// txtMinimo
			// 
			this.txtMinimo.Location = new System.Drawing.Point(310, 207);
			this.txtMinimo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtMinimo.Name = "txtMinimo";
			this.txtMinimo.Size = new System.Drawing.Size(162, 23);
			this.txtMinimo.TabIndex = 21;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(206, 210);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(94, 16);
			this.label8.TabIndex = 20;
			this.label8.Text = "Stock Mínimo";
			// 
			// txtMaximo
			// 
			this.txtMaximo.Location = new System.Drawing.Point(310, 176);
			this.txtMaximo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtMaximo.Name = "txtMaximo";
			this.txtMaximo.Size = new System.Drawing.Size(162, 23);
			this.txtMaximo.TabIndex = 19;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(206, 179);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(99, 16);
			this.label7.TabIndex = 18;
			this.label7.Text = "Stock Máximo";
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
			// btnGuardar
			// 
			this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Location = new System.Drawing.Point(152, 254);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(127, 39);
			this.btnGuardar.TabIndex = 13;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(434, 254);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(127, 39);
			this.btnSalir.TabIndex = 10;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// cmbProveedor
			// 
			this.cmbProveedor.DataSource = this.proveedorManagerBindingSource;
			this.cmbProveedor.FormattingEnabled = true;
			this.cmbProveedor.Location = new System.Drawing.Point(310, 145);
			this.cmbProveedor.Name = "cmbProveedor";
			this.cmbProveedor.Size = new System.Drawing.Size(162, 24);
			this.cmbProveedor.TabIndex = 11;
			// 
			// proveedorManagerBindingSource
			// 
			this.proveedorManagerBindingSource.DataSource = typeof(ProyectoLaVillita.BIZ.ProveedorManager);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(206, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 16);
			this.label5.TabIndex = 10;
			this.label5.Text = "Proveedor";
			// 
			// txtCostoUnitario
			// 
			this.txtCostoUnitario.Location = new System.Drawing.Point(310, 115);
			this.txtCostoUnitario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtCostoUnitario.Name = "txtCostoUnitario";
			this.txtCostoUnitario.Size = new System.Drawing.Size(162, 23);
			this.txtCostoUnitario.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(206, 118);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Costo Unitario";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(310, 84);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(162, 23);
			this.txtNombre.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(206, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Nombre";
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
			this.menuStrip1.Size = new System.Drawing.Size(658, 25);
			this.menuStrip1.TabIndex = 22;
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
			// 
			// inventarioToolStripMenuItem2
			// 
			this.inventarioToolStripMenuItem2.Name = "inventarioToolStripMenuItem2";
			this.inventarioToolStripMenuItem2.Size = new System.Drawing.Size(175, 22);
			this.inventarioToolStripMenuItem2.Text = "Inventario";
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
			// 
			// modificarProveedorToolStripMenuItem
			// 
			this.modificarProveedorToolStripMenuItem.Name = "modificarProveedorToolStripMenuItem";
			this.modificarProveedorToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
			this.modificarProveedorToolStripMenuItem.Text = "Listado de proveedores";
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
			// 
			// ventasToolStripMenuItem
			// 
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
			// 
			// modificarRentaToolStripMenuItem
			// 
			this.modificarRentaToolStripMenuItem.Name = "modificarRentaToolStripMenuItem";
			this.modificarRentaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.modificarRentaToolStripMenuItem.Text = "Listado de rentas";
			// 
			// inventarioToolStripMenuItem1
			// 
			this.inventarioToolStripMenuItem1.Name = "inventarioToolStripMenuItem1";
			this.inventarioToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
			this.inventarioToolStripMenuItem1.Text = "Inventario";
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
			// 
			// modificarUsuarioToolStripMenuItem
			// 
			this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
			this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.modificarUsuarioToolStripMenuItem.Text = "Listado de usuarios";
			// 
			// cambiarDeUsuariioToolStripMenuItem
			// 
			this.cambiarDeUsuariioToolStripMenuItem.Name = "cambiarDeUsuariioToolStripMenuItem";
			this.cambiarDeUsuariioToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.cambiarDeUsuariioToolStripMenuItem.Text = "Cambiar de Usuario";
			// 
			// NuevoProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(664, 317);
			this.Controls.Add(this.groupBox1);
			this.Name = "NuevoProducto";
			this.Text = "Sistema de inventario \"La Villita\"";
			this.Load += new System.EventHandler(this.NuevoProducto_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.proveedorManagerBindingSource)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCostoUnitario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource proveedorManagerBindingSource;
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
	}
}