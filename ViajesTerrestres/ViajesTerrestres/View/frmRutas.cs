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

namespace ViajesTerrestres.View
{
    public partial class frmRutas : Form
    {
        Escala escala = new Escala();
        public frmRutas()
        {
            InitializeComponent();
            CargarComponentes();
            ListarRutas();
            btnAgregarEscalas.Visible = false;
        }

        private void btnCrearRuta_Click(object sender, EventArgs e)
        {
            Ruta objRuta = new Ruta();

            if (cbxDestino.SelectedIndex != 0 && cbxBuses.SelectedIndex != 0 && cbxOrigen.SelectedIndex != 0)
            {

                objRuta.BusRefId = cbxBuses.SelectedIndex;
                objRuta.MunicipioOrigenId = cbxOrigen.SelectedIndex;
                objRuta.MunicipioDestinoId = cbxDestino.SelectedIndex;


                new RutaCT().CrearRutas(objRuta);

            }
            ListarRutas();
        }

        public void CargarComponentes()
        {
            var ListMunicipios = new MunicipioCT().ListarMunicipios();
            var ListBuses = new BusCT().ListarBuses();

            cbxOrigen.Items.Clear();
            cbxOrigen.Items.Insert(0, "Seleccione");

            cbxBuses.Items.Clear();
            cbxBuses.Items.Insert(0, "Seleccione");

            cbxDestino.Items.Clear();
            cbxDestino.Items.Insert(0, "Seleccione");

            foreach (var item in ListMunicipios)
            {
                cbxOrigen.Items.Insert((int)item.MunicipioId, item.NombreMunicipio);
                cbxDestino.Items.Insert((int)item.MunicipioId, item.NombreMunicipio);
            }

            foreach (var item in ListBuses)
            {
                cbxBuses.Items.Insert((int)item.BusId, item.Placa);
            
            }
            cbxBuses.Refresh();
            cbxBuses.SelectedIndex = 0;
            cbxOrigen.Refresh();
            cbxOrigen.SelectedIndex = 0;
            cbxDestino.Refresh();
            cbxDestino.SelectedIndex = 0;
            

        }

        public void ListarRutas()
        {
            var data = new RutaCT().ListarRutas();
            dgvListaRutas.DataSource = new BindingSource(data, "");
            dgvListaRutas.Refresh();

        }

        public void ListarEscalas(int _RutaId)
        {
            var data = new EscalaCT().ListarEscalas(_RutaId);
            dgvListaEscalas.DataSource = new BindingSource(data, "");
            dgvListaEscalas.Refresh();

        }

        private void btnAgregarEscalas_Click(object sender, EventArgs e)
        {
            if (cbxEscalas.SelectedIndex != 0)
            {
                escala.ParadaEscala = cbxEscalas.SelectedIndex;
                new EscalaCT().CrearEscala(escala);
                ListarEscalas((int)escala.RutaRefId);
            }   
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvListaRutas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            btnAgregarEscalas.Visible = true;
            var ListMunicipios = new MunicipioCT().ListarMunicipios();
            cbxEscalas.Items.Clear();
            cbxEscalas.Items.Insert(0, "Seleccione");

            foreach (var item in ListMunicipios)
            {
                cbxEscalas.Items.Insert((int)item.MunicipioId, item.NombreMunicipio);
            }
            cbxEscalas.Refresh();
            cbxEscalas.SelectedIndex = 0;
            escala.RutaRefId = int.Parse(dgvListaRutas.Rows[e.RowIndex].Cells["RutaId"].Value.ToString());
            escala.ParadaEscala = cbxEscalas.SelectedIndex;
            ListarEscalas((int)escala.RutaRefId);
        }
    }
}
