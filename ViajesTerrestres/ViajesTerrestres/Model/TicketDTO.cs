using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesTerrestres.Model
{
    public class TicketDTO
    {
        public int TicketId { get; set; }
        public int? PasajeroId { get; set; }
        public int? RutaId { get; set; }
        public int? NumeroDeSilla { get; set; }
        public string NombrePasajero { get; set; }
        public string Placa { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
    }
}
