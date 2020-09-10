namespace ViajesTerrestres.View
{
    partial class frmMaestroConductor
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
            this.dgvListaConductores = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearConductor = new System.Windows.Forms.Button();
            this.txtNombreConductor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxBuses = new System.Windows.Forms.ComboBox();
            this.ConductorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaConductores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaConductores
            // 
            this.dgvListaConductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaConductores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConductorId,
            this.Nombre,
            this.BusId,
            this.Placa});
            this.dgvListaConductores.Location = new System.Drawing.Point(48, 102);
            this.dgvListaConductores.Name = "dgvListaConductores";
            this.dgvListaConductores.Size = new System.Drawing.Size(346, 150);
            this.dgvListaConductores.TabIndex = 15;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(452, 280);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bus";
            // 
            // btnCrearConductor
            // 
            this.btnCrearConductor.Location = new System.Drawing.Point(452, 34);
            this.btnCrearConductor.Name = "btnCrearConductor";
            this.btnCrearConductor.Size = new System.Drawing.Size(75, 23);
            this.btnCrearConductor.TabIndex = 10;
            this.btnCrearConductor.Text = "Crear";
            this.btnCrearConductor.UseVisualStyleBackColor = true;
            this.btnCrearConductor.Click += new System.EventHandler(this.btnCrearConductor_Click);
            // 
            // txtNombreConductor
            // 
            this.txtNombreConductor.Location = new System.Drawing.Point(95, 33);
            this.txtNombreConductor.Name = "txtNombreConductor";
            this.txtNombreConductor.Size = new System.Drawing.Size(100, 20);
            this.txtNombreConductor.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // cbxBuses
            // 
            this.cbxBuses.FormattingEnabled = true;
            this.cbxBuses.Location = new System.Drawing.Point(273, 34);
            this.cbxBuses.Name = "cbxBuses";
            this.cbxBuses.Size = new System.Drawing.Size(121, 21);
            this.cbxBuses.TabIndex = 16;
            // 
            // ConductorId
            // 
            this.ConductorId.DataPropertyName = "ConductorId";
            this.ConductorId.HeaderText = "ConductorId";
            this.ConductorId.Name = "ConductorId";
            this.ConductorId.Visible = false;
            this.ConductorId.Width = 104;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreConductor";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 170;
            // 
            // BusId
            // 
            this.BusId.DataPropertyName = "BusId";
            this.BusId.HeaderText = "BusId";
            this.BusId.Name = "BusId";
            this.BusId.Visible = false;
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "Placa";
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.Width = 134;
            // 
            // frmMaestroConductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 324);
            this.Controls.Add(this.cbxBuses);
            this.Controls.Add(this.dgvListaConductores);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCrearConductor);
            this.Controls.Add(this.txtNombreConductor);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(607, 363);
            this.MinimumSize = new System.Drawing.Size(607, 363);
            this.Name = "frmMaestroConductor";
            this.Text = "frmMaestroConductor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaConductores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaConductores;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearConductor;
        private System.Windows.Forms.TextBox txtNombreConductor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxBuses;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConductorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
    }
}