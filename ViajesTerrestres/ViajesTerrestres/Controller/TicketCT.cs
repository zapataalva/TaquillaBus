using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViajesTerrestres.Data;
using ViajesTerrestres.Model;

namespace ViajesTerrestres.Controller
{
    class TicketCT
    {
        public int CrearTicket(Ticket ticket)
        {
            using (BDViajesTerrestresEntities db = new BDViajesTerrestresEntities())
            {
                db.Ticket.Add(ticket);
                db.SaveChanges();

                
                return ticket.TicketId;
            }
        }

        public TicketDTO ConsultarTicket(int ticketId)
        {
            using (BDViajesTerrestresEntities db = new BDViajesTerrestresEntities())
            {
                var query = (from ticket in db.Ticket
                             join ruta in db.Ruta on ticket.RutaRefId equals ruta.RutaId
                             join origen in db.Municipio on ruta.MunicipioOrigenId equals origen.MunicipioId
                             join destino in db.Municipio on ruta.MunicipioDestinoId equals destino.MunicipioId
                             join bus in db.Bus on ruta.BusRefId equals bus.BusId
                             join pasajero in db.Pasajero on ticket.PasajeroRefId equals pasajero.PasajeroId
                             where ticket.TicketId == ticketId
                             select new TicketDTO
                             {
                                 TicketId = ticket.TicketId,
                                 PasajeroId = ticket.PasajeroRefId,
                                 RutaId = ticket.RutaRefId,
                                 NumeroDeSilla = ticket.NumeroDeSilla,
                                 Placa = bus.Placa,
                                 Origen = origen.NombreMunicipio,
                                 Destino = destino.NombreMunicipio,
                                 NombrePasajero = pasajero.NombrePasajero
                             }).ToList();

                if (query.Any())
                {

                    return query.FirstOrDefault();
                }
                return null;
            }
        }
    }
}
