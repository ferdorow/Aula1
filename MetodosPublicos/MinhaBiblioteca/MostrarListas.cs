using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class MostrarListas
    {
        public static void ListaDeCervas()
        {
            var minhaLista = new List<string>();
            Console.WriteLine("A lista de cervajas contém as seguintes marcas:");
            Console.WriteLine("----------------------------------------------");

            minhaLista.Add("Brahma");
            minhaLista.Add("Skol");
            minhaLista.Add("Patagonia");
            minhaLista.Add("Budweiser");
            minhaLista.Add("Quilmes");
            minhaLista.Add("Polar");

            minhaLista.ForEach(i => Console.WriteLine(i)); //foreach simplificado para lista/coleções
            Console.ReadKey();
            Console.Clear();

            
        }

        public static void CarList()
        {
            var minhaLista = new List<string>();
            Console.WriteLine("A lista de carros contém as seguintes marcas:");
            Console.WriteLine("--------------------------------------------");

            minhaLista.Add("Volkswagen");
            minhaLista.Add("Fiat");
            minhaLista.Add("Renault");
            minhaLista.Add("Ford");
            minhaLista.Add("Chevrolet");
            minhaLista.Add("Toyota");

            minhaLista.ForEach(i => Console.WriteLine(i)); //foreach simplificado para lista/coleções
            Console.ReadKey();


        }
    }
}
