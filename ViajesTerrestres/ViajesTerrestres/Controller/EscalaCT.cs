using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViajesTerrestres.Data;
using ViajesTerrestres.Model;

namespace ViajesTerrestres.Controller
{
    public class EscalaCT
    {
        public List<EscalaDTO> ListarEscalas(int _RutaId)
        {
            using (BDViajesTerrestresEntities db = new BDViajesTerrestresEntities())
            {
                var query = (from escala in db.Escala
                             join parada in db.Municipio on escala.ParadaEscala equals parada.MunicipioId
                             where escala.RutaRefId == _RutaId
                             select new EscalaDTO
                             {
                                 EscalaId = escala.EscalaId,
                                 RutaId = escala.RutaRefId,
                                 ParadaEscala = parada.NombreMunicipio
                             }).ToList();

                if (query.Any())
                {

                    return query;
                }
                return null;
            }
        }

        public void CrearEscala(Escala escala)
        {
            using (BDViajesTerrestresEntities db = new BDViajesTerrestresEntities())
            {
                db.Escala.Add(escala);
                db.SaveChanges();

            }
        }
    }
}

