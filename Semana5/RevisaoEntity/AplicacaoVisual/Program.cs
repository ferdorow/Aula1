﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RevisandoEntity.Model;
using RevisandoEntity.Controller;

namespace AplicacaoVisual
{
    class Program
    {
        //1-Setar a aplicação visual para startar o projeto
        //2-Vamos adicionar o EntityFramework ao nosso projeto console
        //3-Colocar em nosso Using o System.Data.Entity
        //4-Adicionar a referência da nossa ClassLibrary

        //static CervejaContextDB cerveja = new CervejaContextDB();

        static CervejaController cerveja = new CervejaController();
        static void Main(string[] args)
        {
            /* cerveja.Cervejas.Add(new Cerveja() { Nome = "Giomar" });


             cerveja.SaveChanges(); */

            /*cerveja.Cervejas.ToList<Cerveja>().ForEach(x => Console.WriteLine(x.Nome));*/

            cerveja.AddCerveja(new Cerveja() { Nome = "Skol Cerveja" });

            cerveja.GetCervejas().ToList<Cerveja>().ForEach(x => Console.WriteLine(x.Nome));

            Console.ReadKey();
        }
    }
}
