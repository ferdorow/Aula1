using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string textoCompleto;

            Console.WriteLine("Digite um texto");
            textoCompleto = Console.ReadLine();
            Console.WriteLine($"O texto possui {textoCompleto.Length} caracteres.");

            Console.ReadKey();



        }
    }
}
