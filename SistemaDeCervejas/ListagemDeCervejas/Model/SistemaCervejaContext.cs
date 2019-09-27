using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    public class SistemaCervejaContext
    {

        public List<Cerveja> ListaDeCervejas { get; set; }

        public int contadorCerveja = 1;

        public SistemaCervejaContext()
        {
            ListaDeCervejas = new List<Cerveja>();

            ListaDeCervejas.Add(new Cerveja() { Id = contadorCerveja++, Nome = "Skol", Litros = 1.00, Alcool = 5.1, Valor = 4.2 });
            ListaDeCervejas.Add(new Cerveja() { Id = contadorCerveja++, Nome = "Brahma", Litros = 0.600, Alcool = 4.6, Valor = 3.75 });
            ListaDeCervejas.Add(new Cerveja() { Id = contadorCerveja++, Nome = "Budweiser", Litros = 0.350, Alcool = 3.8, Valor = 4.5 });
            ListaDeCervejas.Add(new Cerveja() { Id = contadorCerveja++, Nome = "Stella Artois", Litros = 0.600, Alcool = 3.5, Valor = 4.7 });
            ListaDeCervejas.Add(new Cerveja() { Id = contadorCerveja++, Nome = "Patagonia", Litros = 0.600, Alcool = 3.5, Valor = 3.7 });                               

        }
    
                
    }
}
