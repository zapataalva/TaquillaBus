using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViajesTerrestres.Data;
using ViajesTerrestres.Model;

namespace ViajesTerrestres.Controller
{
    public class RutaCT
    {
        public List<RutaDTO> ListarRutas()
        {
            using (BDViajesTerrestresEntities db = new BDViajesTerrestresEntities())
            {
                var query = (from ruta in db.Ruta
                             join origen in db.Municipio on ruta.MunicipioOrigenId equals origen.MunicipioId
                             join destino in db.Municipio on ruta.MunicipioDestinoId equals destino.MunicipioId
                             join bus in db.Bus on ruta.BusRefId equals bus.BusId
                             select new RutaDTO
                             {
                                 RutaId = ruta.RutaId,
                                 MunicipioIdOrigen = ruta.MunicipioOrigenId,
                                 MunicipioIdDestino = ruta.MunicipioDestinoId,
                                 BusId = ruta.BusRefId,
                                 Placa = bus.Placa,
                                 MunicipioOrigen = origen.NombreMunicipio,
                                 MunicipioDestino = destino.NombreMunicipio
                             }).ToList();

                if (query.Any())
                {

                    return query;
                }
                return null;
            }
        }

        public void CrearRutas(Ruta ruta)
        {
            using (BDViajesTerrestresEntities db = new BDViajesTerrestresEntities())
            {
                db.Ruta.Add(ruta);
                db.SaveChanges();

            }
        }
    }
}
