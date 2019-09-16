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
            ForeachComSplitLista();

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

        private static void ForeachComSplitLista()
        {
            var conteudo = "nome:Fernando,idade:27;nome:Giomar,idade:75;nome:Eusebio,idade:29";
            var listaDeInformacoes = conteudo.Split(';');

            Console.WriteLine("Usuarios cadastrados no sistema");

            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);

            }

            Console.WriteLine("Informe um nome do sistema:");
            var nomeBusca = Console.ReadLine();

            foreach (var item in listaDeInformacoes)
            {
                var informacoesSplit = item.Split(',');

                var nome = informacoesSplit[0].Split(':')[1];
                var idade = informacoesSplit[1].Split(':')[1];

                if (nome == nomeBusca)

                {
                    Console.WriteLine($"O {nome} esta com a {idade} anos de idade.");
                }
                
            }
            Console.ReadKey();





        }



    }
}





