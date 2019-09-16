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
            ConsultaDeCarros();
        }
        private static void ConsultaDeCarros()
        {
            //variaveis contendo o conteudo da lista e o conteudo da lista separado
            var conteudo = "carro:Gol,marca:volkswagen,ano:2000;carro:Jetta,marca:volkswagen,ano:2012;carro:Sportage,marca:Kia,ano:2011;carro:Hb20,marca:hyundai,ano:2015";
            var listaDeInformacoes = conteudo.Split(';');

            Console.WriteLine("Carros cadastrados no sistema:");

            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]); // escreve os nomes da lista na posiçao 0
            }

            Console.WriteLine("Informe um nome de carro do sistema:");
            var nomeBusca = Console.ReadLine();

            foreach (var item in listaDeInformacoes)
            {
                var informacoesSplit = item.Split(',');    //separando na virgula

                var carro = informacoesSplit[0].Split(':')[1];         //separando nos :
                var marca = informacoesSplit[1].Split(':')[1];
                var ano = informacoesSplit[2].Split(':')[1];

                if (carro == nomeBusca)

                {
                    Console.WriteLine($"O {carro} da {marca} foi fabricado em {ano}");
                }

            }
            Console.ReadKey();





        }
    }
}
