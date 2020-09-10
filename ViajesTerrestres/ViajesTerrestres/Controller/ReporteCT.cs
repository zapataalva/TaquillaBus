using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViajesTerrestres.Data;
using ViajesTerrestres.Model;

namespace ViajesTerrestres.Controller
{
    public class ReporteCT
    {
        public List<PasajeroDTO> GenerarReporte(string nombre)
        {
            using (BDViajesTerrestresEntities db = new BDViajesTerrestresEntities())
            {
                var query = (from ticket in db.Ticket
                             join pasajero in db.Pasajero on ticket.PasajeroRefId equals pasajero.PasajeroId
                             join ruta in db.Ruta on ticket.RutaRefId equals ruta.RutaId
                             join origen in db.Municipio on ruta.MunicipioOrigenId equals origen.MunicipioId
                             join destino in db.Municipio on ruta.MunicipioDestinoId equals destino.MunicipioId
                             join bus in db.Bus on ruta.BusRefId equals bus.BusId
                             where (nombre == pasajero.NombrePasajero)
                             select new PasajeroDTO
                             {
                                 RutaId = ruta.RutaId,
                                 MunicipioOrigen = origen.NombreMunicipio,
                                 MunicipioDestino = destino.NombreMunicipio,
                                 BusId = bus.BusId,
                                 Placa = bus.Placa,
                                 NombrePasajero = pasajero.NombrePasajero,
                                 MunicipioIdDestino = destino.MunicipioId,
                                 MunicipioIdOrigen = origen.MunicipioId


                             }).ToList();

                if (query.Any())
                {

                    return query;
                }
                return null;
            }
        }
        public void CrearReporte(Pasajero pasajero)
        {
            using (BDViajesTerrestresEntities db = new BDViajesTerrestresEntities())
            {
                db.Pasajero.Add(pasajero);
                db.SaveChanges();

            }
        }
    }
}
