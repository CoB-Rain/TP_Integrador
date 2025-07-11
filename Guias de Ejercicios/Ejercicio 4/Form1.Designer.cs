namespace Ejercicio_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.afterOfficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barrilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1489, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vistaClienteToolStripMenuItem,
            this.administracionToolStripMenuItem1});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // vistaClienteToolStripMenuItem
            // 
            this.vistaClienteToolStripMenuItem.Name = "vistaClienteToolStripMenuItem";
            this.vistaClienteToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.vistaClienteToolStripMenuItem.Text = "Vista Cliente";
            this.vistaClienteToolStripMenuItem.Click += new System.EventHandler(this.vistaClienteToolStripMenuItem_Click);
            // 
            // administracionToolStripMenuItem1
            // 
            this.administracionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afterOfficeToolStripMenuItem,
            this.barrilesToolStripMenuItem});
            this.administracionToolStripMenuItem1.Name = "administracionToolStripMenuItem1";
            this.administracionToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.administracionToolStripMenuItem1.Text = "Administracion";
            // 
            // afterOfficeToolStripMenuItem
            // 
            this.afterOfficeToolStripMenuItem.Name = "afterOfficeToolStripMenuItem";
            this.afterOfficeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.afterOfficeToolStripMenuItem.Text = "AfterOffice";
            this.afterOfficeToolStripMenuItem.Click += new System.EventHandler(this.afterOfficeToolStripMenuItem_Click);
            // 
            // barrilesToolStripMenuItem
            // 
            this.barrilesToolStripMenuItem.Name = "barrilesToolStripMenuItem";
            this.barrilesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.barrilesToolStripMenuItem.Text = "Barriles";
            this.barrilesToolStripMenuItem.Click += new System.EventHandler(this.barrilesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 955);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AfterOffice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vistaClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem afterOfficeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barrilesToolStripMenuItem;
    }
}

