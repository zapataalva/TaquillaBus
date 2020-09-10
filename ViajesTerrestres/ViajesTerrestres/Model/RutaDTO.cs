using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesTerrestres.Model
{
    public class RutaDTO
    {
        public int RutaId { get; set; }
        public int? MunicipioIdOrigen { get; set; }
        public int? MunicipioIdDestino { get; set; }
        public int? BusId { get; set; }
        public string Placa { get; set; }
        public string MunicipioOrigen { get; set; }
        public string MunicipioDestino { get; set; }
        public int? TicketId { get; set; }
    }
}
