namespace Ejercicio_6
{
    partial class GestionReservas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvHuespedes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnReservarConAdicionales = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstHuespedes = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHabitacionSeleccionada = new System.Windows.Forms.TextBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numDeposito = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numDuracion = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstAdicionales = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuespedes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeposito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnListar);
            this.groupBox2.Controls.Add(this.dgvHuespedes);
            this.groupBox2.Location = new System.Drawing.Point(901, 407);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 300);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Huespedes";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(198, 241);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(137, 53);
            this.btnListar.TabIndex = 12;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvHuespedes
            // 
            this.dgvHuespedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHuespedes.Location = new System.Drawing.Point(6, 25);
            this.dgvHuespedes.Name = "dgvHuespedes";
            this.dgvHuespedes.Size = new System.Drawing.Size(548, 211);
            this.dgvHuespedes.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvReservas);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1449, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservas";
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(6, 28);
            this.dgvReservas.MultiSelect = false;
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.Size = new System.Drawing.Size(1436, 353);
            this.dgvReservas.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvHabitaciones);
            this.groupBox3.Location = new System.Drawing.Point(901, 713);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 284);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Habitaciones";
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(7, 29);
            this.dgvHabitaciones.MultiSelect = false;
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.Size = new System.Drawing.Size(548, 249);
            this.dgvHabitaciones.TabIndex = 0;
            this.dgvHabitaciones.SelectionChanged += new System.EventHandler(this.dgvHabitaciones_SelectionChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnReservarConAdicionales);
            this.groupBox4.Controls.Add(this.btnCancelar);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lstHuespedes);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtHabitacionSeleccionada);
            this.groupBox4.Controls.Add(this.btnReservar);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.numDeposito);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.numDuracion);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.dtFechaInicio);
            this.groupBox4.Location = new System.Drawing.Point(13, 407);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(882, 245);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nueva Reserva";
            // 
            // btnReservarConAdicionales
            // 
            this.btnReservarConAdicionales.Location = new System.Drawing.Point(127, 171);
            this.btnReservarConAdicionales.Name = "btnReservarConAdicionales";
            this.btnReservarConAdicionales.Size = new System.Drawing.Size(148, 65);
            this.btnReservarConAdicionales.TabIndex = 19;
            this.btnReservarConAdicionales.Text = "Reservar Con Adicionales";
            this.btnReservarConAdicionales.UseVisualStyleBackColor = true;
            this.btnReservarConAdicionales.Click += new System.EventHandler(this.btnReservarConAdicionales_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(461, 171);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 49);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(678, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Huespedes:";
            // 
            // lstHuespedes
            // 
            this.lstHuespedes.FormattingEnabled = true;
            this.lstHuespedes.ItemHeight = 24;
            this.lstHuespedes.Location = new System.Drawing.Point(612, 52);
            this.lstHuespedes.Name = "lstHuespedes";
            this.lstHuespedes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstHuespedes.Size = new System.Drawing.Size(264, 172);
            this.lstHuespedes.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Habitación:";
            // 
            // txtHabitacionSeleccionada
            // 
            this.txtHabitacionSeleccionada.Location = new System.Drawing.Point(116, 136);
            this.txtHabitacionSeleccionada.Name = "txtHabitacionSeleccionada";
            this.txtHabitacionSeleccionada.Size = new System.Drawing.Size(482, 29);
            this.txtHabitacionSeleccionada.TabIndex = 7;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(305, 171);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(137, 49);
            this.btnReservar.TabIndex = 6;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Depósito (mín 10%): $";
            // 
            // numDeposito
            // 
            this.numDeposito.DecimalPlaces = 2;
            this.numDeposito.Location = new System.Drawing.Point(204, 100);
            this.numDeposito.Name = "numDeposito";
            this.numDeposito.Size = new System.Drawing.Size(394, 29);
            this.numDeposito.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Duración (días):";
            // 
            // numDuracion
            // 
            this.numDuracion.Location = new System.Drawing.Point(154, 64);
            this.numDuracion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDuracion.Name = "numDuracion";
            this.numDuracion.Size = new System.Drawing.Size(444, 29);
            this.numDuracion.TabIndex = 2;
            this.numDuracion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDuracion.ValueChanged += new System.EventHandler(this.numDuracion_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de Inicio:";
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Location = new System.Drawing.Point(154, 29);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(444, 29);
            this.dtFechaInicio.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCrear);
            this.groupBox5.Controls.Add(this.numValor);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtNombre);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.lstAdicionales);
            this.groupBox5.Location = new System.Drawing.Point(217, 707);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(509, 284);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Adicionales";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(96, 126);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(136, 51);
            this.btnCrear.TabIndex = 18;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // numValor
            // 
            this.numValor.Location = new System.Drawing.Point(96, 91);
            this.numValor.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(136, 29);
            this.numValor.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Valor: $";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(136, 29);
            this.txtNombre.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Adicionales:";
            // 
            // lstAdicionales
            // 
            this.lstAdicionales.FormattingEnabled = true;
            this.lstAdicionales.ItemHeight = 24;
            this.lstAdicionales.Location = new System.Drawing.Point(238, 58);
            this.lstAdicionales.Name = "lstAdicionales";
            this.lstAdicionales.Size = new System.Drawing.Size(264, 220);
            this.lstAdicionales.TabIndex = 0;
            // 
            // GestionReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 1009);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GestionReservas";
            this.Text = "GestionReservas";
            this.Load += new System.EventHandler(this.GestionReservas_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuespedes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeposito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvHuespedes;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numDuracion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDeposito;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstHuespedes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHabitacionSeleccionada;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstAdicionales;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.Button btnReservarConAdicionales;
        private System.Windows.Forms.Button btnCrear;
    }
}