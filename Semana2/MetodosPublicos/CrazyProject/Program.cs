using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArvoreTosquera();
            AreaQuadrado();
            ListaDeCervas();
            CarList();
        }


        public static void ArvoreTosquera()
        {
            Console.WriteLine("     /\\\\    ");
            Console.WriteLine("    //**\\\\  ");
            Console.WriteLine("   //****\\\\  ");
            Console.WriteLine("  //****** \\\\ ");
            Console.WriteLine("      ||     ");
            Console.WriteLine("      ||     ");

            Console.ReadLine();
            Console.Clear();


        }
        public static void AreaQuadrado()
        {
            double area = 0;
            double lado = 0;

            Console.WriteLine("Calculo da area de um quadrado...Entre com o lado do quadrado:");
            lado = double.Parse(Console.ReadLine());

            area = lado * lado;

            Console.WriteLine($"A area do quadrado é de {area} metros quadrados");
            Console.ReadKey();
            Console.Clear();
        }

        public static void ListaDeCervas()
        {
            var minhaLista = new List<string>();
            Console.WriteLine("A lista de cervejas contém as seguintes marcas:");
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
