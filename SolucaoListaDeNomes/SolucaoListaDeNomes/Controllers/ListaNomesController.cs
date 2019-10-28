using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SolucaoListaDeNomes.Models;

namespace SolucaoListaDeNomes.Controllers
{
    public class ListaNomesController : ApiController
    {
        List<Pessoa> listaDePessoas = new List<Pessoa>()
        {
            new Pessoa(){ Nome = "Felipe", Idade = 55},
            new Pessoa(){ Nome = "Cliber", Idade = 22},
            new Pessoa(){ Nome = "Giomar", Idade = 18},
            new Pessoa(){ Nome = "Zeca", Idade = 64},
            new Pessoa(){ Nome = "Gumercindo", Idade = 33},
            new Pessoa(){ Nome = "Leoncio", Idade = 16},
            new Pessoa(){ Nome = "Fulanex", Idade = 44},
            new Pessoa(){ Nome = "Ciclanex", Idade = 80},
            new Pessoa(){ Nome = "Beltranex", Idade = 21},
            new Pessoa(){ Nome = "Zeca", Idade = 52},


        };
        public List<Pessoa> Get()
        {            
            return listaDePessoas;
        }

        public List<Pessoa> Post(Pessoa values)
        {
            listaDePessoas.Add(values);
            return listaDePessoas;

        }
    }
}
