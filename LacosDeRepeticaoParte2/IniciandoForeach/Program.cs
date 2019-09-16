using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            ForeachComSplit2();

        }

        private static void IniciandoForEach()
        {


            Console.WriteLine("Informe a palavra pra realizar a busca");                                                                                  
            var conteudoDoTexto = Console.ReadLine();



            foreach (var item in conteudoDoTexto)
            {
                if (item == 'e')
                    continue;
                Console.WriteLine(item);
            }
        }

        private static void ForeachComSplit()
        {
            var conteudoDoTexto = "Aqui vou colocar meu nome Felipe para realizar a busca";

            Console.WriteLine("Informe a palavra pra realizar a busca");
            var palavra = Console.ReadLine();

            var conteudoTextoSplit = conteudoDoTexto.Split(' ');

            foreach (var item in conteudoTextoSplit)
            {
                if (palavra == item)
                    Console.WriteLine("palavra encontrada com sucesso");
            }

            Console.ReadKey();

        }
        private static void ForeachComSplit2()
        {
            var conteudoDoTexto = "Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleçãoe" +
                ";vamos;colocar;isto;fernando;para;depois;usar;com;o;replace";

            Console.WriteLine("Informe a palavra pra realizar a busca");
            var palavra = Console.ReadLine();

            var conteudoTextoSplit = conteudoDoTexto.Split(';');

            foreach (var item in conteudoTextoSplit)
            {
                if (palavra == item)
                    Console.WriteLine("palavra encontrada com sucesso");
            }

            Console.ReadKey();

        }
    }
}





