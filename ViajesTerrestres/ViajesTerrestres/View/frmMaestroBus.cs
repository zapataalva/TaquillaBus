using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViajesTerrestres.Controller;
using ViajesTerrestres.Data;

namespace ViajesTerrestres.View
{
    public partial class frmMaestroBus : Form
    {
        public frmMaestroBus()
        {
            InitializeComponent();
            ListarBuses();
            txtCapacidad.Text = "40";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void btnCrearBus_Click(object sender, EventArgs e)
        {
            
            Bus objBus = new Bus();

            if (!string.IsNullOrEmpty(txtPlaca.Text))
            {

                objBus.Placa = txtPlaca.Text;
                objBus.Capacidad = int.Parse(txtCapacidad.Text);
                new BusCT().CrearBuses(objBus);

            }
            ListarBuses();
        }

        public void ListarBuses()
        {
            var data = new BusCT().ListarBuses();
            dgvListaBuses.DataSource = new BindingSource(data, "");
            dgvListaBuses.Refresh();

        }
    }
}
