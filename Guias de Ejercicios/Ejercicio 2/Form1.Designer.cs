namespace Ejercicio_2
{
    partial class Administración
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
            this.lstNafta = new System.Windows.Forms.ListBox();
            this.lstSurtidores = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAsignarNafta = new System.Windows.Forms.Button();
            this.cmbAsignarNafta = new System.Windows.Forms.ComboBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSurtidor = new System.Windows.Forms.ComboBox();
            this.btnInspeccionar = new System.Windows.Forms.Button();
            this.txtSurtidorData = new System.Windows.Forms.TextBox();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEstadisticas = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnRealizarVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNafta
            // 
            this.lstNafta.FormattingEnabled = true;
            this.lstNafta.ItemHeight = 24;
            this.lstNafta.Location = new System.Drawing.Point(16, 51);
            this.lstNafta.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lstNafta.Name = "lstNafta";
            this.lstNafta.Size = new System.Drawing.Size(298, 220);
            this.lstNafta.TabIndex = 0;
            this.lstNafta.SelectedIndexChanged += new System.EventHandler(this.lstNafta_SelectedIndexChanged);
            // 
            // lstSurtidores
            // 
            this.lstSurtidores.FormattingEnabled = true;
            this.lstSurtidores.ItemHeight = 24;
            this.lstSurtidores.Location = new System.Drawing.Point(15, 307);
            this.lstSurtidores.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lstSurtidores.Name = "lstSurtidores";
            this.lstSurtidores.Size = new System.Drawing.Size(299, 220);
            this.lstSurtidores.TabIndex = 1;
            this.lstSurtidores.SelectedIndexChanged += new System.EventHandler(this.lstSurtidores_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipos de Nafta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surtidores";
            // 
            // btnAsignarNafta
            // 
            this.btnAsignarNafta.Location = new System.Drawing.Point(447, 458);
            this.btnAsignarNafta.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAsignarNafta.Name = "btnAsignarNafta";
            this.btnAsignarNafta.Size = new System.Drawing.Size(223, 61);
            this.btnAsignarNafta.TabIndex = 4;
            this.btnAsignarNafta.Text = "Asignar Nafta";
            this.btnAsignarNafta.UseVisualStyleBackColor = true;
            this.btnAsignarNafta.Click += new System.EventHandler(this.btnAsignarNafta_Click);
            // 
            // cmbAsignarNafta
            // 
            this.cmbAsignarNafta.FormattingEnabled = true;
            this.cmbAsignarNafta.Location = new System.Drawing.Point(447, 415);
            this.cmbAsignarNafta.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbAsignarNafta.Name = "cmbAsignarNafta";
            this.cmbAsignarNafta.Size = new System.Drawing.Size(221, 32);
            this.cmbAsignarNafta.TabIndex = 5;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCapacidad.Location = new System.Drawing.Point(447, 367);
            this.txtCapacidad.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.ReadOnly = true;
            this.txtCapacidad.Size = new System.Drawing.Size(221, 29);
            this.txtCapacidad.TabIndex = 6;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNumero.Location = new System.Drawing.Point(447, 319);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(221, 29);
            this.txtNumero.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 333);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Número:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 373);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Capacidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 421);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nafta:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNombre.Location = new System.Drawing.Point(447, 51);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(221, 29);
            this.txtNombre.TabIndex = 11;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPrecio.Location = new System.Drawing.Point(447, 99);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(221, 29);
            this.txtPrecio.TabIndex = 12;
            this.txtPrecio.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Precio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1032, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 73);
            this.label8.TabIndex = 15;
            this.label8.Text = "Gestión";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(682, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 504);
            this.label9.TabIndex = 16;
            this.label9.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // cmbSurtidor
            // 
            this.cmbSurtidor.FormattingEnabled = true;
            this.cmbSurtidor.Location = new System.Drawing.Point(744, 321);
            this.cmbSurtidor.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbSurtidor.Name = "cmbSurtidor";
            this.cmbSurtidor.Size = new System.Drawing.Size(218, 32);
            this.cmbSurtidor.TabIndex = 17;
            // 
            // btnInspeccionar
            // 
            this.btnInspeccionar.Location = new System.Drawing.Point(1019, 450);
            this.btnInspeccionar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnInspeccionar.Name = "btnInspeccionar";
            this.btnInspeccionar.Size = new System.Drawing.Size(167, 77);
            this.btnInspeccionar.TabIndex = 18;
            this.btnInspeccionar.Text = "Inspeccionar";
            this.btnInspeccionar.UseVisualStyleBackColor = true;
            this.btnInspeccionar.Click += new System.EventHandler(this.btnInspeccionar_Click);
            // 
            // txtSurtidorData
            // 
            this.txtSurtidorData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSurtidorData.Location = new System.Drawing.Point(704, 363);
            this.txtSurtidorData.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSurtidorData.Multiline = true;
            this.txtSurtidorData.Name = "txtSurtidorData";
            this.txtSurtidorData.ReadOnly = true;
            this.txtSurtidorData.Size = new System.Drawing.Size(303, 164);
            this.txtSurtidorData.TabIndex = 19;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(1019, 363);
            this.btnRecargar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(167, 77);
            this.btnRecargar.TabIndex = 20;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(747, 292);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Información por Surtidor";
            // 
            // txtEstadisticas
            // 
            this.txtEstadisticas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEstadisticas.Location = new System.Drawing.Point(1219, 119);
            this.txtEstadisticas.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtEstadisticas.Multiline = true;
            this.txtEstadisticas.Name = "txtEstadisticas";
            this.txtEstadisticas.ReadOnly = true;
            this.txtEstadisticas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEstadisticas.Size = new System.Drawing.Size(479, 408);
            this.txtEstadisticas.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1193, 119);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 408);
            this.label11.TabIndex = 23;
            this.label11.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(1710, 119);
            this.btnEstadisticas.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(138, 59);
            this.btnEstadisticas.TabIndex = 24;
            this.btnEstadisticas.Text = "Estadisticas Estacion";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnRealizarVentas
            // 
            this.btnRealizarVentas.Location = new System.Drawing.Point(1710, 188);
            this.btnRealizarVentas.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRealizarVentas.Name = "btnRealizarVentas";
            this.btnRealizarVentas.Size = new System.Drawing.Size(138, 59);
            this.btnRealizarVentas.TabIndex = 25;
            this.btnRealizarVentas.Text = "Realizar Ventas";
            this.btnRealizarVentas.UseVisualStyleBackColor = true;
            this.btnRealizarVentas.Click += new System.EventHandler(this.btnRealizarVentas_Click);
            // 
            // Administración
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1859, 541);
            this.Controls.Add(this.btnRealizarVentas);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEstadisticas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.txtSurtidorData);
            this.Controls.Add(this.btnInspeccionar);
            this.Controls.Add(this.cmbSurtidor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.cmbAsignarNafta);
            this.Controls.Add(this.btnAsignarNafta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSurtidores);
            this.Controls.Add(this.lstNafta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Administración";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNafta;
        private System.Windows.Forms.ListBox lstSurtidores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAsignarNafta;
        private System.Windows.Forms.ComboBox cmbAsignarNafta;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSurtidor;
        private System.Windows.Forms.Button btnInspeccionar;
        private System.Windows.Forms.TextBox txtSurtidorData;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEstadisticas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnRealizarVentas;
    }
}

