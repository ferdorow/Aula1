using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Model
{
    public class SistemaCarrosContext
    {

        public List<Carro> ListaDeCarros { get; set; }

        public SistemaCarrosContext()
        {
            ListaDeCarros = new List<Carro>();

            ListaDeCarros.Add(new Carro() { Id = 1, Nome = "Volkswagen", Litros = "Fusca", Alcool = 1973, Valor = 1300 });
            ListaDeCarros.Add(new Carro() { Id = 2, Nome = "Fiat", Litros = "Uno", Alcool = 1995, Valor = 1000 });
            ListaDeCarros.Add(new Carro() { Id = 3, Nome = "Fiat", Litros = "Palio", Alcool = 2012, Valor = 1500 });
            ListaDeCarros.Add(new Carro() { Id = 4, Nome = "Volkswagen", Litros = "Golf", Alcool = 2015, Valor = 2000 });
            ListaDeCarros.Add(new Carro() { Id = 5, Nome = "Ford", Litros = "Focus", Alcool = 2012, Valor = 2015 });
            ListaDeCarros.Add(new Carro() { Id = 6, Nome = "Volkswagen", Litros = "Brasilia", Alcool = 1975, Valor = 1400 });
            ListaDeCarros.Add(new Carro() { Id = 7, Nome = "Renaul", Litros = "Clio", Alcool = 2010, Valor = 1600 });
            ListaDeCarros.Add(new Carro() { Id = 8, Nome = "Volkswagen", Litros = "Gol", Alcool = 2010, Valor = 1600 });
            ListaDeCarros.Add(new Carro() { Id = 9, Nome = "Citroen", Litros = "Aicross", Alcool = 2017, Valor = 2200 });
            ListaDeCarros.Add(new Carro() { Id = 10, Nome = "Ferraro", Litros = "Testarossa", Alcool = 2005, Valor = 3000 });
                                  

        }

    }
}
