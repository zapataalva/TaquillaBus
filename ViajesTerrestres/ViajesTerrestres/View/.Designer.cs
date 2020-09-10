namespace ViajesTerrestres
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnMenuBus = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuConductores = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuMunicipios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuRutas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxOrigen = new System.Windows.Forms.ComboBox();
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvBusesRutas = new System.Windows.Forms.DataGridView();
            this.BusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MunicipioIdOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MunicipioIdDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MunicipioOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MunicipioDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGenerarTicket = new System.Windows.Forms.Button();
            this.chkTapaBocas = new System.Windows.Forms.CheckBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.txtOrigenId = new System.Windows.Forms.TextBox();
            this.txtDestinoId = new System.Windows.Forms.TextBox();
            this.txtRutaId = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusesRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuBus,
            this.btnMenuConductores,
            this.btnMenuMunicipios,
            this.btnMenuRutas,
            this.btnMenuReporte});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(572, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnMenuBus
            // 
            this.btnMenuBus.Name = "btnMenuBus";
            this.btnMenuBus.Size = new System.Drawing.Size(49, 20);
            this.btnMenuBus.Text = "Buses";
            this.btnMenuBus.Click += new System.EventHandler(this.btnMenuBus_Click);
            // 
            // btnMenuConductores
            // 
            this.btnMenuConductores.Name = "btnMenuConductores";
            this.btnMenuConductores.Size = new System.Drawing.Size(87, 20);
            this.btnMenuConductores.Text = "Conductores";
            this.btnMenuConductores.Click += new System.EventHandler(this.btnMenuConductores_Click);
            // 
            // btnMenuMunicipios
            // 
            this.btnMenuMunicipios.Name = "btnMenuMunicipios";
            this.btnMenuMunicipios.Size = new System.Drawing.Size(78, 20);
            this.btnMenuMunicipios.Text = "Municipios";
            this.btnMenuMunicipios.Click += new System.EventHandler(this.btnMenuMunicipios_Click);
            // 
            // btnMenuRutas
            // 
            this.btnMenuRutas.Name = "btnMenuRutas";
            this.btnMenuRutas.Size = new System.Drawing.Size(48, 20);
            this.btnMenuRutas.Text = "Rutas";
            this.btnMenuRutas.Click += new System.EventHandler(this.btnMenuRutas_Click);
            // 
            // btnMenuReporte
            // 
            this.btnMenuReporte.Name = "btnMenuReporte";
            this.btnMenuReporte.Size = new System.Drawing.Size(96, 20);
            this.btnMenuReporte.Text = "Historial Viajes";
            this.btnMenuReporte.Click += new System.EventHandler(this.btnMenuReporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destino";
            // 
            // cbxOrigen
            // 
            this.cbxOrigen.FormattingEnabled = true;
            this.cbxOrigen.Location = new System.Drawing.Point(88, 48);
            this.cbxOrigen.Name = "cbxOrigen";
            this.cbxOrigen.Size = new System.Drawing.Size(121, 21);
            this.cbxOrigen.TabIndex = 4;
            // 
            // cbxDestino
            // 
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Location = new System.Drawing.Point(293, 48);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(121, 21);
            this.cbxDestino.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(458, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvBusesRutas
            // 
            this.dgvBusesRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusesRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BusId,
            this.MunicipioIdOrigen,
            this.MunicipioIdDestino,
            this.Placa,
            this.RutaId,
            this.MunicipioOrigen,
            this.MunicipioDestino});
            this.dgvBusesRutas.Location = new System.Drawing.Point(47, 85);
            this.dgvBusesRutas.Name = "dgvBusesRutas";
            this.dgvBusesRutas.Size = new System.Drawing.Size(489, 105);
            this.dgvBusesRutas.TabIndex = 7;
            this.dgvBusesRutas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBusesRutas_RowHeaderMouseClick);
            // 
            // BusId
            // 
            this.BusId.DataPropertyName = "BusId";
            this.BusId.HeaderText = "Bus";
            this.BusId.Name = "BusId";
            this.BusId.Visible = false;
            // 
            // MunicipioIdOrigen
            // 
            this.MunicipioIdOrigen.DataPropertyName = "MunicipioIdOrigen";
            this.MunicipioIdOrigen.HeaderText = "MunicipioIdOrigen";
            this.MunicipioIdOrigen.Name = "MunicipioIdOrigen";
            this.MunicipioIdOrigen.Visible = false;
            // 
            // MunicipioIdDestino
            // 
            this.MunicipioIdDestino.DataPropertyName = "MunicipioIdDestino";
            this.MunicipioIdDestino.HeaderText = "MunicipioIdDestino";
            this.MunicipioIdDestino.Name = "MunicipioIdDestino";
            this.MunicipioIdDestino.Visible = false;
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "Placa";
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.Width = 130;
            // 
            // RutaId
            // 
            this.RutaId.DataPropertyName = "RutaId";
            this.RutaId.HeaderText = "RutaId";
            this.RutaId.Name = "RutaId";
            this.RutaId.Visible = false;
            // 
            // MunicipioOrigen
            // 
            this.MunicipioOrigen.DataPropertyName = "MunicipioOrigen";
            this.MunicipioOrigen.HeaderText = "Origen";
            this.MunicipioOrigen.Name = "MunicipioOrigen";
            this.MunicipioOrigen.Width = 160;
            // 
            // MunicipioDestino
            // 
            this.MunicipioDestino.DataPropertyName = "MunicipioDestino";
            this.MunicipioDestino.HeaderText = "Destino";
            this.MunicipioDestino.Name = "MunicipioDestino";
            this.MunicipioDestino.Width = 160;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "¿Usa tapa bocas?";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 318);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // btnGenerarTicket
            // 
            this.btnGenerarTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarTicket.Location = new System.Drawing.Point(226, 367);
            this.btnGenerarTicket.Name = "btnGenerarTicket";
            this.btnGenerarTicket.Size = new System.Drawing.Size(134, 33);
            this.btnGenerarTicket.TabIndex = 13;
            this.btnGenerarTicket.Text = "Generar Ticket";
            this.btnGenerarTicket.UseVisualStyleBackColor = true;
            this.btnGenerarTicket.Click += new System.EventHandler(this.btnGenerarTicket_Click);
            // 
            // chkTapaBocas
            // 
            this.chkTapaBocas.AutoSize = true;
            this.chkTapaBocas.Location = new System.Drawing.Point(301, 333);
            this.chkTapaBocas.Name = "chkTapaBocas";
            this.chkTapaBocas.Size = new System.Drawing.Size(15, 14);
            this.chkTapaBocas.TabIndex = 14;
            this.chkTapaBocas.UseVisualStyleBackColor = true;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(50, 206);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(53, 20);
            this.lblRuta.TabIndex = 15;
            this.lblRuta.Text = "Ruta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pasajero:";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Enabled = false;
            this.txtOrigen.Location = new System.Drawing.Point(272, 239);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(100, 20);
            this.txtOrigen.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Origen";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Enabled = false;
            this.txtPlaca.Location = new System.Drawing.Point(91, 239);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Placa";
            // 
            // txtDestino
            // 
            this.txtDestino.Enabled = false;
            this.txtDestino.Location = new System.Drawing.Point(443, 239);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(100, 20);
            this.txtDestino.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Destino";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(54, 413);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(50, 13);
            this.lblMensaje.TabIndex = 25;
            this.lblMensaje.Text = "Mensaje:";
            // 
            // txtOrigenId
            // 
            this.txtOrigenId.Location = new System.Drawing.Point(431, 321);
            this.txtOrigenId.Name = "txtOrigenId";
            this.txtOrigenId.Size = new System.Drawing.Size(10, 20);
            this.txtOrigenId.TabIndex = 26;
            this.txtOrigenId.Visible = false;
            // 
            // txtDestinoId
            // 
            this.txtDestinoId.Location = new System.Drawing.Point(431, 348);
            this.txtDestinoId.Name = "txtDestinoId";
            this.txtDestinoId.Size = new System.Drawing.Size(10, 20);
            this.txtDestinoId.TabIndex = 27;
            this.txtDestinoId.Visible = false;
            // 
            // txtRutaId
            // 
            this.txtRutaId.Location = new System.Drawing.Point(431, 375);
            this.txtRutaId.Name = "txtRutaId";
            this.txtRutaId.Size = new System.Drawing.Size(10, 20);
            this.txtRutaId.TabIndex = 28;
            this.txtRutaId.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 438);
            this.Controls.Add(this.txtRutaId);
            this.Controls.Add(this.txtDestinoId);
            this.Controls.Add(this.txtOrigenId);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.chkTapaBocas);
            this.Controls.Add(this.btnGenerarTicket);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBusesRutas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbxDestino);
            this.Controls.Add(this.cbxOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusesRutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMenuBus;
        private System.Windows.Forms.ToolStripMenuItem btnMenuConductores;
        private System.Windows.Forms.ToolStripMenuItem btnMenuMunicipios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxOrigen;
        private System.Windows.Forms.ComboBox cbxDestino;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvBusesRutas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGenerarTicket;
        private System.Windows.Forms.CheckBox chkTapaBocas;
        private System.Windows.Forms.ToolStripMenuItem btnMenuRutas;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MunicipioIdOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MunicipioIdDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MunicipioOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MunicipioDestino;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem btnMenuReporte;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox txtOrigenId;
        private System.Windows.Forms.TextBox txtDestinoId;
        private System.Windows.Forms.TextBox txtRutaId;
    }
}

