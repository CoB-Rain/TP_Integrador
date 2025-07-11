namespace Ejercicio_4
{
    partial class VistaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaCliente));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSeleccionVaso = new System.Windows.Forms.TabPage();
            this.btnSeleccionarVaso = new System.Windows.Forms.Button();
            this.pboxTipoVaso = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.rbChopp = new System.Windows.Forms.RadioButton();
            this.rbJarra = new System.Windows.Forms.RadioButton();
            this.rbVaso = new System.Windows.Forms.RadioButton();
            this.tabSeleccionCerveza = new System.Windows.Forms.TabPage();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSeleccionarCerveza = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecioCerveza = new System.Windows.Forms.TextBox();
            this.txtCerveza = new System.Windows.Forms.TextBox();
            this.lstBarriles = new System.Windows.Forms.ListBox();
            this.tabSeccionPago = new System.Windows.Forms.TabPage();
            this.txtProductoFinal = new System.Windows.Forms.TextBox();
            this.txtTotalAPagar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabSeleccionVaso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTipoVaso)).BeginInit();
            this.tabSeleccionCerveza.SuspendLayout();
            this.tabSeccionPago.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSeleccionVaso);
            this.tabControl1.Controls.Add(this.tabSeleccionCerveza);
            this.tabControl1.Controls.Add(this.tabSeccionPago);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 397);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabSeleccionVaso
            // 
            this.tabSeleccionVaso.Controls.Add(this.btnSeleccionarVaso);
            this.tabSeleccionVaso.Controls.Add(this.pboxTipoVaso);
            this.tabSeleccionVaso.Controls.Add(this.label1);
            this.tabSeleccionVaso.Controls.Add(this.txtCapacidad);
            this.tabSeleccionVaso.Controls.Add(this.rbChopp);
            this.tabSeleccionVaso.Controls.Add(this.rbJarra);
            this.tabSeleccionVaso.Controls.Add(this.rbVaso);
            this.tabSeleccionVaso.Location = new System.Drawing.Point(4, 33);
            this.tabSeleccionVaso.Name = "tabSeleccionVaso";
            this.tabSeleccionVaso.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeleccionVaso.Size = new System.Drawing.Size(711, 360);
            this.tabSeleccionVaso.TabIndex = 0;
            this.tabSeleccionVaso.Text = "Selección Vaso";
            this.tabSeleccionVaso.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionarVaso
            // 
            this.btnSeleccionarVaso.Location = new System.Drawing.Point(101, 224);
            this.btnSeleccionarVaso.Name = "btnSeleccionarVaso";
            this.btnSeleccionarVaso.Size = new System.Drawing.Size(236, 67);
            this.btnSeleccionarVaso.TabIndex = 6;
            this.btnSeleccionarVaso.Text = "Seleccionar";
            this.btnSeleccionarVaso.UseVisualStyleBackColor = true;
            this.btnSeleccionarVaso.Click += new System.EventHandler(this.btnSeleccionarVaso_Click);
            // 
            // pboxTipoVaso
            // 
            this.pboxTipoVaso.Image = global::Ejercicio_4.Properties.Resources.Chopp;
            this.pboxTipoVaso.Location = new System.Drawing.Point(343, 69);
            this.pboxTipoVaso.Name = "pboxTipoVaso";
            this.pboxTipoVaso.Size = new System.Drawing.Size(259, 222);
            this.pboxTipoVaso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxTipoVaso.TabIndex = 5;
            this.pboxTipoVaso.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Capacidad:";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCapacidad.Location = new System.Drawing.Point(208, 189);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.ReadOnly = true;
            this.txtCapacidad.Size = new System.Drawing.Size(129, 29);
            this.txtCapacidad.TabIndex = 3;
            this.txtCapacidad.Text = "750ml";
            // 
            // rbChopp
            // 
            this.rbChopp.AutoSize = true;
            this.rbChopp.Checked = true;
            this.rbChopp.Location = new System.Drawing.Point(101, 69);
            this.rbChopp.Name = "rbChopp";
            this.rbChopp.Size = new System.Drawing.Size(85, 28);
            this.rbChopp.TabIndex = 0;
            this.rbChopp.TabStop = true;
            this.rbChopp.Text = "Chopp";
            this.rbChopp.UseVisualStyleBackColor = true;
            this.rbChopp.CheckedChanged += new System.EventHandler(this.rbChopp_CheckedChanged);
            // 
            // rbJarra
            // 
            this.rbJarra.AutoSize = true;
            this.rbJarra.Location = new System.Drawing.Point(101, 137);
            this.rbJarra.Name = "rbJarra";
            this.rbJarra.Size = new System.Drawing.Size(69, 28);
            this.rbJarra.TabIndex = 2;
            this.rbJarra.Text = "Jarra";
            this.rbJarra.UseVisualStyleBackColor = true;
            this.rbJarra.CheckedChanged += new System.EventHandler(this.rbJarra_CheckedChanged);
            // 
            // rbVaso
            // 
            this.rbVaso.AutoSize = true;
            this.rbVaso.Location = new System.Drawing.Point(101, 103);
            this.rbVaso.Name = "rbVaso";
            this.rbVaso.Size = new System.Drawing.Size(71, 28);
            this.rbVaso.TabIndex = 1;
            this.rbVaso.Text = "Vaso";
            this.rbVaso.UseVisualStyleBackColor = true;
            this.rbVaso.CheckedChanged += new System.EventHandler(this.rbVaso_CheckedChanged);
            // 
            // tabSeleccionCerveza
            // 
            this.tabSeleccionCerveza.Controls.Add(this.txtNivel);
            this.tabSeleccionCerveza.Controls.Add(this.label4);
            this.tabSeleccionCerveza.Controls.Add(this.btnSeleccionarCerveza);
            this.tabSeleccionCerveza.Controls.Add(this.label3);
            this.tabSeleccionCerveza.Controls.Add(this.label2);
            this.tabSeleccionCerveza.Controls.Add(this.txtPrecioCerveza);
            this.tabSeleccionCerveza.Controls.Add(this.txtCerveza);
            this.tabSeleccionCerveza.Controls.Add(this.lstBarriles);
            this.tabSeleccionCerveza.Location = new System.Drawing.Point(4, 33);
            this.tabSeleccionCerveza.Name = "tabSeleccionCerveza";
            this.tabSeleccionCerveza.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeleccionCerveza.Size = new System.Drawing.Size(711, 360);
            this.tabSeleccionCerveza.TabIndex = 1;
            this.tabSeleccionCerveza.Text = "Selección Cerveza";
            this.tabSeleccionCerveza.UseVisualStyleBackColor = true;
            // 
            // txtNivel
            // 
            this.txtNivel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNivel.Location = new System.Drawing.Point(400, 160);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.ReadOnly = true;
            this.txtNivel.Size = new System.Drawing.Size(187, 29);
            this.txtNivel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nivel:";
            // 
            // btnSeleccionarCerveza
            // 
            this.btnSeleccionarCerveza.Location = new System.Drawing.Point(400, 207);
            this.btnSeleccionarCerveza.Name = "btnSeleccionarCerveza";
            this.btnSeleccionarCerveza.Size = new System.Drawing.Size(187, 61);
            this.btnSeleccionarCerveza.TabIndex = 5;
            this.btnSeleccionarCerveza.Text = "Seleccionar";
            this.btnSeleccionarCerveza.UseVisualStyleBackColor = true;
            this.btnSeleccionarCerveza.Click += new System.EventHandler(this.btnSeleccionarCerveza_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cerveza:";
            // 
            // txtPrecioCerveza
            // 
            this.txtPrecioCerveza.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPrecioCerveza.Location = new System.Drawing.Point(400, 124);
            this.txtPrecioCerveza.Name = "txtPrecioCerveza";
            this.txtPrecioCerveza.ReadOnly = true;
            this.txtPrecioCerveza.Size = new System.Drawing.Size(187, 29);
            this.txtPrecioCerveza.TabIndex = 2;
            this.txtPrecioCerveza.Text = "$ 0.0";
            // 
            // txtCerveza
            // 
            this.txtCerveza.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCerveza.Location = new System.Drawing.Point(400, 89);
            this.txtCerveza.Name = "txtCerveza";
            this.txtCerveza.ReadOnly = true;
            this.txtCerveza.Size = new System.Drawing.Size(187, 29);
            this.txtCerveza.TabIndex = 1;
            // 
            // lstBarriles
            // 
            this.lstBarriles.FormattingEnabled = true;
            this.lstBarriles.ItemHeight = 24;
            this.lstBarriles.Location = new System.Drawing.Point(6, 6);
            this.lstBarriles.Name = "lstBarriles";
            this.lstBarriles.Size = new System.Drawing.Size(280, 340);
            this.lstBarriles.TabIndex = 0;
            this.lstBarriles.SelectedIndexChanged += new System.EventHandler(this.lstBarriles_SelectedIndexChanged);
            this.lstBarriles.DoubleClick += new System.EventHandler(this.lstBarriles_DoubleClick);
            // 
            // tabSeccionPago
            // 
            this.tabSeccionPago.Controls.Add(this.groupBox1);
            this.tabSeccionPago.Location = new System.Drawing.Point(4, 33);
            this.tabSeccionPago.Name = "tabSeccionPago";
            this.tabSeccionPago.Size = new System.Drawing.Size(711, 360);
            this.tabSeccionPago.TabIndex = 2;
            this.tabSeccionPago.Text = "Sección Pago";
            this.tabSeccionPago.UseVisualStyleBackColor = true;
            // 
            // txtProductoFinal
            // 
            this.txtProductoFinal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtProductoFinal.Location = new System.Drawing.Point(6, 37);
            this.txtProductoFinal.Name = "txtProductoFinal";
            this.txtProductoFinal.ReadOnly = true;
            this.txtProductoFinal.Size = new System.Drawing.Size(233, 29);
            this.txtProductoFinal.TabIndex = 0;
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotalAPagar.Location = new System.Drawing.Point(158, 70);
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.ReadOnly = true;
            this.txtTotalAPagar.Size = new System.Drawing.Size(81, 29);
            this.txtTotalAPagar.TabIndex = 2;
            this.txtTotalAPagar.Text = "$ 0.0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnPagar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtProductoFinal);
            this.groupBox1.Controls.Add(this.txtTotalAPagar);
            this.groupBox1.Location = new System.Drawing.Point(26, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 253);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total a pagar:";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(53, 105);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(140, 60);
            this.btnPagar.TabIndex = 4;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(53, 171);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 60);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // VistaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ejercicio_4.Properties.Resources.AfterOffice;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 436);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "VistaCliente";
            this.Text = "VistaCliente";
            this.Load += new System.EventHandler(this.VistaCliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSeleccionVaso.ResumeLayout(false);
            this.tabSeleccionVaso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTipoVaso)).EndInit();
            this.tabSeleccionCerveza.ResumeLayout(false);
            this.tabSeleccionCerveza.PerformLayout();
            this.tabSeccionPago.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSeleccionVaso;
        private System.Windows.Forms.TabPage tabSeleccionCerveza;
        private System.Windows.Forms.TabPage tabSeccionPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.RadioButton rbJarra;
        private System.Windows.Forms.RadioButton rbVaso;
        private System.Windows.Forms.RadioButton rbChopp;
        private System.Windows.Forms.PictureBox pboxTipoVaso;
        private System.Windows.Forms.Button btnSeleccionarVaso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecioCerveza;
        private System.Windows.Forms.TextBox txtCerveza;
        private System.Windows.Forms.ListBox lstBarriles;
        private System.Windows.Forms.Button btnSeleccionarCerveza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.TextBox txtTotalAPagar;
        private System.Windows.Forms.TextBox txtProductoFinal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label5;
    }
}