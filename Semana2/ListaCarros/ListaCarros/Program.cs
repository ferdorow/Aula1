using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsultaDePessoas();
        }
        private static void ConsultaDePessoas()
        {
            //variaveis contendo o conteudo da lista e o conteudo da lista separado
            var conteudo = "nome:Giomar,idade:17;nome:Edson,idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";
            var cadastro = conteudo.Split(';');

            Console.WriteLine("Pessoas cadastradas no sistema:");

            foreach (var item in cadastro)
            {
                Console.WriteLine(item.Split(',')[0]); // escreve os nomes da lista na posiçao 0
            }

            Console.WriteLine("Informe um nome de pessoa do sistema:");
            var nomeBusca = Console.ReadLine();

            foreach (var item in cadastro)
            {
                var informacoesSplit = item.Split(',');    //separando na virgula

                var nome = informacoesSplit[0].Split(':')[1];         //separando :
                var idade = int.Parse(informacoesSplit[1].Split(':')[1]);
                
                if (idade >= 18)
                    Console.WriteLine($"O nome do usuario é {nome} e a sua idade é {idade} anos:");
                                              
            }
            Console.ReadKey();

                        
        }
    }
}
