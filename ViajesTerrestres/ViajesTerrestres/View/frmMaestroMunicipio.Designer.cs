namespace ViajesTerrestres.View
{
    partial class frmMaestroMunicipio
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
            this.btnCrearMunicipio = new System.Windows.Forms.Button();
            this.dgvListaMunicipios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreMunicipio = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMunicipios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // btnCrearMunicipio
            // 
            this.btnCrearMunicipio.Location = new System.Drawing.Point(434, 37);
            this.btnCrearMunicipio.Name = "btnCrearMunicipio";
            this.btnCrearMunicipio.Size = new System.Drawing.Size(75, 23);
            this.btnCrearMunicipio.TabIndex = 1;
            this.btnCrearMunicipio.Text = "Crear";
            this.btnCrearMunicipio.UseVisualStyleBackColor = true;
            this.btnCrearMunicipio.Click += new System.EventHandler(this.btnCrearMunicipio_Click);
            // 
            // dgvListaMunicipios
            // 
            this.dgvListaMunicipios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaMunicipios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre});
            this.dgvListaMunicipios.Location = new System.Drawing.Point(52, 94);
            this.dgvListaMunicipios.Name = "dgvListaMunicipios";
            this.dgvListaMunicipios.Size = new System.Drawing.Size(343, 149);
            this.dgvListaMunicipios.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "MunicipioId";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreMunicipio";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // txtNombreMunicipio
            // 
            this.txtNombreMunicipio.Location = new System.Drawing.Point(111, 42);
            this.txtNombreMunicipio.Name = "txtNombreMunicipio";
            this.txtNombreMunicipio.Size = new System.Drawing.Size(142, 20);
            this.txtNombreMunicipio.TabIndex = 4;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(434, 279);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmMaestroMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 324);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtNombreMunicipio);
            this.Controls.Add(this.dgvListaMunicipios);
            this.Controls.Add(this.btnCrearMunicipio);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(607, 363);
            this.MinimumSize = new System.Drawing.Size(607, 363);
            this.Name = "frmMaestroMunicipio";
            this.Text = "Maestro Municipios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMunicipios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearMunicipio;
        private System.Windows.Forms.DataGridView dgvListaMunicipios;
        private System.Windows.Forms.TextBox txtNombreMunicipio;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}