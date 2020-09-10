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
    public partial class frmMaestroConductor : Form
    {
        public frmMaestroConductor()
        {
            InitializeComponent();
            CargarComponentes();
            ListarConductores();
        }

        private void btnCrearConductor_Click(object sender, EventArgs e)
        {
            //lblMensaje.Visible = false;
            Conductor objConductor = new Conductor();

            if (!string.IsNullOrEmpty(txtNombreConductor.Text) && cbxBuses.SelectedIndex != 0)
            {

                objConductor.NombreConductor = txtNombreConductor.Text;
                objConductor.BusRefId = cbxBuses.SelectedIndex;
                
                new ConductorCT().CrearConductores(objConductor);

            }
            ListarConductores();
        }

        //Carga buses en el cbx
        public void CargarComponentes()
        {
            var ListBuses = new BusCT().ListarBuses();

            cbxBuses.Items.Clear();
            cbxBuses.Items.Insert(0, "Seleccione");

            foreach (var item in ListBuses)
            {

                cbxBuses.Items.Insert(item.BusId, item.Placa);

            }
            cbxBuses.Refresh();
            cbxBuses.SelectedIndex = 0;

        }

        public void ListarConductores()
        {
            var data = new ConductorCT().ListarConductores();
            dgvListaConductores.DataSource = new BindingSource(data, "");
            dgvListaConductores.Refresh();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
