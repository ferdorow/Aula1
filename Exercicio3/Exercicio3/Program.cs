using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;

            Console.WriteLine("Qual o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Qual a sua idade?");
            idade = int.Parse(Console.ReadLine());
                       
            if (idade >= 18)
                Console.WriteLine($"Parabéns {nome} você ja está na fase adulta ");

            else

                Console.WriteLine($"Calma {nome} tudo ao seu tempo logo você terá 18 anos de idade.");

            Console.ReadKey();

        





        }       


            
    }
}
