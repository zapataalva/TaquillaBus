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

namespace ViajesTerrestres.View
{
    public partial class frmTicket : Form
    {
        int _ticketId;
        public frmTicket(int ticketId)
        {
            InitializeComponent();
            _ticketId = ticketId;
        }

        private void frmTicket_Load(object sender, EventArgs e)
        {
            TicketCT ticket = new TicketCT();
            var data = ticket.ConsultarTicket(_ticketId);
            lblPlaca.Text = data.Placa;
            lblOrigen.Text = data.Origen;
            lblDestino.Text = data.Destino;
            lblNombre.Text = data.NombrePasajero;
            lblNumSilla.Text = data.NumeroDeSilla.ToString();
             
        }
    }
}
