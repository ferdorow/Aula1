using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra = string.Empty;
                                   
            Console.WriteLine("Digite uma palavra");
            palavra = Console.ReadLine();

            string caracA;
            string caracB;
            caracA = palavra[0].ToString();
            caracB = palavra[palavra.Length - 1].ToString();

            Console.WriteLine($"O primeiro caractere é {caracA} e o último caractere é {caracB}");
           

            Console.ReadKey();
        }
    }
}
