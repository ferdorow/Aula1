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

            ListaDeCarros.Add(new Carro() { Id = 1, Marca = "Volkswagen", Modelo = "Fusca", Ano = 1973, Cilindradas = 1300 });
            ListaDeCarros.Add(new Carro() { Id = 2, Marca = "Fiat", Modelo = "Uno", Ano = 1995, Cilindradas = 1000 });
            ListaDeCarros.Add(new Carro() { Id = 3, Marca = "Fiat", Modelo = "Palio", Ano = 2012, Cilindradas = 1500 });
            ListaDeCarros.Add(new Carro() { Id = 4, Marca = "Volkswagen", Modelo = "Golf", Ano = 2015, Cilindradas = 2000 });
            ListaDeCarros.Add(new Carro() { Id = 5, Marca = "Ford", Modelo = "Focus", Ano = 2012, Cilindradas = 2015 });
            ListaDeCarros.Add(new Carro() { Id = 6, Marca = "Volkswagen", Modelo = "Brasilia", Ano = 1975, Cilindradas = 1400 });
            ListaDeCarros.Add(new Carro() { Id = 7, Marca = "Renaul", Modelo = "Clio", Ano = 2010, Cilindradas = 1600 });
            ListaDeCarros.Add(new Carro() { Id = 8, Marca = "Volkswagen", Modelo = "Gol", Ano = 2010, Cilindradas = 1600 });
            ListaDeCarros.Add(new Carro() { Id = 9, Marca = "Citroen", Modelo = "Aicross", Ano = 2017, Cilindradas = 2200 });
            ListaDeCarros.Add(new Carro() { Id = 10, Marca = "Ferraro", Modelo = "Testarossa", Ano = 2005, Cilindradas = 3000 });
                                  

        }

    }
}
