using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesTerrestres.Model
{
    public class ConductorDTO
    {
        public int ConductorId { get; set; }
        public int? BusId { get; set; }
        public string NombreConductor  { get; set; }
        public string Placa { get; set; }
        
    }
}
