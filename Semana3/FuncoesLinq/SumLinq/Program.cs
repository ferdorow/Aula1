using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            SomarInteirosPrimitivos();

            SomaInteirosLista();

            SomaBalasListaDeCriancas();

            Console.ReadKey();

        }
        /// <summary>
        /// Metodo que mostra numeros inteiros por um tipo primitivo
        /// </summary>
        private static void SomarInteirosPrimitivos()
        {
            //quando utilizamos "[]" em um tipo "primitivo" podemos criar uma colecao desses valores
            //Aqui carregamos nossa coeleção de valores e
            //... no "int[5]" alocamos memoria que vamos ocupar
            int[] colecaoInteiros = new int[5] { 1, 2, 3, 4, 5 };

            //Aqui somamos os valores em nossa lista
            Console.WriteLine(colecaoInteiros.Sum());
        }
        /// <summary>
        /// Metodo que soma valores de [um em um] em uma lista
        /// </summary>
        private static void SomaInteirosLista()
        {
            List<int> listaDeInteiros = new List<int>()
            {
                //nossa coleção de valores
                1,2,3,4,5,6,7,8,9,10,11,12
            };

            Console.WriteLine(listaDeInteiros.Sum());
        }
        private static void SomaBalasListaDeCriancas()
        {
            List<Crianca> criancas = new List<Crianca>()
            {
                new Crianca
                {
                    Nome = "Joazinho",
                    Balas = 9
                },
               new Crianca
               {
               Nome = "Pedrinho",
               Balas = 68

               }
            };
            Console.WriteLine("Quantidade total de balas que as criancinhas levaram da venda");
                                        //soma nossa quantidade de balas
            Console.WriteLine(criancas.Sum(x => x.Balas));
        }
    }

}

