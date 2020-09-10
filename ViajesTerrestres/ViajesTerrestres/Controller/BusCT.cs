using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViajesTerrestres.Data;
using ViajesTerrestres.Model;

namespace ViajesTerrestres.Controller
{
    public class BusCT
    {
        public List<BusDTO> ListarBuses()
        {
            using (BDViajesTerrestresEntities db = new BDViajesTerrestresEntities())
            {
                var query = db.Bus.Select(x => new BusDTO
                {
                    BusId = x.BusId,
                    Placa = x.Placa,
                    Capacidad = x.Capacidad,
                }).ToList();
                if (query.Any())
                {

                    return query;
                }
                return null;
            }
        }

        public void CrearBuses(Bus bus)
        {
            using (BDViajesTerrestresEntities db = new BDViajesTerrestresEntities())
            {
                db.Bus.Add(bus);
                db.SaveChanges();

            }
        }
    }
}
