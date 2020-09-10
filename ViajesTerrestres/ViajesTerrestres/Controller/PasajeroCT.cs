using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViajesTerrestres.Data;

namespace ViajesTerrestres.Controller
{
    public class PasajeroCT
    {
        public int CrearPasajero(Pasajero pasajero)
        {
            using (BDViajesTerrestresEntities db = new BDViajesTerrestresEntities())
            {
                db.Pasajero.Add(pasajero);
                db.SaveChanges();

                return pasajero.PasajeroId;
            }
        }

    }
}
