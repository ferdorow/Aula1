using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculandoIdade.Controllers
{
    /// <summary>
    /// Retorna nome da aplicação e o que ela faz
    /// </summary>
    /// <returns>Retonra o nosso app faz</returns>
    public class CalculoIdadeController : ApiController
    {        
        public string Get()
        {            
            return "App para poder beber hoje";
        }

        public string Get(string nome, int altura, int peso, int imc)
        {
            imc = (altura * altura) / peso;

            return $"Olá {nome} seu IMC é {imc} e ele foi calculado de acordo com sua Altura: {altura} e Peso: {peso}";           
        }
    }
}
