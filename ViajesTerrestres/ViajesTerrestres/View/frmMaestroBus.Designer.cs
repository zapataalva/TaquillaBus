namespace ViajesTerrestres.View
{
    partial class frmMaestroBus
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.btnCrearBus = new System.Windows.Forms.Button();
            this.dgvListaBuses = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaBuses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capacidad";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(75, 41);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 2;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Enabled = false;
            this.txtCapacidad.Location = new System.Drawing.Point(271, 44);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidad.TabIndex = 3;
            // 
            // btnCrearBus
            // 
            this.btnCrearBus.Location = new System.Drawing.Point(433, 41);
            this.btnCrearBus.Name = "btnCrearBus";
            this.btnCrearBus.Size = new System.Drawing.Size(75, 23);
            this.btnCrearBus.TabIndex = 4;
            this.btnCrearBus.Text = "Crear";
            this.btnCrearBus.UseVisualStyleBackColor = true;
            this.btnCrearBus.Click += new System.EventHandler(this.btnCrearBus_Click);
            // 
            // dgvListaBuses
            // 
            this.dgvListaBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaBuses.Location = new System.Drawing.Point(38, 112);
            this.dgvListaBuses.Name = "dgvListaBuses";
            this.dgvListaBuses.Size = new System.Drawing.Size(333, 150);
            this.dgvListaBuses.TabIndex = 5;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(433, 289);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmMaestroBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 324);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvListaBuses);
            this.Controls.Add(this.btnCrearBus);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(607, 363);
            this.MinimumSize = new System.Drawing.Size(607, 363);
            this.Name = "frmMaestroBus";
            this.Text = "Maestro Bus";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaBuses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Button btnCrearBus;
        private System.Windows.Forms.DataGridView dgvListaBuses;
        private System.Windows.Forms.Button btnVolver;
    }
}