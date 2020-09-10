namespace ViajesTerrestres.View
{
    partial class frmReportePasajero
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
            this.btnBuscarReporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombrePasajero = new System.Windows.Forms.TextBox();
            this.dgvListaReporte = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MunicipioOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MunicipioDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MunicipioIdOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MunicipioIdDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasajeroId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarReporte
            // 
            this.btnBuscarReporte.Location = new System.Drawing.Point(395, 49);
            this.btnBuscarReporte.Name = "btnBuscarReporte";
            this.btnBuscarReporte.Size = new System.Drawing.Size(112, 23);
            this.btnBuscarReporte.TabIndex = 0;
            this.btnBuscarReporte.Text = "Generar Historial";
            this.btnBuscarReporte.UseVisualStyleBackColor = true;
            this.btnBuscarReporte.Click += new System.EventHandler(this.btnBuscarReporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtNombrePasajero
            // 
            this.txtNombrePasajero.Location = new System.Drawing.Point(156, 51);
            this.txtNombrePasajero.Name = "txtNombrePasajero";
            this.txtNombrePasajero.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePasajero.TabIndex = 2;
            // 
            // dgvListaReporte
            // 
            this.dgvListaReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.MunicipioOrigen,
            this.MunicipioDestino,
            this.Placa,
            this.MunicipioIdOrigen,
            this.MunicipioIdDestino,
            this.PasajeroId,
            this.BusId,
            this.RutaId});
            this.dgvListaReporte.Location = new System.Drawing.Point(62, 108);
            this.dgvListaReporte.Name = "dgvListaReporte";
            this.dgvListaReporte.Size = new System.Drawing.Size(445, 150);
            this.dgvListaReporte.TabIndex = 3;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(452, 289);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombrePasajero";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // MunicipioOrigen
            // 
            this.MunicipioOrigen.DataPropertyName = "MunicipioOrigen";
            this.MunicipioOrigen.HeaderText = "Origen";
            this.MunicipioOrigen.Name = "MunicipioOrigen";
            // 
            // MunicipioDestino
            // 
            this.MunicipioDestino.DataPropertyName = "MunicipioDestino";
            this.MunicipioDestino.HeaderText = "Destino";
            this.MunicipioDestino.Name = "MunicipioDestino";
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "Placa";
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            // 
            // MunicipioIdOrigen
            // 
            this.MunicipioIdOrigen.DataPropertyName = "MunicipioIdOrigen";
            this.MunicipioIdOrigen.HeaderText = "OrigenId";
            this.MunicipioIdOrigen.Name = "MunicipioIdOrigen";
            this.MunicipioIdOrigen.Visible = false;
            // 
            // MunicipioIdDestino
            // 
            this.MunicipioIdDestino.DataPropertyName = "MunicipioIdDestino";
            this.MunicipioIdDestino.HeaderText = "DestinoId";
            this.MunicipioIdDestino.Name = "MunicipioIdDestino";
            this.MunicipioIdDestino.Visible = false;
            // 
            // PasajeroId
            // 
            this.PasajeroId.DataPropertyName = "PasajeroId";
            this.PasajeroId.HeaderText = "PasajeroId";
            this.PasajeroId.Name = "PasajeroId";
            this.PasajeroId.Visible = false;
            // 
            // BusId
            // 
            this.BusId.DataPropertyName = "BusId";
            this.BusId.HeaderText = "BusId";
            this.BusId.Name = "BusId";
            this.BusId.Visible = false;
            // 
            // RutaId
            // 
            this.RutaId.DataPropertyName = "RutaId";
            this.RutaId.HeaderText = "RutaId";
            this.RutaId.Name = "RutaId";
            this.RutaId.Visible = false;
            // 
            // frmReportePasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 324);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvListaReporte);
            this.Controls.Add(this.txtNombrePasajero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarReporte);
            this.MaximumSize = new System.Drawing.Size(607, 363);
            this.MinimumSize = new System.Drawing.Size(607, 363);
            this.Name = "frmReportePasajero";
            this.Text = "Historial Viaje";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombrePasajero;
        private System.Windows.Forms.DataGridView dgvListaReporte;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn MunicipioOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MunicipioDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MunicipioIdOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MunicipioIdDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasajeroId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutaId;
    }
}