namespace Ejercicio_4
{
    partial class Barriles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barriles));
            this.dgvBarriles = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMostrarBasica = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCervezaOrigen = new System.Windows.Forms.ComboBox();
            this.cmbCervezaSabor = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvInformacionAvanzada = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarFecha = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarriles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacionAvanzada)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBarriles
            // 
            this.dgvBarriles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarriles.Location = new System.Drawing.Point(9, 25);
            this.dgvBarriles.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvBarriles.Name = "dgvBarriles";
            this.dgvBarriles.Size = new System.Drawing.Size(605, 236);
            this.dgvBarriles.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(103, 131);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 44);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBarriles);
            this.groupBox1.Location = new System.Drawing.Point(20, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(625, 268);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Basica";
            this.groupBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMostrarBasica);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.btnRecargar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbCervezaOrigen);
            this.groupBox2.Controls.Add(this.cmbCervezaSabor);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Location = new System.Drawing.Point(652, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(308, 268);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuevo Barril";
            // 
            // btnMostrarBasica
            // 
            this.btnMostrarBasica.Location = new System.Drawing.Point(31, 217);
            this.btnMostrarBasica.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnMostrarBasica.Name = "btnMostrarBasica";
            this.btnMostrarBasica.Size = new System.Drawing.Size(130, 44);
            this.btnMostrarBasica.TabIndex = 12;
            this.btnMostrarBasica.Text = "Ver Lista Basica";
            this.btnMostrarBasica.UseVisualStyleBackColor = true;
            this.btnMostrarBasica.Click += new System.EventHandler(this.btnMostrarBasica_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPrecio.Location = new System.Drawing.Point(69, 101);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(200, 24);
            this.txtPrecio.TabIndex = 8;
            this.txtPrecio.Text = "$ 0.0";
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(171, 217);
            this.btnRecargar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(130, 44);
            this.btnRecargar.TabIndex = 7;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contenido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Origen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sabor:";
            // 
            // cmbCervezaOrigen
            // 
            this.cmbCervezaOrigen.FormattingEnabled = true;
            this.cmbCervezaOrigen.Location = new System.Drawing.Point(69, 72);
            this.cmbCervezaOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCervezaOrigen.Name = "cmbCervezaOrigen";
            this.cmbCervezaOrigen.Size = new System.Drawing.Size(200, 26);
            this.cmbCervezaOrigen.TabIndex = 3;
            this.cmbCervezaOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbCervezaOrigen_SelectedIndexChanged);
            // 
            // cmbCervezaSabor
            // 
            this.cmbCervezaSabor.FormattingEnabled = true;
            this.cmbCervezaSabor.Location = new System.Drawing.Point(69, 43);
            this.cmbCervezaSabor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCervezaSabor.Name = "cmbCervezaSabor";
            this.cmbCervezaSabor.Size = new System.Drawing.Size(200, 26);
            this.cmbCervezaSabor.TabIndex = 2;
            this.cmbCervezaSabor.SelectedIndexChanged += new System.EventHandler(this.cmbCervezaSabor_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvInformacionAvanzada);
            this.groupBox3.Location = new System.Drawing.Point(20, 291);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(1186, 389);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Avanzada";
            this.groupBox3.Visible = false;
            // 
            // dgvInformacionAvanzada
            // 
            this.dgvInformacionAvanzada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformacionAvanzada.Location = new System.Drawing.Point(9, 21);
            this.dgvInformacionAvanzada.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInformacionAvanzada.Name = "dgvInformacionAvanzada";
            this.dgvInformacionAvanzada.Size = new System.Drawing.Size(1172, 364);
            this.dgvInformacionAvanzada.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.btnAgregarFecha);
            this.groupBox4.Controls.Add(this.btnMostrar);
            this.groupBox4.Controls.Add(this.btnActualizar);
            this.groupBox4.Location = new System.Drawing.Point(965, 18);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(234, 268);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Información Avanzada";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // btnAgregarFecha
            // 
            this.btnAgregarFecha.Location = new System.Drawing.Point(50, 74);
            this.btnAgregarFecha.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAgregarFecha.Name = "btnAgregarFecha";
            this.btnAgregarFecha.Size = new System.Drawing.Size(130, 44);
            this.btnAgregarFecha.TabIndex = 14;
            this.btnAgregarFecha.Text = "Agregar Fecha";
            this.btnAgregarFecha.UseVisualStyleBackColor = true;
            this.btnAgregarFecha.Click += new System.EventHandler(this.btnAgregarFecha_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(7, 217);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(106, 44);
            this.btnMostrar.TabIndex = 11;
            this.btnMostrar.Text = "Ver Lista Avanzada";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(121, 217);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(106, 44);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar  Lista";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Barriles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ejercicio_4.Properties.Resources.Barriles;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1215, 689);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Barriles";
            this.Text = "Barriles";
            this.Load += new System.EventHandler(this.Barriles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarriles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacionAvanzada)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBarriles;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCervezaOrigen;
        private System.Windows.Forms.ComboBox cmbCervezaSabor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvInformacionAvanzada;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnMostrarBasica;
        private System.Windows.Forms.Button btnAgregarFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}