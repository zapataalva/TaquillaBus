namespace ViajesTerrestres.View
{
    partial class frmRutas
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvListaRutas = new System.Windows.Forms.DataGridView();
            this.Bus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MunicipioIdDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MunicipioIdOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrearRuta = new System.Windows.Forms.Button();
            this.cbxEscalas = new System.Windows.Forms.ComboBox();
            this.btnAgregarEscalas = new System.Windows.Forms.Button();
            this.dgvListaEscalas = new System.Windows.Forms.DataGridView();
            this.EscalaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutaEscalaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParadaEscala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.cbxOrigen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxBuses = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEscalas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(427, 274);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvListaRutas
            // 
            this.dgvListaRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bus,
            this.MunicipioIdDestino,
            this.MunicipioIdOrigen,
            this.Origen,
            this.Destino,
            this.RutaId,
            this.BusId});
            this.dgvListaRutas.Location = new System.Drawing.Point(19, 89);
            this.dgvListaRutas.Name = "dgvListaRutas";
            this.dgvListaRutas.Size = new System.Drawing.Size(343, 149);
            this.dgvListaRutas.TabIndex = 9;
            this.dgvListaRutas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListaRutas_RowHeaderMouseClick);
            // 
            // Bus
            // 
            this.Bus.DataPropertyName = "Placa";
            this.Bus.HeaderText = "Bus";
            this.Bus.Name = "Bus";
            // 
            // MunicipioIdDestino
            // 
            this.MunicipioIdDestino.DataPropertyName = "MunicipioIdDestino";
            this.MunicipioIdDestino.HeaderText = "MunicipioIdDestino";
            this.MunicipioIdDestino.Name = "MunicipioIdDestino";
            this.MunicipioIdDestino.Visible = false;
            // 
            // MunicipioIdOrigen
            // 
            this.MunicipioIdOrigen.DataPropertyName = "MunicipioIdOrigen";
            this.MunicipioIdOrigen.HeaderText = "MunicipioIdOrigen";
            this.MunicipioIdOrigen.Name = "MunicipioIdOrigen";
            this.MunicipioIdOrigen.Visible = false;
            // 
            // Origen
            // 
            this.Origen.DataPropertyName = "MunicipioOrigen";
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            // 
            // Destino
            // 
            this.Destino.DataPropertyName = "MunicipioDestino";
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            // 
            // RutaId
            // 
            this.RutaId.DataPropertyName = "RutaId";
            this.RutaId.HeaderText = "RutaId";
            this.RutaId.Name = "RutaId";
            this.RutaId.Visible = false;
            // 
            // BusId
            // 
            this.BusId.DataPropertyName = "BusId";
            this.BusId.HeaderText = "BusId";
            this.BusId.Name = "BusId";
            this.BusId.Visible = false;
            // 
            // btnCrearRuta
            // 
            this.btnCrearRuta.Location = new System.Drawing.Point(241, 48);
            this.btnCrearRuta.Name = "btnCrearRuta";
            this.btnCrearRuta.Size = new System.Drawing.Size(75, 23);
            this.btnCrearRuta.TabIndex = 8;
            this.btnCrearRuta.Text = "Crear";
            this.btnCrearRuta.UseVisualStyleBackColor = true;
            this.btnCrearRuta.Click += new System.EventHandler(this.btnCrearRuta_Click);
            // 
            // cbxEscalas
            // 
            this.cbxEscalas.FormattingEnabled = true;
            this.cbxEscalas.Location = new System.Drawing.Point(385, 89);
            this.cbxEscalas.Name = "cbxEscalas";
            this.cbxEscalas.Size = new System.Drawing.Size(121, 21);
            this.cbxEscalas.TabIndex = 13;
            // 
            // btnAgregarEscalas
            // 
            this.btnAgregarEscalas.Location = new System.Drawing.Point(513, 89);
            this.btnAgregarEscalas.Name = "btnAgregarEscalas";
            this.btnAgregarEscalas.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEscalas.TabIndex = 14;
            this.btnAgregarEscalas.Text = "Agregar";
            this.btnAgregarEscalas.UseVisualStyleBackColor = true;
            this.btnAgregarEscalas.Click += new System.EventHandler(this.btnAgregarEscalas_Click);
            // 
            // dgvListaEscalas
            // 
            this.dgvListaEscalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEscalas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EscalaId,
            this.RutaEscalaId,
            this.ParadaEscala});
            this.dgvListaEscalas.Location = new System.Drawing.Point(385, 119);
            this.dgvListaEscalas.Name = "dgvListaEscalas";
            this.dgvListaEscalas.Size = new System.Drawing.Size(194, 119);
            this.dgvListaEscalas.TabIndex = 15;
            // 
            // EscalaId
            // 
            this.EscalaId.DataPropertyName = "EscalaId";
            this.EscalaId.HeaderText = "EscalaId";
            this.EscalaId.Name = "EscalaId";
            this.EscalaId.Visible = false;
            this.EscalaId.Width = 150;
            // 
            // RutaEscalaId
            // 
            this.RutaEscalaId.DataPropertyName = "RutaId";
            this.RutaEscalaId.HeaderText = "RutaEscalaID";
            this.RutaEscalaId.Name = "RutaEscalaId";
            this.RutaEscalaId.Visible = false;
            // 
            // ParadaEscala
            // 
            this.ParadaEscala.DataPropertyName = "ParadaEscala";
            this.ParadaEscala.HeaderText = "Escala";
            this.ParadaEscala.Name = "ParadaEscala";
            this.ParadaEscala.Width = 150;
            // 
            // cbxDestino
            // 
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Location = new System.Drawing.Point(241, 12);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(121, 21);
            this.cbxDestino.TabIndex = 19;
            // 
            // cbxOrigen
            // 
            this.cbxOrigen.FormattingEnabled = true;
            this.cbxOrigen.Location = new System.Drawing.Point(53, 12);
            this.cbxOrigen.Name = "cbxOrigen";
            this.cbxOrigen.Size = new System.Drawing.Size(121, 21);
            this.cbxOrigen.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Origen";
            // 
            // cbxBuses
            // 
            this.cbxBuses.FormattingEnabled = true;
            this.cbxBuses.Location = new System.Drawing.Point(53, 48);
            this.cbxBuses.Name = "cbxBuses";
            this.cbxBuses.Size = new System.Drawing.Size(121, 21);
            this.cbxBuses.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Bus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Escalas";
            // 
            // frmRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 324);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxBuses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxDestino);
            this.Controls.Add(this.cbxOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaEscalas);
            this.Controls.Add(this.btnAgregarEscalas);
            this.Controls.Add(this.cbxEscalas);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvListaRutas);
            this.Controls.Add(this.btnCrearRuta);
            this.MaximumSize = new System.Drawing.Size(607, 363);
            this.MinimumSize = new System.Drawing.Size(607, 363);
            this.Name = "frmRutas";
            this.Text = "Rutas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEscalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvListaRutas;
        private System.Windows.Forms.Button btnCrearRuta;
        private System.Windows.Forms.ComboBox cbxEscalas;
        private System.Windows.Forms.Button btnAgregarEscalas;
        private System.Windows.Forms.DataGridView dgvListaEscalas;
        private System.Windows.Forms.ComboBox cbxDestino;
        private System.Windows.Forms.ComboBox cbxOrigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxBuses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bus;
        private System.Windows.Forms.DataGridViewTextBoxColumn MunicipioIdDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn MunicipioIdOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EscalaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutaEscalaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParadaEscala;
    }
}