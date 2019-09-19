 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAlulaQuinta
{
    class Program
    {
        static void Main(string[] args)                      
        {
           

            List<int> numeros = new List<int>();
            Random rdm = new Random();

            int valorGeradoALeatoriamente = rdm.Next(100);

            for (int w = 0; w < 10; w++)
            {
                //Gera um numero aleatorio de 0 a 100
                int valorGeradoAleatoriamente = rdm.Next(100);
                //verifica se a lista nao contem este numero gerado
                if (!numeros.Contains(valorGeradoAleatoriamente))                               
                {
                    //adiciona o numero gerado pelo random
                    numeros.Add(valorGeradoAleatoriamente);
                }
                else
                {
                    w--; //retorna uma posição que havia sido incrementada no for e o valor era repetido na lista
                         //retorna na mesma posição e busca outro numero que n existia na lista
                }                

            }
            Console.ReadLine();
        }
    }
}
