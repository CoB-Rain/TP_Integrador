namespace Ejercicio_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvLibreria = new System.Windows.Forms.DataGridView();
            this.Cdb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrearProducto = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCdb1 = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnTotalRecaudado = new System.Windows.Forms.Button();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCdb2 = new System.Windows.Forms.TextBox();
            this.numCantidad1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnMostrarSubtotal = new System.Windows.Forms.Button();
            this.lstVentas = new System.Windows.Forms.ListBox();
            this.btnTotalProductosVendidos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibreria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLibreria
            // 
            this.dgvLibreria.AllowUserToOrderColumns = true;
            this.dgvLibreria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibreria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cdb,
            this.Nombre,
            this.desc,
            this.Precio});
            this.dgvLibreria.Location = new System.Drawing.Point(12, 12);
            this.dgvLibreria.Name = "dgvLibreria";
            this.dgvLibreria.Size = new System.Drawing.Size(448, 392);
            this.dgvLibreria.TabIndex = 0;
            // 
            // Cdb
            // 
            this.Cdb.HeaderText = "Codigo de Barras";
            this.Cdb.Name = "Cdb";
            this.Cdb.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // desc
            // 
            this.desc.HeaderText = "Descripcion";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // btnCrearProducto
            // 
            this.btnCrearProducto.Location = new System.Drawing.Point(483, 121);
            this.btnCrearProducto.Name = "btnCrearProducto";
            this.btnCrearProducto.Size = new System.Drawing.Size(117, 46);
            this.btnCrearProducto.TabIndex = 5;
            this.btnCrearProducto.Text = "Crear un producto";
            this.btnCrearProducto.UseVisualStyleBackColor = true;
            this.btnCrearProducto.Click += new System.EventHandler(this.btnCrearProducto_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(553, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(198, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCdb1
            // 
            this.txtCdb1.Location = new System.Drawing.Point(553, 38);
            this.txtCdb1.Name = "txtCdb1";
            this.txtCdb1.Size = new System.Drawing.Size(198, 20);
            this.txtCdb1.TabIndex = 2;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(553, 64);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(198, 20);
            this.txtDesc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "CodigoBarras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "$:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(553, 95);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(198, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // btnTotalRecaudado
            // 
            this.btnTotalRecaudado.Enabled = false;
            this.btnTotalRecaudado.Location = new System.Drawing.Point(483, 597);
            this.btnTotalRecaudado.Name = "btnTotalRecaudado";
            this.btnTotalRecaudado.Size = new System.Drawing.Size(107, 57);
            this.btnTotalRecaudado.TabIndex = 12;
            this.btnTotalRecaudado.Text = "Ver total recaudado";
            this.btnTotalRecaudado.UseVisualStyleBackColor = true;
            this.btnTotalRecaudado.Click += new System.EventHandler(this.btnTotalRecaudado_Click);
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.Enabled = false;
            this.btnRealizarVenta.Location = new System.Drawing.Point(483, 545);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(117, 46);
            this.btnRealizarVenta.TabIndex = 13;
            this.btnRealizarVenta.Text = "Realizar Venta";
            this.btnRealizarVenta.UseVisualStyleBackColor = true;
            this.btnRealizarVenta.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "CodigoBarras";
            // 
            // txtCdb2
            // 
            this.txtCdb2.Location = new System.Drawing.Point(553, 237);
            this.txtCdb2.Name = "txtCdb2";
            this.txtCdb2.Size = new System.Drawing.Size(198, 20);
            this.txtCdb2.TabIndex = 14;
            // 
            // numCantidad1
            // 
            this.numCantidad1.Location = new System.Drawing.Point(553, 263);
            this.numCantidad1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCantidad1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad1.Name = "numCantidad1";
            this.numCantidad1.Size = new System.Drawing.Size(120, 20);
            this.numCantidad1.TabIndex = 16;
            this.numCantidad1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(480, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cantidad";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Enabled = false;
            this.btnAgregarProducto.Location = new System.Drawing.Point(483, 298);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(107, 50);
            this.btnAgregarProducto.TabIndex = 18;
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnMostrarSubtotal
            // 
            this.btnMostrarSubtotal.Enabled = false;
            this.btnMostrarSubtotal.Location = new System.Drawing.Point(483, 354);
            this.btnMostrarSubtotal.Name = "btnMostrarSubtotal";
            this.btnMostrarSubtotal.Size = new System.Drawing.Size(107, 50);
            this.btnMostrarSubtotal.TabIndex = 19;
            this.btnMostrarSubtotal.Text = "Mostrar subtotal";
            this.btnMostrarSubtotal.UseVisualStyleBackColor = true;
            this.btnMostrarSubtotal.Click += new System.EventHandler(this.btnMostrarSubtotal_Click);
            // 
            // lstVentas
            // 
            this.lstVentas.FormattingEnabled = true;
            this.lstVentas.Location = new System.Drawing.Point(13, 411);
            this.lstVentas.Name = "lstVentas";
            this.lstVentas.Size = new System.Drawing.Size(447, 316);
            this.lstVentas.TabIndex = 20;
            // 
            // btnTotalProductosVendidos
            // 
            this.btnTotalProductosVendidos.Enabled = false;
            this.btnTotalProductosVendidos.Location = new System.Drawing.Point(483, 660);
            this.btnTotalProductosVendidos.Name = "btnTotalProductosVendidos";
            this.btnTotalProductosVendidos.Size = new System.Drawing.Size(107, 50);
            this.btnTotalProductosVendidos.TabIndex = 21;
            this.btnTotalProductosVendidos.Text = "Total productos vendidos";
            this.btnTotalProductosVendidos.UseVisualStyleBackColor = true;
            this.btnTotalProductosVendidos.Click += new System.EventHandler(this.btnTotalProductosVendidos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 736);
            this.Controls.Add(this.btnTotalProductosVendidos);
            this.Controls.Add(this.lstVentas);
            this.Controls.Add(this.btnMostrarSubtotal);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numCantidad1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCdb2);
            this.Controls.Add(this.btnRealizarVenta);
            this.Controls.Add(this.btnTotalRecaudado);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtCdb1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCrearProducto);
            this.Controls.Add(this.dgvLibreria);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibreria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibreria;
        private System.Windows.Forms.Button btnCrearProducto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCdb1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cdb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button btnTotalRecaudado;
        private System.Windows.Forms.Button btnRealizarVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCdb2;
        private System.Windows.Forms.NumericUpDown numCantidad1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnMostrarSubtotal;
        private System.Windows.Forms.ListBox lstVentas;
        private System.Windows.Forms.Button btnTotalProductosVendidos;
    }
}

