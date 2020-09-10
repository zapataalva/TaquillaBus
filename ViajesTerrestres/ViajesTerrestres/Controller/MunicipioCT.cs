using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViajesTerrestres.Data;
using ViajesTerrestres.Model;

namespace ViajesTerrestres.Controller
{
    public class MunicipioCT
    {
        public List<MunicipioDTO> ListarMunicipios()
        {
            using (BDViajesTerrestresEntities db = new BDViajesTerrestresEntities())
            {
                var query = db.Municipio.Select(x => new MunicipioDTO
                {
                    MunicipioId = x.MunicipioId,
                    NombreMunicipio = x.NombreMunicipio,
                }).ToList();
                if (query.Any())
                {

                    return query;
                }
                return null;
            }
        }

        public void CrearMunicipios(Municipio municipio)
        {
            using (BDViajesTerrestresEntities db = new BDViajesTerrestresEntities())
            {
                db.Municipio.Add(municipio);
                db.SaveChanges();

            }
        }
    }
}
