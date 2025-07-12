namespace Ejercicio_9
{
    partial class RegistroCuerpoCeleste
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
            this.tabEditarEstrella = new System.Windows.Forms.TabPage();
            this.tabCargaCuerpoCeleste = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbObservadorCarga = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCuerpoCelesteCarga = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvObjetosEncontrados = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEditarPlaneta = new System.Windows.Forms.TabPage();
            this.tabEditarSatelite = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCuerpoCelesteAEditar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabCargaCuerpoCeleste.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetosEncontrados)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEditarEstrella
            // 
            this.tabEditarEstrella.Location = new System.Drawing.Point(4, 33);
            this.tabEditarEstrella.Name = "tabEditarEstrella";
            this.tabEditarEstrella.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditarEstrella.Size = new System.Drawing.Size(1435, 579);
            this.tabEditarEstrella.TabIndex = 1;
            this.tabEditarEstrella.Text = "Editar Estrella";
            this.tabEditarEstrella.UseVisualStyleBackColor = true;
            // 
            // tabCargaCuerpoCeleste
            // 
            this.tabCargaCuerpoCeleste.Controls.Add(this.groupBox3);
            this.tabCargaCuerpoCeleste.Controls.Add(this.groupBox2);
            this.tabCargaCuerpoCeleste.Controls.Add(this.groupBox1);
            this.tabCargaCuerpoCeleste.Location = new System.Drawing.Point(4, 33);
            this.tabCargaCuerpoCeleste.Name = "tabCargaCuerpoCeleste";
            this.tabCargaCuerpoCeleste.Padding = new System.Windows.Forms.Padding(3);
            this.tabCargaCuerpoCeleste.Size = new System.Drawing.Size(1435, 579);
            this.tabCargaCuerpoCeleste.TabIndex = 0;
            this.tabCargaCuerpoCeleste.Text = "Carga cuerpo celeste";
            this.tabCargaCuerpoCeleste.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMasa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.cmbCuerpoCelesteCarga);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbObservadorCarga);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Observador que lo encontro:";
            // 
            // cmbObservadorCarga
            // 
            this.cmbObservadorCarga.FormattingEnabled = true;
            this.cmbObservadorCarga.Location = new System.Drawing.Point(18, 128);
            this.cmbObservadorCarga.Name = "cmbObservadorCarga";
            this.cmbObservadorCarga.Size = new System.Drawing.Size(248, 32);
            this.cmbObservadorCarga.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cuerpo celeste encontrado:";
            // 
            // cmbCuerpoCelesteCarga
            // 
            this.cmbCuerpoCelesteCarga.FormattingEnabled = true;
            this.cmbCuerpoCelesteCarga.Location = new System.Drawing.Point(18, 57);
            this.cmbCuerpoCelesteCarga.Name = "cmbCuerpoCelesteCarga";
            this.cmbCuerpoCelesteCarga.Size = new System.Drawing.Size(248, 32);
            this.cmbCuerpoCelesteCarga.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 196);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(222, 29);
            this.txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(104, 231);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(222, 29);
            this.txtEdad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Edad:";
            // 
            // txtMasa
            // 
            this.txtMasa.Location = new System.Drawing.Point(104, 266);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(222, 29);
            this.txtMasa.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Masa:";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(394, 216);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(130, 54);
            this.btnCargar.TabIndex = 11;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(67, 126);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(130, 54);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvObjetosEncontrados);
            this.groupBox2.Location = new System.Drawing.Point(616, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(813, 565);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Objetos encontrados";
            // 
            // dgvObjetosEncontrados
            // 
            this.dgvObjetosEncontrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjetosEncontrados.Location = new System.Drawing.Point(7, 29);
            this.dgvObjetosEncontrados.MultiSelect = false;
            this.dgvObjetosEncontrados.Name = "dgvObjetosEncontrados";
            this.dgvObjetosEncontrados.Size = new System.Drawing.Size(800, 530);
            this.dgvObjetosEncontrados.TabIndex = 0;
            this.dgvObjetosEncontrados.SelectionChanged += new System.EventHandler(this.dgvObjetosEncontrados_SelectionChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCargaCuerpoCeleste);
            this.tabControl1.Controls.Add(this.tabEditarEstrella);
            this.tabControl1.Controls.Add(this.tabEditarPlaneta);
            this.tabControl1.Controls.Add(this.tabEditarSatelite);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1443, 616);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabEditarPlaneta
            // 
            this.tabEditarPlaneta.Location = new System.Drawing.Point(4, 33);
            this.tabEditarPlaneta.Name = "tabEditarPlaneta";
            this.tabEditarPlaneta.Size = new System.Drawing.Size(1435, 579);
            this.tabEditarPlaneta.TabIndex = 2;
            this.tabEditarPlaneta.Text = "Editar Planeta";
            this.tabEditarPlaneta.UseVisualStyleBackColor = true;
            // 
            // tabEditarSatelite
            // 
            this.tabEditarSatelite.Location = new System.Drawing.Point(4, 33);
            this.tabEditarSatelite.Name = "tabEditarSatelite";
            this.tabEditarSatelite.Size = new System.Drawing.Size(1435, 579);
            this.tabEditarSatelite.TabIndex = 3;
            this.tabEditarSatelite.Text = "Editar Satelite";
            this.tabEditarSatelite.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtCuerpoCelesteAEditar);
            this.groupBox3.Controls.Add(this.btnEditar);
            this.groupBox3.Location = new System.Drawing.Point(334, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 203);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Editar objeto";
            // 
            // txtCuerpoCelesteAEditar
            // 
            this.txtCuerpoCelesteAEditar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCuerpoCelesteAEditar.Location = new System.Drawing.Point(17, 81);
            this.txtCuerpoCelesteAEditar.Name = "txtCuerpoCelesteAEditar";
            this.txtCuerpoCelesteAEditar.ReadOnly = true;
            this.txtCuerpoCelesteAEditar.Size = new System.Drawing.Size(240, 29);
            this.txtCuerpoCelesteAEditar.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cuerpo celeste a editar:";
            // 
            // RegistroCuerpoCeleste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 630);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RegistroCuerpoCeleste";
            this.Text = "RegistroCuerpoCeleste";
            this.Load += new System.EventHandler(this.RegistroCuerpoCeleste_Load);
            this.tabCargaCuerpoCeleste.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetosEncontrados)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabEditarEstrella;
        private System.Windows.Forms.TabPage tabCargaCuerpoCeleste;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvObjetosEncontrados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbCuerpoCelesteCarga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbObservadorCarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEditarPlaneta;
        private System.Windows.Forms.TabPage tabEditarSatelite;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCuerpoCelesteAEditar;
    }
}