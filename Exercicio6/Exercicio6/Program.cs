using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string textoInicial;
            string textoFinal;

            Console.WriteLine("Digite um texto");
            textoInicial = Console.ReadLine().ToLower();
            textoFinal = textoInicial.Replace("banana", "laranja");

            Console.WriteLine (textoFinal);

            Console.ReadKey();
           

        }
    }
}
