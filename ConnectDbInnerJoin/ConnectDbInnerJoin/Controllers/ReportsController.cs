using ConnectDbInnerJoin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ConnectDbInnerJoin.Controllers
{
    public class ReportsController : ApiController
    {
        DataBaseContext db = new DataBaseContext();

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
                                      IdDaVenda = ven.Id,
                                      carroVendido = car.Modelo,
                                      quantidadeDeVendas = ven.Quantidade,

                                  };
            return conteudoRetorno;
        }

        [HttpGet]
        [Route("Api/Vendas/RelatorioAnual/{ano}/{usuario}")]
        public object RelAnoUsuario(int ano, int usuario)
        {
            var listUsuarios = db.Usuarios.ToList();

            var listVendas = db.Vendas.Where(x => x.DatInc.Year == ano && x.UsuInc == usuario).ToList();

            var listCarros = db.Carros.ToList();

            var conteudoRetorno = from ven in listVendas
                                  join car in listCarros
                                  on ven.Carro equals car.Id
                                  join usu in listUsuarios
                                  on ven.UsuInc equals usu.Id
                                  select new
                                  {
                                      IdDaVenda = ven.Id,
                                      Usuario = usu.Usuario,
                                      carroVendido = car.Modelo,
                                      quantidadeDeVendas = ven.Quantidade

                                  };
                                                                        
            return conteudoRetorno;
        }

        [HttpGet]
        [Route("Api/VendasPorMarcas/MarcaMaisVendida/{ano}/{marca}")]
        public object CustomVendasOnYear(int ano, int marca)
        {
            var listVendas = db.Vendas.ToList();
            var listCarros = db.Carros.ToList();
            var listMarcas = db.Marcas.ToList();

            var conteudoRetorno = from ven in listVendas
                                  join car in listCarros
                                  on ven.Carro equals car.Id
                                  join mar in listMarcas
                                  on car.Marca equals mar.Id
                                  where ven.DatInc.Year == ano
                                  && mar.Id == marca
                                  group new { ven, mar } by new { ven.DatInc.Month, Label = mar.Nome } into groupby
                                  select new
                                  {
                                      PeriodoVenda = groupby.Key.Month,
                                      MarcaVendida = groupby.Key,
                                      ValorTotalVendas = groupby.Sum(p => p.ven.Quantidade * p.ven.Valor)
                                  };

            return conteudoRetorno.OrderByDescending(x => x.ValorTotalVendas);
        }
    }
}
