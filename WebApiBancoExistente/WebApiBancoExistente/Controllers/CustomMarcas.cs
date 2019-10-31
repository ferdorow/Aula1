using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiBancoExistente.Models;

namespace WebApiBancoExistente.Controllers
{
    public partial class MarcasController
    {
        [HttpGet]
        [Route("Api/Marcas/CustomQuery")]
        public object CustomCarrosQuery()
        {
            var listaDemarcas = db.Marcas.ToList();

            var retornoMarcas = from mar in listaDemarcas
                                select new
                                {
                                    NomeMarca = mar.Nome,
                                    CarroId = mar.Id
                                };

            return retornoMarcas;

        }
    }
}