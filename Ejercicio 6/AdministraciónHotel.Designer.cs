namespace Ejercicio_6
{
    partial class AdministraciónHotel
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
            this.tabHotel = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHuesped = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHabitacionMasSolicitada = new System.Windows.Forms.TextBox();
            this.btnCalcularHabitacion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFinHabitacion = new System.Windows.Forms.MonthCalendar();
            this.dtInicioHabitacion = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcularRecaudacion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecaudacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFin = new System.Windows.Forms.MonthCalendar();
            this.dtInicio = new System.Windows.Forms.MonthCalendar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtRecaudacionTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalcularRecaudacionHotel = new System.Windows.Forms.Button();
            this.tabReservas = new System.Windows.Forms.TabPage();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvIntegrantes = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvAdicionales = new System.Windows.Forms.DataGridView();
            this.btnPagar = new System.Windows.Forms.Button();
            this.tabHotel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionales)).BeginInit();
            this.SuspendLayout();
            // 
            // tabHotel
            // 
            this.tabHotel.Controls.Add(this.groupBox4);
            this.tabHotel.Controls.Add(this.groupBox2);
            this.tabHotel.Controls.Add(this.groupBox3);
            this.tabHotel.Controls.Add(this.groupBox1);
            this.tabHotel.Location = new System.Drawing.Point(4, 33);
            this.tabHotel.Name = "tabHotel";
            this.tabHotel.Size = new System.Drawing.Size(1403, 408);
            this.tabHotel.TabIndex = 3;
            this.tabHotel.Text = "Hotel";
            this.tabHotel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtHuesped);
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Location = new System.Drawing.Point(1024, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 144);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Huesped mas veces hospedado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Huesped:";
            // 
            // txtHuesped
            // 
            this.txtHuesped.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHuesped.Location = new System.Drawing.Point(126, 49);
            this.txtHuesped.Name = "txtHuesped";
            this.txtHuesped.ReadOnly = true;
            this.txtHuesped.Size = new System.Drawing.Size(232, 29);
            this.txtHuesped.TabIndex = 10;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(170, 84);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(141, 53);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtHabitacionMasSolicitada);
            this.groupBox3.Controls.Add(this.btnCalcularHabitacion);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dtFinHabitacion);
            this.groupBox3.Controls.Add(this.dtInicioHabitacion);
            this.groupBox3.Location = new System.Drawing.Point(522, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(496, 367);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Habitacion mas solicitada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Habitación:";
            // 
            // txtHabitacionMasSolicitada
            // 
            this.txtHabitacionMasSolicitada.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHabitacionMasSolicitada.Location = new System.Drawing.Point(146, 244);
            this.txtHabitacionMasSolicitada.Name = "txtHabitacionMasSolicitada";
            this.txtHabitacionMasSolicitada.ReadOnly = true;
            this.txtHabitacionMasSolicitada.Size = new System.Drawing.Size(337, 29);
            this.txtHabitacionMasSolicitada.TabIndex = 7;
            // 
            // btnCalcularHabitacion
            // 
            this.btnCalcularHabitacion.Location = new System.Drawing.Point(180, 279);
            this.btnCalcularHabitacion.Name = "btnCalcularHabitacion";
            this.btnCalcularHabitacion.Size = new System.Drawing.Size(136, 57);
            this.btnCalcularHabitacion.TabIndex = 7;
            this.btnCalcularHabitacion.Text = "Calcular";
            this.btnCalcularHabitacion.UseVisualStyleBackColor = true;
            this.btnCalcularHabitacion.Click += new System.EventHandler(this.btnCalcularHabitacion_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Inicio";
            // 
            // dtFinHabitacion
            // 
            this.dtFinHabitacion.Location = new System.Drawing.Point(256, 70);
            this.dtFinHabitacion.Name = "dtFinHabitacion";
            this.dtFinHabitacion.TabIndex = 8;
            // 
            // dtInicioHabitacion
            // 
            this.dtInicioHabitacion.Location = new System.Drawing.Point(11, 70);
            this.dtInicioHabitacion.Name = "dtInicioHabitacion";
            this.dtInicioHabitacion.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalcularRecaudacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRecaudacion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtFin);
            this.groupBox1.Controls.Add(this.dtInicio);
            this.groupBox1.Location = new System.Drawing.Point(20, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 374);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recaudacion entre fechas";
            // 
            // btnCalcularRecaudacion
            // 
            this.btnCalcularRecaudacion.Location = new System.Drawing.Point(180, 296);
            this.btnCalcularRecaudacion.Name = "btnCalcularRecaudacion";
            this.btnCalcularRecaudacion.Size = new System.Drawing.Size(136, 57);
            this.btnCalcularRecaudacion.TabIndex = 6;
            this.btnCalcularRecaudacion.Text = "Calcular";
            this.btnCalcularRecaudacion.UseVisualStyleBackColor = true;
            this.btnCalcularRecaudacion.Click += new System.EventHandler(this.btnCalcularRecaudacion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Recaudacion:";
            // 
            // txtRecaudacion
            // 
            this.txtRecaudacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRecaudacion.Location = new System.Drawing.Point(146, 261);
            this.txtRecaudacion.Name = "txtRecaudacion";
            this.txtRecaudacion.ReadOnly = true;
            this.txtRecaudacion.Size = new System.Drawing.Size(337, 29);
            this.txtRecaudacion.TabIndex = 4;
            this.txtRecaudacion.Text = "$ 0,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inicio";
            // 
            // dtFin
            // 
            this.dtFin.Location = new System.Drawing.Point(256, 87);
            this.dtFin.Name = "dtFin";
            this.dtFin.TabIndex = 1;
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(11, 87);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHotel);
            this.tabControl1.Controls.Add(this.tabReservas);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1411, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCalcularRecaudacionHotel);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtRecaudacionTotal);
            this.groupBox4.Location = new System.Drawing.Point(1025, 177);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(375, 216);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Recaudacion total del hotel";
            // 
            // txtRecaudacionTotal
            // 
            this.txtRecaudacionTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRecaudacionTotal.Location = new System.Drawing.Point(148, 78);
            this.txtRecaudacionTotal.Name = "txtRecaudacionTotal";
            this.txtRecaudacionTotal.ReadOnly = true;
            this.txtRecaudacionTotal.Size = new System.Drawing.Size(221, 29);
            this.txtRecaudacionTotal.TabIndex = 7;
            this.txtRecaudacionTotal.Text = "$ 0,00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Recaudacion:";
            // 
            // btnCalcularRecaudacionHotel
            // 
            this.btnCalcularRecaudacionHotel.Location = new System.Drawing.Point(194, 113);
            this.btnCalcularRecaudacionHotel.Name = "btnCalcularRecaudacionHotel";
            this.btnCalcularRecaudacionHotel.Size = new System.Drawing.Size(136, 57);
            this.btnCalcularRecaudacionHotel.TabIndex = 7;
            this.btnCalcularRecaudacionHotel.Text = "Calcular";
            this.btnCalcularRecaudacionHotel.UseVisualStyleBackColor = true;
            this.btnCalcularRecaudacionHotel.Click += new System.EventHandler(this.btnCalcularRecaudacionHotel_Click);
            // 
            // tabReservas
            // 
            this.tabReservas.Controls.Add(this.groupBox7);
            this.tabReservas.Controls.Add(this.groupBox6);
            this.tabReservas.Controls.Add(this.groupBox5);
            this.tabReservas.Location = new System.Drawing.Point(4, 33);
            this.tabReservas.Name = "tabReservas";
            this.tabReservas.Padding = new System.Windows.Forms.Padding(3);
            this.tabReservas.Size = new System.Drawing.Size(1403, 408);
            this.tabReservas.TabIndex = 4;
            this.tabReservas.Text = "Reservas";
            this.tabReservas.UseVisualStyleBackColor = true;
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(6, 28);
            this.dgvReservas.MultiSelect = false;
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.Size = new System.Drawing.Size(586, 306);
            this.dgvReservas.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnPagar);
            this.groupBox5.Controls.Add(this.dgvReservas);
            this.groupBox5.Location = new System.Drawing.Point(7, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(598, 392);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reservas";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvIntegrantes);
            this.groupBox6.Location = new System.Drawing.Point(612, 10);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(359, 392);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Integrantes";
            // 
            // dgvIntegrantes
            // 
            this.dgvIntegrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntegrantes.Location = new System.Drawing.Point(6, 28);
            this.dgvIntegrantes.Name = "dgvIntegrantes";
            this.dgvIntegrantes.Size = new System.Drawing.Size(347, 358);
            this.dgvIntegrantes.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvAdicionales);
            this.groupBox7.Location = new System.Drawing.Point(978, 10);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(419, 392);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Adicionales";
            // 
            // dgvAdicionales
            // 
            this.dgvAdicionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdicionales.Location = new System.Drawing.Point(7, 29);
            this.dgvAdicionales.Name = "dgvAdicionales";
            this.dgvAdicionales.Size = new System.Drawing.Size(406, 357);
            this.dgvAdicionales.TabIndex = 0;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(6, 340);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(108, 46);
            this.btnPagar.TabIndex = 1;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // AdministraciónHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1430, 464);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdministraciónHotel";
            this.Text = "AdministraciónHotel";
            this.Load += new System.EventHandler(this.AdministraciónHotel_Load);
            this.tabHotel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabReservas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabHotel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalcularRecaudacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRecaudacion;
        private System.Windows.Forms.MonthCalendar dtFin;
        private System.Windows.Forms.MonthCalendar dtInicio;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar dtInicioHabitacion;
        private System.Windows.Forms.MonthCalendar dtFinHabitacion;
        private System.Windows.Forms.Button btnCalcularHabitacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHabitacionMasSolicitada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHuesped;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCalcularRecaudacionHotel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRecaudacionTotal;
        private System.Windows.Forms.TabPage tabReservas;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvAdicionales;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvIntegrantes;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.DataGridView dgvReservas;
    }
}