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
using ConnectDbInnerJoin.Models;

namespace ConnectDbInnerJoin.Controllers
{
    public class VendasController : ApiController
    {
        private DataBaseContext db = new DataBaseContext();

        [HttpGet]
        [Route("Api/Vendas/VendasRelatorios/{ano}")]
        public object CustomVendasYearSearch(int ano)
        {
            var listVendas = db.Vendas.ToList();
            var listCarros = db.Carros.ToList();
           
            var conteudoRetorno = from ven in listVendas
                                  join car in listCarros
                                  on ven.Carro equals car.Id
                                  where ven.DatInc.Year == ano
                                  select new
                                  {
                                   vendasId = ven.Id,
                                   carroVendido = car.Modelo,
                                   quantidadeDeVendas = ven.Quantidade,

                                  };
            return conteudoRetorno;
        }        

        [HttpGet]
        [Route("Api/Vendas/RelatorioAnual")]
        public object CustomVendasbyYear()
        {
            var listVendas = db.Vendas.ToList();
            var listUsuarios = db.Usuarios.ToList();

            var conteudoRetorno = from ven in listVendas
                                  join usu in listUsuarios
                                  on ven.UsuInc equals usu.Id
                                  select new
                                  {
                                    Vendedor = usu.Usuario,
                                    AnoVenda = ven.DatInc.Year

                                  };
            return conteudoRetorno;
        }

        [HttpGet]
        [Route("Api/VendasPorMarcas/MarcaMaisVendida")]
        public object CustomVendasOnYear()
        {
            var listVendas = db.Vendas.ToList();
            var listCarros = db.Carros.ToList();
            var listMarcas = db.Marcas.ToList();

            var conteudoRetorno = from ven in listVendas
                                  join car in listCarros
                                  on ven.Carro equals car.Id
                                  join mar in listMarcas
                                  on car.Marca equals mar.Id
                                  group new { ven, mar, car } by new { ven.DatInc.Year, mar.Nome } into groupby
                                  select new
                                  {
                                      AnoVenda = groupby.Key.Year,
                                      MarcaVendida = groupby.Key.Nome,
                                      QuantidadeAnualVendas = groupby.Sum(p => p.ven.Quantidade)
                                  };
            return conteudoRetorno;
        }


        // GET: api/Vendas
        public IQueryable<Vendas> GetVendas()
        {
            return db.Vendas;
        }

        // GET: api/Vendas/5
        [ResponseType(typeof(Vendas))]
        public IHttpActionResult GetVendas(int id)
        {
            Vendas vendas = db.Vendas.Find(id);
            if (vendas == null)
            {
                return NotFound();
            }

            return Ok(vendas);
        }

        // PUT: api/Vendas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVendas(int id, Vendas vendas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vendas.Id)
            {
                return BadRequest();
            }

            db.Entry(vendas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Vendas
        [ResponseType(typeof(Vendas))]
        public IHttpActionResult PostVendas(Vendas vendas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Vendas.Add(vendas);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = vendas.Id }, vendas);
        }

        // DELETE: api/Vendas/5
        [ResponseType(typeof(Vendas))]
        public IHttpActionResult DeleteVendas(int id)
        {
            Vendas vendas = db.Vendas.Find(id);
            if (vendas == null)
            {
                return NotFound();
            }

            db.Vendas.Remove(vendas);
            db.SaveChanges();

            return Ok(vendas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VendasExists(int id)
        {
            return db.Vendas.Count(e => e.Id == id) > 0;
        }
    }
}