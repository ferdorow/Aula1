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
            string textoInicial; //texto de entrada
            string textoFinal;  //texto de saída, já com a troca

            Console.WriteLine("Digite um texto"); 
            textoInicial = Console.ReadLine().ToLower(); //tolower converte letra maiuscula em minuscula
            textoFinal = textoInicial.Replace("banana", "laranja"); //replace substitui um por outro

            Console.WriteLine (textoFinal); //escrevendo o texto final

            Console.ReadKey();
           

        }
    }
}
