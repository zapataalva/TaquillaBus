using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViajesTerrestres.Data;
using ViajesTerrestres.Model;

namespace ViajesTerrestres.Controller
{
    public class ConductorCT
    {
        public List<ConductorDTO> ListarConductores()
        {
            using (BDViajesTerrestresEntities db = new BDViajesTerrestresEntities())
            {
                var query = (from conductor in db.Conductor
                             join bus in db.Bus on conductor.BusRefId equals bus.BusId
                             select new ConductorDTO
                             {
                                 ConductorId = conductor.ConductorId,
                                 BusId = conductor.BusRefId,
                                 NombreConductor = conductor.NombreConductor,
                                 Placa = bus.Placa,
                             }).ToList();
                    
                if (query.Any())
                {

                    return query;
                }
                return null;
            }
        }

        public void CrearConductores(Conductor conductor)
        {
            using (BDViajesTerrestresEntities db = new BDViajesTerrestresEntities())
            {
                db.Conductor.Add(conductor);
                db.SaveChanges();

            }
        }
    }
}
