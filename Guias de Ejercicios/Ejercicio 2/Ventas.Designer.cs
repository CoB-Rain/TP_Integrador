namespace Ejercicio_2
{
    partial class Ventas
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.cmbSurtidor = new System.Windows.Forms.ComboBox();
            this.txtSurtidores = new System.Windows.Forms.TextBox();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estación de Servicio";
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(255, 331);
            this.btnVender.Margin = new System.Windows.Forms.Padding(6);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(172, 66);
            this.btnVender.TabIndex = 1;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // cmbSurtidor
            // 
            this.cmbSurtidor.FormattingEnabled = true;
            this.cmbSurtidor.Location = new System.Drawing.Point(255, 228);
            this.cmbSurtidor.Margin = new System.Windows.Forms.Padding(6);
            this.cmbSurtidor.Name = "cmbSurtidor";
            this.cmbSurtidor.Size = new System.Drawing.Size(172, 32);
            this.cmbSurtidor.TabIndex = 2;
            this.cmbSurtidor.SelectedIndexChanged += new System.EventHandler(this.cmbSurtidor_SelectedIndexChanged);
            // 
            // txtSurtidores
            // 
            this.txtSurtidores.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSurtidores.Location = new System.Drawing.Point(15, 195);
            this.txtSurtidores.Margin = new System.Windows.Forms.Padding(6);
            this.txtSurtidores.Multiline = true;
            this.txtSurtidores.Name = "txtSurtidores";
            this.txtSurtidores.ReadOnly = true;
            this.txtSurtidores.Size = new System.Drawing.Size(228, 280);
            this.txtSurtidores.TabIndex = 3;
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(256, 293);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(172, 29);
            this.txtLitros.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surtidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Litros";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(255, 409);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(6);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(172, 66);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 490);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.txtSurtidores);
            this.Controls.Add(this.cmbSurtidor);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.ComboBox cmbSurtidor;
        private System.Windows.Forms.TextBox txtSurtidores;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVolver;
    }
}