namespace Ejercicio_6
{
    partial class GestionHabitaciones
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
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.rdConVistaAlMar = new System.Windows.Forms.RadioButton();
            this.rdSinVistaAlMar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHabitaciones);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1442, 619);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Habitaciones";
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(7, 29);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.ReadOnly = true;
            this.dgvHabitaciones.Size = new System.Drawing.Size(1429, 584);
            this.dgvHabitaciones.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCrear);
            this.groupBox2.Controls.Add(this.rdConVistaAlMar);
            this.groupBox2.Controls.Add(this.rdSinVistaAlMar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbTipoHabitacion);
            this.groupBox2.Location = new System.Drawing.Point(481, 638);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nueva Habitacion";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(100, 125);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(134, 50);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // rdConVistaAlMar
            // 
            this.rdConVistaAlMar.AutoSize = true;
            this.rdConVistaAlMar.Location = new System.Drawing.Point(177, 91);
            this.rdConVistaAlMar.Name = "rdConVistaAlMar";
            this.rdConVistaAlMar.Size = new System.Drawing.Size(160, 28);
            this.rdConVistaAlMar.TabIndex = 3;
            this.rdConVistaAlMar.Text = "Con vista al mar";
            this.rdConVistaAlMar.UseVisualStyleBackColor = true;
            // 
            // rdSinVistaAlMar
            // 
            this.rdSinVistaAlMar.AutoSize = true;
            this.rdSinVistaAlMar.Checked = true;
            this.rdSinVistaAlMar.Location = new System.Drawing.Point(19, 91);
            this.rdSinVistaAlMar.Name = "rdSinVistaAlMar";
            this.rdSinVistaAlMar.Size = new System.Drawing.Size(152, 28);
            this.rdSinVistaAlMar.TabIndex = 2;
            this.rdSinVistaAlMar.TabStop = true;
            this.rdSinVistaAlMar.Text = "Sin vista al mar";
            this.rdSinVistaAlMar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo:";
            // 
            // cmbTipoHabitacion
            // 
            this.cmbTipoHabitacion.FormattingEnabled = true;
            this.cmbTipoHabitacion.Location = new System.Drawing.Point(74, 53);
            this.cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            this.cmbTipoHabitacion.Size = new System.Drawing.Size(262, 32);
            this.cmbTipoHabitacion.TabIndex = 0;
            // 
            // GestionHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GestionHabitaciones";
            this.Text = "GestionHabitaciones";
            this.Load += new System.EventHandler(this.GestionHabitaciones_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoHabitacion;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.RadioButton rdConVistaAlMar;
        private System.Windows.Forms.RadioButton rdSinVistaAlMar;
    }
}