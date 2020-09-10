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
    public partial class frmReportePasajero : Form
    {
        public frmReportePasajero()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarReporte_Click(object sender, EventArgs e)
        {
            Pasajero objPasajero = new Pasajero();

            if (!string.IsNullOrEmpty(txtNombrePasajero.Text))
            {
                objPasajero.NombrePasajero = txtNombrePasajero.Text;
                new ReporteCT().CrearReporte(objPasajero);
            }
            GenerarReporte(txtNombrePasajero.Text);
        }

        public void GenerarReporte(string nombrefiltro)
        {
            var data = new ReporteCT().GenerarReporte(nombrefiltro);
            dgvListaReporte.DataSource = new BindingSource(data, "");
            dgvListaReporte.Refresh();
        }
    }
}
