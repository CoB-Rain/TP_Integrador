namespace Ejercicio_4
{
    partial class Administracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administracion));
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMostrarAfter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMostrarVasos = new System.Windows.Forms.Button();
            this.dgvVasos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCerveza = new System.Windows.Forms.DataGridView();
            this.btnMostrarCerveza = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVasos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCerveza)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAfter
            // 
            this.txtAfter.Location = new System.Drawing.Point(9, 26);
            this.txtAfter.Margin = new System.Windows.Forms.Padding(4);
            this.txtAfter.Multiline = true;
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.Size = new System.Drawing.Size(1438, 267);
            this.txtAfter.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMostrarAfter);
            this.groupBox1.Controls.Add(this.txtAfter);
            this.groupBox1.Location = new System.Drawing.Point(20, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1455, 359);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AfterOffice";
            // 
            // btnMostrarAfter
            // 
            this.btnMostrarAfter.Location = new System.Drawing.Point(9, 298);
            this.btnMostrarAfter.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarAfter.Name = "btnMostrarAfter";
            this.btnMostrarAfter.Size = new System.Drawing.Size(192, 53);
            this.btnMostrarAfter.TabIndex = 1;
            this.btnMostrarAfter.Text = "Mostrar Estadisticas";
            this.btnMostrarAfter.UseVisualStyleBackColor = true;
            this.btnMostrarAfter.Click += new System.EventHandler(this.btnMostrarAfter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMostrarVasos);
            this.groupBox2.Controls.Add(this.dgvVasos);
            this.groupBox2.Location = new System.Drawing.Point(876, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 400);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vasos";
            // 
            // btnMostrarVasos
            // 
            this.btnMostrarVasos.Location = new System.Drawing.Point(7, 311);
            this.btnMostrarVasos.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarVasos.Name = "btnMostrarVasos";
            this.btnMostrarVasos.Size = new System.Drawing.Size(192, 53);
            this.btnMostrarVasos.TabIndex = 2;
            this.btnMostrarVasos.Text = "Mostrar Estadisticas";
            this.btnMostrarVasos.UseVisualStyleBackColor = true;
            this.btnMostrarVasos.Click += new System.EventHandler(this.btnMostrarVasos_Click);
            // 
            // dgvVasos
            // 
            this.dgvVasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVasos.Location = new System.Drawing.Point(7, 26);
            this.dgvVasos.Name = "dgvVasos";
            this.dgvVasos.Size = new System.Drawing.Size(586, 278);
            this.dgvVasos.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMostrarCerveza);
            this.groupBox3.Controls.Add(this.dgvCerveza);
            this.groupBox3.Location = new System.Drawing.Point(20, 385);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(839, 400);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cerveza";
            // 
            // dgvCerveza
            // 
            this.dgvCerveza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCerveza.Location = new System.Drawing.Point(6, 23);
            this.dgvCerveza.Name = "dgvCerveza";
            this.dgvCerveza.Size = new System.Drawing.Size(827, 281);
            this.dgvCerveza.TabIndex = 0;
            // 
            // btnMostrarCerveza
            // 
            this.btnMostrarCerveza.Location = new System.Drawing.Point(6, 311);
            this.btnMostrarCerveza.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarCerveza.Name = "btnMostrarCerveza";
            this.btnMostrarCerveza.Size = new System.Drawing.Size(192, 53);
            this.btnMostrarCerveza.TabIndex = 3;
            this.btnMostrarCerveza.Text = "Mostrar Estadisticas";
            this.btnMostrarCerveza.UseVisualStyleBackColor = true;
            this.btnMostrarCerveza.Click += new System.EventHandler(this.btnMostrarCerveza_Click);
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ejercicio_4.Properties.Resources.AfterOffice;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1487, 797);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Administracion";
            this.Text = "Administracion";
            this.Load += new System.EventHandler(this.Administracion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVasos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCerveza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAfter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrarAfter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMostrarVasos;
        private System.Windows.Forms.DataGridView dgvVasos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMostrarCerveza;
        private System.Windows.Forms.DataGridView dgvCerveza;
    }
}