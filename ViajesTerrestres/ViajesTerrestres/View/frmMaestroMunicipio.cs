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
    public partial class frmMaestroMunicipio : Form
    {
        public frmMaestroMunicipio()
        {
            InitializeComponent();
            ListarMunicipios();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrearMunicipio_Click(object sender, EventArgs e)
        {
            Municipio objMunicipio = new Municipio();

            if (!string.IsNullOrEmpty(txtNombreMunicipio.Text))
            {
                
                objMunicipio.NombreMunicipio = txtNombreMunicipio.Text;
                new MunicipioCT().CrearMunicipios(objMunicipio);

            }
            ListarMunicipios();
        }

        public void ListarMunicipios()
        {
            var data = new MunicipioCT().ListarMunicipios();
            dgvListaMunicipios.DataSource = new BindingSource(data,"");
            dgvListaMunicipios.Refresh();

        }
    }
}
