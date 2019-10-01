using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTypesConcat
{
    class Program
    {
        static void Main(string[] args)
        {

            var teste = "alguma coisa mais " +
                "alguma informação aqui";

            var teste1 = Console.ReadLine();
            var teste2 = Console.ReadLine();
            var teste3 = teste1 + "\r\n" + teste2;
            
            Console.WriteLine(teste3);

            Console.WriteLine(teste);
            Console.ReadKey();

              
        }
    }
}
