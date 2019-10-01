using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarNome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informar uma sequencia de numeros:");
            var textContent = Console.ReadLine();

            Console.WriteLine(textContent.Replace("3", "Banana"));
            Console.ReadKey();
           
        }
    }
}
