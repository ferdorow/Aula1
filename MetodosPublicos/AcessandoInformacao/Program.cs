using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;

namespace AcessandoInformacao
{
    class Program
    {
        static void Main(string[] args)
        {

            MenuSistema();
        }

        private static void MenuSistema()
        {
            Console.WriteLine("Escolha uma das opçoes do menu"); ///menu do sistema
            Console.WriteLine("1 - Mostrar arvore");
            Console.WriteLine("2 - Calculo da area");                 
            Console.WriteLine("3 - Lista de Cervejas");
            Console.WriteLine("4 - Lista de Carros");
            Console.WriteLine("5 - Sair do sistema");

            var menuEscolhido = int.Parse(Console.ReadLine());

            switch (menuEscolhido)
            {
                case 1:
                    {
                        MinhaArvore.ArvoreTosquera();
                    }
                    break;
                case 2:
                    {
                        AreaQuadrado();
                    }
                    break;
                case 3:
                    {
                        MostrarListas.ListaDeCervas();
                    }
                    break;
                case 4:
                    {
                        MostrarListas.CarList();
                    }
                    break;
                default:
                    break;

            }

        }
        public static void AreaQuadrado()
        {
            Console.WriteLine("Informe o lado do quadrado:");
            var ladoQuadrado = int.Parse(Console.ReadLine());

            var bibliotecaCalculos = new CalculoDeArea();

            Console.WriteLine($"Minha area é {bibliotecaCalculos.AreaQuadrado(ladoQuadrado)}");
            Console.ReadKey();

        }

    }
}
