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
    public partial class VendasController
    {
        [HttpGet]
        [Route("Api/Carroes/VendasComCarros")]
        public object CustomVendasonCarros()
        {
            var listVendas = db.Vendas.ToList();
            var listCarros = db.Carros.ToList();

            var conteudoRetorno = from car in listCarros
                                  join ven in listVendas
                                  on car.Id equals ven.Carro
                                  select new
                                  {
                                      VendaId = ven.Id,
                                      CarroNome = car.Modelo

                                  };
            return conteudoRetorno;
        }
    }
}