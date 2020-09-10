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
using ViajesTerrestres.Model;
using ViajesTerrestres.View;

namespace ViajesTerrestres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            
        }

        private void btnMenuBus_Click(object sender, EventArgs e)
        {
            frmMaestroBus frmMaestroBuses = new frmMaestroBus();
            frmMaestroBuses.Show();

        }

        private void btnMenuConductores_Click(object sender, EventArgs e)
        {
            frmMaestroConductor frmMaestroConductores = new frmMaestroConductor();
            frmMaestroConductores.Show();

        }

        private void btnMenuMunicipios_Click(object sender, EventArgs e)
        {
            frmMaestroMunicipio frmMaestroMunicipios = new frmMaestroMunicipio();
            frmMaestroMunicipios.Show();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RutaCT ruta = new RutaCT();
            var data = ruta.ListarRutas()
                .Where(
                x => x.MunicipioIdOrigen == cbxOrigen.SelectedIndex && x.MunicipioIdDestino == cbxDestino.SelectedIndex)
                .ToList();
            dgvBusesRutas.DataSource = new BindingSource(data, "");
            dgvBusesRutas.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarComponentes();
        }

        public void CargarComponentes()
        {
            var ListMunicipios = new MunicipioCT().ListarMunicipios();

            cbxOrigen.Items.Clear();
            cbxOrigen.Items.Insert(0, "Seleccione");

            cbxDestino.Items.Clear();
            cbxDestino.Items.Insert(0, "Seleccione");

            foreach (var item in ListMunicipios)
            {

                cbxOrigen.Items.Insert(cbxOrigen.Items.Count, item.NombreMunicipio);
                cbxDestino.Items.Insert(cbxDestino.Items.Count, item.NombreMunicipio);

            }
            cbxOrigen.Refresh();
            cbxOrigen.SelectedIndex = 0;

            cbxDestino.Refresh();
            cbxDestino.SelectedIndex = 0;


        }

        private void btnMenuRutas_Click(object sender, EventArgs e)
        {
            frmRutas frmrutas = new frmRutas();
            frmrutas.Show();
        }

        private void btnMenuReporte_Click(object sender, EventArgs e)
        {
            frmReportePasajero frmReporte = new frmReportePasajero();
            frmReporte.Show();
        }

        private void dgvBusesRutas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtPlaca.Text = dgvBusesRutas.Rows[e.RowIndex].Cells["Placa"].Value.ToString();
            txtOrigen.Text = dgvBusesRutas.Rows[e.RowIndex].Cells["MunicipioOrigen"].Value.ToString();
            txtDestino.Text = dgvBusesRutas.Rows[e.RowIndex].Cells["MunicipioDestino"].Value.ToString();
            txtDestinoId.Text = dgvBusesRutas.Rows[e.RowIndex].Cells["MunicipioIdDestino"].Value.ToString();
            txtOrigenId.Text = dgvBusesRutas.Rows[e.RowIndex].Cells["MunicipioIdOrigen"].Value.ToString();
            txtRutaId.Text = dgvBusesRutas.Rows[e.RowIndex].Cells["RutaId"].Value.ToString();
        }

        private void btnGenerarTicket_Click(object sender, EventArgs e)
        {
            
            lblMensaje.Text = "";
            if (ValidacionGenerarTicket())
            {
                
                TicketDTO ticket = new TicketDTO();

                ticket.NombrePasajero = txtNombre.Text;
                ticket.Origen = txtOrigen.Text;
                ticket.Destino = txtDestino.Text;

                Pasajero pasajero = new Pasajero();
                pasajero.NombrePasajero = txtNombre.Text;
                pasajero.Tapabocas = chkTapaBocas.Checked;

                var pasajeroID = new PasajeroCT().CrearPasajero(pasajero);

                int ticketeID = 0;
                if (pasajeroID > 0)
                {
                    
                    Ticket tickete = new Ticket();

                    tickete.PasajeroRefId = pasajeroID;
                    tickete.RutaRefId = int.Parse(txtRutaId.Text);
                    tickete.NumeroDeSilla = 2; //Revisar

                    ticketeID = new TicketCT().CrearTicket(tickete);

                }
                frmTicket frmticket = new frmTicket(ticketeID);

                frmticket.ShowDialog(this);


            }
           

            
        }

        public bool ValidacionGenerarTicket()
        {
            bool result = true;
            if (!chkTapaBocas.Checked)
            {
                lblMensaje.Text = "Se requiere el tapabocas";
                result = false;
            }
            if (string.IsNullOrEmpty(txtPlaca.Text))
            {
                lblMensaje.Text = "Se requiere la placa";
                result = false;
            }
            if (string.IsNullOrEmpty(txtOrigen.Text))
            {
                lblMensaje.Text = "Se requiere el origen";
                result = false;
            }
            if (string.IsNullOrEmpty(txtDestino.Text))
            {
                lblMensaje.Text = "Se requiere el destino";
                result = false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                lblMensaje.Text = "Se requiere el nombre";
                result = false;
            }
            return result;
        }   
    }
}
