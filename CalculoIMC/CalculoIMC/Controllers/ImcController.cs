using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CalculoIMC.Controllers 
{
      [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ImcController : ApiController
    {
        public string Get()
        {
            return "App para calculo de IMC.";
        }


        public string Post(Pessoa pessoa)
        {
            
           double imc = pessoa.peso / (pessoa.altura * pessoa.altura);

            return $"Olá {pessoa.nome}, seu IMC é {imc} e ele foi calculado de acordo com sua Altura: {pessoa.altura} e Peso: {pessoa.peso}kg";           
        }
    }
}
