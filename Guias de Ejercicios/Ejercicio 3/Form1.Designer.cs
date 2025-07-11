namespace Ejercicio_3
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
            this.tbcCafeteria = new System.Windows.Forms.TabControl();
            this.tabVistaCliente = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lstVasosServidos = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRealizarPedido = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstVasosPendientes = new System.Windows.Forms.ListBox();
            this.btnServir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoCafeCliente = new System.Windows.Forms.TextBox();
            this.txtPrecioCliente = new System.Windows.Forms.TextBox();
            this.lstMaquinasCafe = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numCantidadVasos = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbVasos = new System.Windows.Forms.ComboBox();
            this.btnAgregarALista = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.tabGestionMaquinas = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRecargarMaquina = new System.Windows.Forms.Button();
            this.btnAgregarMaquina = new System.Windows.Forms.Button();
            this.cmbTipoCafe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.dgvMaquinasCafe = new System.Windows.Forms.DataGridView();
            this.tabAdministracion = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvInformacionMaquinas = new System.Windows.Forms.DataGridView();
            this.btnEstadisticasMaquinas = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnEstadisticasCafé = new System.Windows.Forms.Button();
            this.txtInformacionCafe = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnEstadisticasCafeteria = new System.Windows.Forms.Button();
            this.txtInformacionCafeteria = new System.Windows.Forms.TextBox();
            this.tbcCafeteria.SuspendLayout();
            this.tabVistaCliente.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadVasos)).BeginInit();
            this.tabGestionMaquinas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinasCafe)).BeginInit();
            this.tabAdministracion.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacionMaquinas)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcCafeteria
            // 
            this.tbcCafeteria.Controls.Add(this.tabVistaCliente);
            this.tbcCafeteria.Controls.Add(this.tabGestionMaquinas);
            this.tbcCafeteria.Controls.Add(this.tabAdministracion);
            this.tbcCafeteria.Location = new System.Drawing.Point(15, 15);
            this.tbcCafeteria.Margin = new System.Windows.Forms.Padding(6);
            this.tbcCafeteria.Name = "tbcCafeteria";
            this.tbcCafeteria.SelectedIndex = 0;
            this.tbcCafeteria.Size = new System.Drawing.Size(1424, 788);
            this.tbcCafeteria.TabIndex = 0;
            // 
            // tabVistaCliente
            // 
            this.tabVistaCliente.Controls.Add(this.groupBox4);
            this.tabVistaCliente.Controls.Add(this.groupBox3);
            this.tabVistaCliente.Controls.Add(this.lstMaquinasCafe);
            this.tabVistaCliente.Controls.Add(this.groupBox2);
            this.tabVistaCliente.Location = new System.Drawing.Point(4, 33);
            this.tabVistaCliente.Margin = new System.Windows.Forms.Padding(6);
            this.tabVistaCliente.Name = "tabVistaCliente";
            this.tabVistaCliente.Padding = new System.Windows.Forms.Padding(6);
            this.tabVistaCliente.Size = new System.Drawing.Size(1416, 751);
            this.tabVistaCliente.TabIndex = 1;
            this.tabVistaCliente.Text = "VistaCliente";
            this.tabVistaCliente.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTotal);
            this.groupBox4.Controls.Add(this.lstVasosServidos);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.btnRealizarPedido);
            this.groupBox4.Location = new System.Drawing.Point(389, 491);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(516, 243);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pedido";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotal.Location = new System.Drawing.Point(353, 65);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(157, 29);
            this.txtTotal.TabIndex = 21;
            this.txtTotal.Text = "$ 0.00";
            // 
            // lstVasosServidos
            // 
            this.lstVasosServidos.FormattingEnabled = true;
            this.lstVasosServidos.Location = new System.Drawing.Point(6, 65);
            this.lstVasosServidos.Name = "lstVasosServidos";
            this.lstVasosServidos.Size = new System.Drawing.Size(321, 172);
            this.lstVasosServidos.TabIndex = 22;
            this.lstVasosServidos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstVasosServidos_ItemCheck);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(86, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Vasos Servidos";
            // 
            // btnRealizarPedido
            // 
            this.btnRealizarPedido.Enabled = false;
            this.btnRealizarPedido.Location = new System.Drawing.Point(353, 177);
            this.btnRealizarPedido.Name = "btnRealizarPedido";
            this.btnRealizarPedido.Size = new System.Drawing.Size(157, 60);
            this.btnRealizarPedido.TabIndex = 15;
            this.btnRealizarPedido.Text = "Realizar pedido";
            this.btnRealizarPedido.UseVisualStyleBackColor = true;
            this.btnRealizarPedido.Click += new System.EventHandler(this.btnRealizarPedido_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lstVasosPendientes);
            this.groupBox3.Controls.Add(this.btnServir);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtTipoCafeCliente);
            this.groupBox3.Controls.Add(this.txtPrecioCliente);
            this.groupBox3.Location = new System.Drawing.Point(389, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(516, 242);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preparación";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Vasos Pendientes";
            // 
            // lstVasosPendientes
            // 
            this.lstVasosPendientes.FormattingEnabled = true;
            this.lstVasosPendientes.ItemHeight = 24;
            this.lstVasosPendientes.Location = new System.Drawing.Point(284, 63);
            this.lstVasosPendientes.Name = "lstVasosPendientes";
            this.lstVasosPendientes.Size = new System.Drawing.Size(214, 172);
            this.lstVasosPendientes.TabIndex = 12;
            this.lstVasosPendientes.SelectedIndexChanged += new System.EventHandler(this.lstVasosPendientes_SelectedIndexChanged);
            // 
            // btnServir
            // 
            this.btnServir.Enabled = false;
            this.btnServir.Location = new System.Drawing.Point(121, 175);
            this.btnServir.Name = "btnServir";
            this.btnServir.Size = new System.Drawing.Size(157, 60);
            this.btnServir.TabIndex = 19;
            this.btnServir.Text = "Servir";
            this.btnServir.UseVisualStyleBackColor = true;
            this.btnServir.Click += new System.EventHandler(this.btnServir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Café:";
            // 
            // txtTipoCafeCliente
            // 
            this.txtTipoCafeCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTipoCafeCliente.Location = new System.Drawing.Point(121, 63);
            this.txtTipoCafeCliente.Name = "txtTipoCafeCliente";
            this.txtTipoCafeCliente.ReadOnly = true;
            this.txtTipoCafeCliente.Size = new System.Drawing.Size(157, 29);
            this.txtTipoCafeCliente.TabIndex = 15;
            // 
            // txtPrecioCliente
            // 
            this.txtPrecioCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPrecioCliente.Location = new System.Drawing.Point(121, 98);
            this.txtPrecioCliente.Name = "txtPrecioCliente";
            this.txtPrecioCliente.ReadOnly = true;
            this.txtPrecioCliente.Size = new System.Drawing.Size(157, 29);
            this.txtPrecioCliente.TabIndex = 17;
            this.txtPrecioCliente.Text = "$";
            // 
            // lstMaquinasCafe
            // 
            this.lstMaquinasCafe.FormattingEnabled = true;
            this.lstMaquinasCafe.ItemHeight = 24;
            this.lstMaquinasCafe.Location = new System.Drawing.Point(10, 10);
            this.lstMaquinasCafe.Name = "lstMaquinasCafe";
            this.lstMaquinasCafe.Size = new System.Drawing.Size(373, 724);
            this.lstMaquinasCafe.TabIndex = 16;
            this.lstMaquinasCafe.SelectedIndexChanged += new System.EventHandler(this.lstMaquinasCafe_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numCantidadVasos);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbVasos);
            this.groupBox2.Controls.Add(this.btnAgregarALista);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCapacidad);
            this.groupBox2.Location = new System.Drawing.Point(389, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 226);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selección Vaso(s)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cantidad:";
            // 
            // numCantidadVasos
            // 
            this.numCantidadVasos.Location = new System.Drawing.Point(120, 116);
            this.numCantidadVasos.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCantidadVasos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidadVasos.Name = "numCantidadVasos";
            this.numCantidadVasos.Size = new System.Drawing.Size(291, 29);
            this.numCantidadVasos.TabIndex = 18;
            this.numCantidadVasos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tamaño:";
            // 
            // cmbVasos
            // 
            this.cmbVasos.FormattingEnabled = true;
            this.cmbVasos.Location = new System.Drawing.Point(119, 43);
            this.cmbVasos.Name = "cmbVasos";
            this.cmbVasos.Size = new System.Drawing.Size(292, 32);
            this.cmbVasos.TabIndex = 15;
            this.cmbVasos.SelectedIndexChanged += new System.EventHandler(this.cmbTiposVasos_SelectedIndexChanged);
            // 
            // btnAgregarALista
            // 
            this.btnAgregarALista.Location = new System.Drawing.Point(181, 151);
            this.btnAgregarALista.Name = "btnAgregarALista";
            this.btnAgregarALista.Size = new System.Drawing.Size(167, 60);
            this.btnAgregarALista.TabIndex = 14;
            this.btnAgregarALista.Text = "Agregar a lista";
            this.btnAgregarALista.UseVisualStyleBackColor = true;
            this.btnAgregarALista.Click += new System.EventHandler(this.btnAgregarALista_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Capacidad:";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCapacidad.Location = new System.Drawing.Point(119, 81);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.ReadOnly = true;
            this.txtCapacidad.Size = new System.Drawing.Size(292, 29);
            this.txtCapacidad.TabIndex = 13;
            this.txtCapacidad.Text = "0ml";
            // 
            // tabGestionMaquinas
            // 
            this.tabGestionMaquinas.Controls.Add(this.label5);
            this.tabGestionMaquinas.Controls.Add(this.groupBox1);
            this.tabGestionMaquinas.Controls.Add(this.dgvMaquinasCafe);
            this.tabGestionMaquinas.Location = new System.Drawing.Point(4, 33);
            this.tabGestionMaquinas.Margin = new System.Windows.Forms.Padding(6);
            this.tabGestionMaquinas.Name = "tabGestionMaquinas";
            this.tabGestionMaquinas.Padding = new System.Windows.Forms.Padding(6);
            this.tabGestionMaquinas.Size = new System.Drawing.Size(1416, 751);
            this.tabGestionMaquinas.TabIndex = 0;
            this.tabGestionMaquinas.Text = "Gestión Máquinas";
            this.tabGestionMaquinas.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(355, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "Máquinas de café creadas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRecargarMaquina);
            this.groupBox1.Controls.Add(this.btnAgregarMaquina);
            this.groupBox1.Controls.Add(this.cmbTipoCafe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Location = new System.Drawing.Point(889, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 200);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva máquina de café";
            // 
            // btnRecargarMaquina
            // 
            this.btnRecargarMaquina.Location = new System.Drawing.Point(23, 111);
            this.btnRecargarMaquina.Name = "btnRecargarMaquina";
            this.btnRecargarMaquina.Size = new System.Drawing.Size(182, 73);
            this.btnRecargarMaquina.TabIndex = 10;
            this.btnRecargarMaquina.Text = "Recargar Máquina";
            this.btnRecargarMaquina.UseVisualStyleBackColor = true;
            this.btnRecargarMaquina.Click += new System.EventHandler(this.btnRecargarMaquina_Click);
            // 
            // btnAgregarMaquina
            // 
            this.btnAgregarMaquina.Location = new System.Drawing.Point(223, 111);
            this.btnAgregarMaquina.Name = "btnAgregarMaquina";
            this.btnAgregarMaquina.Size = new System.Drawing.Size(172, 73);
            this.btnAgregarMaquina.TabIndex = 1;
            this.btnAgregarMaquina.Text = " Agregar Máquina";
            this.btnAgregarMaquina.UseVisualStyleBackColor = true;
            this.btnAgregarMaquina.Click += new System.EventHandler(this.btnAgregarMaquina_Click);
            // 
            // cmbTipoCafe
            // 
            this.cmbTipoCafe.FormattingEnabled = true;
            this.cmbTipoCafe.Location = new System.Drawing.Point(128, 38);
            this.cmbTipoCafe.Name = "cmbTipoCafe";
            this.cmbTipoCafe.Size = new System.Drawing.Size(267, 32);
            this.cmbTipoCafe.TabIndex = 2;
            this.cmbTipoCafe.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCafe_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo cafe:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPrecio.Location = new System.Drawing.Point(128, 76);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(267, 29);
            this.txtPrecio.TabIndex = 8;
            this.txtPrecio.Text = "$";
            // 
            // dgvMaquinasCafe
            // 
            this.dgvMaquinasCafe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaquinasCafe.Location = new System.Drawing.Point(9, 89);
            this.dgvMaquinasCafe.Name = "dgvMaquinasCafe";
            this.dgvMaquinasCafe.Size = new System.Drawing.Size(874, 586);
            this.dgvMaquinasCafe.TabIndex = 0;
            // 
            // tabAdministracion
            // 
            this.tabAdministracion.Controls.Add(this.groupBox7);
            this.tabAdministracion.Controls.Add(this.groupBox6);
            this.tabAdministracion.Controls.Add(this.groupBox5);
            this.tabAdministracion.Location = new System.Drawing.Point(4, 33);
            this.tabAdministracion.Margin = new System.Windows.Forms.Padding(6);
            this.tabAdministracion.Name = "tabAdministracion";
            this.tabAdministracion.Size = new System.Drawing.Size(1416, 751);
            this.tabAdministracion.TabIndex = 2;
            this.tabAdministracion.Text = "Administración";
            this.tabAdministracion.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvInformacionMaquinas);
            this.groupBox7.Controls.Add(this.btnEstadisticasMaquinas);
            this.groupBox7.Location = new System.Drawing.Point(9, 246);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1395, 314);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Máquinas de Café";
            // 
            // dgvInformacionMaquinas
            // 
            this.dgvInformacionMaquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformacionMaquinas.Location = new System.Drawing.Point(144, 36);
            this.dgvInformacionMaquinas.Name = "dgvInformacionMaquinas";
            this.dgvInformacionMaquinas.Size = new System.Drawing.Size(1245, 269);
            this.dgvInformacionMaquinas.TabIndex = 2;
            // 
            // btnEstadisticasMaquinas
            // 
            this.btnEstadisticasMaquinas.Location = new System.Drawing.Point(6, 239);
            this.btnEstadisticasMaquinas.Name = "btnEstadisticasMaquinas";
            this.btnEstadisticasMaquinas.Size = new System.Drawing.Size(132, 66);
            this.btnEstadisticasMaquinas.TabIndex = 1;
            this.btnEstadisticasMaquinas.Text = "Estadisticas Máquinas";
            this.btnEstadisticasMaquinas.UseVisualStyleBackColor = true;
            this.btnEstadisticasMaquinas.Click += new System.EventHandler(this.btnEstadisticasMaquinas_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnEstadisticasCafé);
            this.groupBox6.Controls.Add(this.txtInformacionCafe);
            this.groupBox6.Location = new System.Drawing.Point(9, 566);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(798, 182);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Café";
            // 
            // btnEstadisticasCafé
            // 
            this.btnEstadisticasCafé.Location = new System.Drawing.Point(12, 110);
            this.btnEstadisticasCafé.Name = "btnEstadisticasCafé";
            this.btnEstadisticasCafé.Size = new System.Drawing.Size(132, 66);
            this.btnEstadisticasCafé.TabIndex = 2;
            this.btnEstadisticasCafé.Text = "Estadisticas Café";
            this.btnEstadisticasCafé.UseVisualStyleBackColor = true;
            this.btnEstadisticasCafé.Click += new System.EventHandler(this.btnEstadisticasCafé_Click);
            // 
            // txtInformacionCafe
            // 
            this.txtInformacionCafe.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtInformacionCafe.Location = new System.Drawing.Point(150, 25);
            this.txtInformacionCafe.Multiline = true;
            this.txtInformacionCafe.Name = "txtInformacionCafe";
            this.txtInformacionCafe.ReadOnly = true;
            this.txtInformacionCafe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInformacionCafe.Size = new System.Drawing.Size(642, 151);
            this.txtInformacionCafe.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnEstadisticasCafeteria);
            this.groupBox5.Controls.Add(this.txtInformacionCafeteria);
            this.groupBox5.Location = new System.Drawing.Point(9, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1395, 237);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cafetería";
            // 
            // btnEstadisticasCafeteria
            // 
            this.btnEstadisticasCafeteria.Location = new System.Drawing.Point(6, 157);
            this.btnEstadisticasCafeteria.Name = "btnEstadisticasCafeteria";
            this.btnEstadisticasCafeteria.Size = new System.Drawing.Size(132, 66);
            this.btnEstadisticasCafeteria.TabIndex = 3;
            this.btnEstadisticasCafeteria.Text = "Estadisticas Cafetería";
            this.btnEstadisticasCafeteria.UseVisualStyleBackColor = true;
            this.btnEstadisticasCafeteria.Click += new System.EventHandler(this.btnEstadisticasCafeteria_Click);
            // 
            // txtInformacionCafeteria
            // 
            this.txtInformacionCafeteria.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtInformacionCafeteria.Location = new System.Drawing.Point(144, 25);
            this.txtInformacionCafeteria.Multiline = true;
            this.txtInformacionCafeteria.Name = "txtInformacionCafeteria";
            this.txtInformacionCafeteria.ReadOnly = true;
            this.txtInformacionCafeteria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInformacionCafeteria.Size = new System.Drawing.Size(1245, 198);
            this.txtInformacionCafeteria.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 818);
            this.Controls.Add(this.tbcCafeteria);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcCafeteria.ResumeLayout(false);
            this.tabVistaCliente.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadVasos)).EndInit();
            this.tabGestionMaquinas.ResumeLayout(false);
            this.tabGestionMaquinas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinasCafe)).EndInit();
            this.tabAdministracion.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacionMaquinas)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCafeteria;
        private System.Windows.Forms.TabPage tabGestionMaquinas;
        private System.Windows.Forms.TabPage tabVistaCliente;
        private System.Windows.Forms.TabPage tabAdministracion;
        private System.Windows.Forms.DataGridView dgvMaquinasCafe;
        private System.Windows.Forms.Button btnAgregarMaquina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoCafe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstVasosPendientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Button btnAgregarALista;
        private System.Windows.Forms.ListBox lstMaquinasCafe;
        private System.Windows.Forms.TextBox txtTipoCafeCliente;
        private System.Windows.Forms.TextBox txtPrecioCliente;
        private System.Windows.Forms.Button btnRealizarPedido;
        private System.Windows.Forms.NumericUpDown numCantidadVasos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbVasos;
        private System.Windows.Forms.Button btnServir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRecargarMaquina;
        private System.Windows.Forms.CheckedListBox lstVasosServidos;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtInformacionCafe;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtInformacionCafeteria;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnEstadisticasMaquinas;
        private System.Windows.Forms.Button btnEstadisticasCafé;
        private System.Windows.Forms.Button btnEstadisticasCafeteria;
        private System.Windows.Forms.DataGridView dgvInformacionMaquinas;
    }
}

