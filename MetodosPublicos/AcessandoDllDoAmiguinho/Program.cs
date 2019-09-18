using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AcessandoDllDoAmiguinho
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSistema();
        }
        private static void MenuSistema()
        {
            Console.WriteLine("Escolha uma das opçoes do menu");
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
                        MinhaBiblioteca.Metodos.Arvore();
                        Console.ReadKey();

                        Console.Clear();
                        MenuSistema();

                    }
                    break;
                case 2:
                    {
                        MinhaBiblioteca.Metodos.CalcularAreaDoQuadrado();
                        Console.ReadKey();

                        Console.Clear();
                        MenuSistema();
                    }
                    break;
                case 3:
                    {
                        MinhaBiblioteca.Metodos.ListaDeCervejas();
                        Console.ReadKey();

                        Console.Clear();
                        MenuSistema();
                    }
                    break;
                case 4:
                    {
                        MinhaBiblioteca.Metodos.ListaDeMarcasDeCarro();
                        Console.ReadKey();

                        Console.Clear();
                        MenuSistema();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
