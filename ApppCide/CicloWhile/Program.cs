using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowIniApppText();

            string nome = string.Empty;
            int idade = 0;
            string sexo = string.Empty;
            string nacionalidade = string.Empty


            while (AskToContinue() == 1)
            {
                nome = AskToName();
                idade = AskToAge();
            }

            Console.WriteLine($"Suas inforações: Nome {nome} e sua idade{idade}");
            Console.ReadKey();
                              
                     
        }
        /// <summary>
        /// Metodo para mostrar o texto inicial do sistema alone
        /// </summary>
        private static void ShowIniApppText()
                    
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("--Seja bem vindo!--");
            Console.WriteLine("-------------------");
        }
        ///<summary>
        ///Metodo para realizar a pergunta se deseja continuar
       
        private static int AskToContinue()
        {
            Console.WriteLine("Vamos conversar? sim(1) não(2)");
            return int.Parse(Console.ReadKey().KeyChar.ToString());



        }

        private static void AskToAge()
        {
            Console.WriteLine("Quantos anos vc tem?");
            int idade = int.Parse(Console.ReadLine());

            //testar se idade maior 18

            if (idade >= 18)
                Console.WriteLine($"Então vc pode beber!");
            else
            {
                Console.WriteLine("Tem Leite?");
                Console.WriteLine("Estou ligando pra sua mãe");
            }

            return idade;
                


        }
     
        private static string AskToName()
        {
            Console.WriteLine("Qual seu nome");
            return Console.ReadLine();
        }

    }
}
