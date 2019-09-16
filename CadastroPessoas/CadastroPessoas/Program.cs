using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        private static void CadastroPessoas()
        {
            //variaveis contendo o conteudo da lista e o conteudo da lista separado
            var conteudo = "Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,Idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";
            var listaDeInformacoes = conteudo.Split(';');

            Console.WriteLine("Pessoas cadastradas no sistema");

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
                    Console.WriteLine($"O nome é {nome} e a idade é {idade}");
                }
                
            }
            Console.ReadKey();


        }
    }
}
